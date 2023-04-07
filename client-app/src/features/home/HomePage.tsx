import { link } from "fs";
import { Link } from "react-router-dom";
import { Container } from "semantic-ui-react";

export default function HomePage () {
    return (
        <Container style={{marginTop:'7em'}}>
            <h1>Home Page</h1>
            <h2>Go To <Link to='/OrgType'>Organization Type</Link></h2>
        </Container>
    )
}