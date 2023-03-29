import React, { useEffect, useState } from 'react';
// import logo from './logo.svg';
// import './App.css';
import axios from 'axios';
import { Container, Header, List } from 'semantic-ui-react';
import Button from 'semantic-ui-react/dist/commonjs/elements/Button';
import { OrgType } from '../models/OrgType'
import NavBar from './NavBar';

function App() {
  const [orgtype, setOrgtype] = useState<OrgType[]>([]);
  useEffect(() => {
    axios.get<OrgType[]>("http://localhost:5006/OrgType")
      .then(response => {
        // console.log(response);
        setOrgtype(response.data);
      })
  }, [])
  return (
    <>
      <NavBar />
      <Container style={{marginTop: '5em'}}>
        <List>
          {orgtype.map(a => (
            <List.Item key={a.id}>
              {a.definition}
            </List.Item>
          ))}
        </List>
      </Container>
    </>
  );
}

export default App;
