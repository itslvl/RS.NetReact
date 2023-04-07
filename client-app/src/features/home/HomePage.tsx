import { link } from "fs";
import { Link } from "react-router-dom";
import { Container, Header, Segment, Image, Button } from "semantic-ui-react";

export default function HomePage() {
    return (

        <Segment inverted textAlign="center" vertical className="masterhead">
            <Container text>
                <Header as='h1' inverted>
                    <Image size='massive' src="/assets/sibolgalogo.png" alt='logo' style={{ marginBottom: 12 }} />
                </Header>
                <Header as='h2' inverted content='Wellcome to RS.NetReact' />
                <Button as={Link} to='/OrgType' size='huge' inverted >
                    Go To Web
                </Button>
            </Container>

        </Segment>
        // <Container style={{marginTop:'7em'}}>
        //     <h1>Home Page</h1>
        //     <h2>Go To <Link to='/OrgType'>Organization Type</Link></h2>
        // </Container>
    )
}