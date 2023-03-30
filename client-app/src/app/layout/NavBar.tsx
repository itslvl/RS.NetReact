import react from 'react';
import { Button, Container, Menu } from 'semantic-ui-react';

export default function NavBar() {
    return (
        <Menu inverted fixed='top'>
            <Container>
                <Menu.Item header>
                    <img src="/assets/sibolgalogo.png" alt="logo" style={{marginRight: '10px'}}/>
                    RS.NetReact App
                </Menu.Item>
                <Menu.Item name='OrgType'/>
                <Menu.Item>
                    <Button positive content='Create OrgType' />
                </Menu.Item>
            </Container>
        </Menu>
    )
}