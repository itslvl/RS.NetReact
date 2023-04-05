import { useEffect, useState } from 'react';
// import logo from './logo.svg';
// import './App.css';
// import axios from 'axios';
import { Container } from 'semantic-ui-react';
import { OrgType } from '../models/OrgType'
import NavBar from './NavBar';
import OrgTypeDashboard from '../../features/orgtype/dashboard/OrgTypeDashboard';
import { v4 as uuid } from 'uuid';
import agent from '../api/Agent';
import LoadingComponent from './loadingComponent';


function App() {
  const [orgTypes, setOrgTypes] = useState<OrgType[]>([]);
  const [selectedOrgType, setSelectedOrgType] = useState<OrgType | undefined>(undefined);
  const [editMode, setEditMode] = useState(false);
  const [loading, setLoading] = useState(true);
  const [submitting, setSubmitting] = useState(false);

  useEffect(() => {
    agent.OrgTypes.list().then(response => {
      let orgTypes: OrgType[] = [];
      response.forEach(orgType => {
        orgType.saveDate = orgType.saveDate.split('T')[0];
        orgTypes.push(orgType);
      });
      setOrgTypes(orgTypes);
      setLoading(false);
    })
  }, [])

  function handleSelectOrgType(id: string) {
    setSelectedOrgType(orgTypes.find(a => a.id === id))
  }

  function handleCancelSelectOrgType() {
    setSelectedOrgType(undefined);
  }

  function handleOpenForm(id?: string) {
    id ? handleSelectOrgType(id) : handleCancelSelectOrgType();
    setEditMode(true);
  }

  function handleCloseForm() {
    setEditMode(false);
  }

  function handleCreateOrEditOrgType(orgType: OrgType) {
    setSubmitting(true);
    if (orgType.id) {
      agent.OrgTypes.update(orgType).then(() => {
        setOrgTypes([...orgTypes.filter(a => a.id !== orgType.id), orgType]);
        setSelectedOrgType(orgType);
        setEditMode(false);
        setSubmitting(false);
      })
    } else {
      orgType.id = uuid();
      agent.OrgTypes.create(orgType).then(() => {
        setOrgTypes([...orgTypes, orgType]);
        setSelectedOrgType(orgType);
        setEditMode(false);
        setSubmitting(false);
      })
    }
    // orgType.id
    //   ? setOrgTypes([...orgTypes.filter(a => a.id !== orgType.id), orgType])
    //   // : setOrgTypes([...orgTypes, orgType]) //add new orgType To array
    //   : setOrgTypes([...orgTypes, { ...orgType, id: uuid() }]) //add new orgType To array
    // setEditMode(false);
    // setSelectedOrgType(orgType);
  }

  function handleDeleteOrgType(id: string) {
    setSubmitting(true);
    agent.OrgTypes.delete(id).then(() => {
      setOrgTypes([...orgTypes.filter(a => a.id !== id)])
      setSubmitting(false);
    })

    // setOrgTypes([...orgTypes.filter(a => a.id !== id)])
  }

  if (loading) return <LoadingComponent content='Loading App' />

  return (
    <>
      <NavBar openForm={handleOpenForm} />
      {/* <Container style={{marginTop: '5em'}}> */}
      {/* <Header as="h2" content="Organization Types" /> */}
      <Container style={{ marginTop: '5em' }}>
        <OrgTypeDashboard
          orgTypes={orgTypes}
          selectedOrgType={selectedOrgType}
          selectOrgType={handleSelectOrgType}
          cancelSelectOrgType={handleCancelSelectOrgType}
          editMode={editMode}
          openForm={handleOpenForm}
          closeForm={handleCloseForm}
          createOrEdit={handleCreateOrEditOrgType}
          deleteOrgType={handleDeleteOrgType}
          submitting={submitting}
        />
      </Container>

    </>
  );
}

export default App;
