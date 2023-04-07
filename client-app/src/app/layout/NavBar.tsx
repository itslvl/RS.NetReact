// import react from 'react';
import { Button, Container, Menu } from 'semantic-ui-react';
// import { useStore } from '../stores/Store';
import { NavLink } from 'react-router-dom';

// interface Props{
//     openForm: () => void;
// }
// export default function NavBar({openForm}: Props) {
export default function NavBar() {
    // const {orgTypeStore} = useStore();
    return (
        <Menu inverted fixed='top'>
            <Container>
                <Menu.Item as={NavLink}  to='/' header>
                    <img src="/assets/sibolgalogo.png" alt="logo" style={{ marginRight: '10px' }} />
                    RS.NetReact App
                </Menu.Item>
                <Menu.Item as={NavLink} to='/OrgType' name='OrgType' />
                <Menu.Item>
                    <Button as={NavLink} to='/createOrgType' positive content='Create OrgType' />
                </Menu.Item>
            </Container>
        </Menu>
    )
}