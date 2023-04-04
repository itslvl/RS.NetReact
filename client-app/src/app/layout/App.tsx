import React, { useEffect, useState } from 'react';
// import logo from './logo.svg';
// import './App.css';
import axios from 'axios';
import { Container, Header, List } from 'semantic-ui-react';
import Button from 'semantic-ui-react/dist/commonjs/elements/Button';
import { OrgType } from '../models/OrgType'
import NavBar from './NavBar';
import OrgTypeDashboard from '../../features/orgtype/dashboard/OrgTypeDashboard';

function App() {
  const [orgTypes, setOrgTypes] = useState<OrgType[]>([]);
  const [selectedOrgType, setSelectedOrgType] = useState<OrgType | undefined>(undefined);

  useEffect(() => {
    axios.get<OrgType[]>("http://localhost:5006/OrgType")
      .then(response => {
        console.log(response);
        setOrgTypes(response.data);
      })
  }, [])

  function handleSelectOrgType(id: string) {
    setSelectedOrgType(orgTypes.find(a => a.id === id))
  }

  function handleCancelSelectOrgType() {
    setSelectedOrgType(undefined);
  }

  return (
    <>
      <NavBar />
      {/* <Container style={{marginTop: '5em'}}> */}
      {/* <Header as="h2" content="Organization Types" /> */}
      <Container style={{ marginTop: '5em' }}>
        <OrgTypeDashboard
          orgTypes={orgTypes}
          selectedOrgType={selectedOrgType}
          selectOrgType={handleSelectOrgType}
          cancelSelectOrgType={handleCancelSelectOrgType}
        />
      </Container>

    </>
  );
}

export default App;
