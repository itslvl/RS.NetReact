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
  const [orgtype, setOrgtype] = useState<OrgType[]>([]);
  useEffect(() => {
    axios.get<OrgType[]>("http://localhost:5006/OrgType")
      .then(response => {
        console.log(response);
        setOrgtype(response.data);
      })
  }, [])
  return (
    <>
      <NavBar />
      {/* <Container style={{marginTop: '5em'}}> */}
      {/* <Header as="h2" content="Organization Types" /> */}
      <Container style={{marginTop: '5em'}}>
        <OrgTypeDashboard orgtypes = {orgtype}/>
      </Container>

    </>
  );
}

export default App;
