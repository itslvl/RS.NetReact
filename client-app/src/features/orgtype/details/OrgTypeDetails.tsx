import React from 'react'
import { Button, Card, Icon, Image } from 'semantic-ui-react'
import { OrgType } from '../../../app/models/OrgType'


interface Props {
    orgType: OrgType;
    cancelSelectOrgType: () => void;
}
export default function OrgTypeDetails({ orgType, cancelSelectOrgType }: Props) {
    return (
        <Card fluid>
            <Image src='/assets/RSS1.png' />
            {/* <Image src='/assets/RS1.png' /> */}
            {/* <Image src='/assets/${orgType}.jpg' />  */}
            <Card.Content>
                <Card.Header>{orgType.id}</Card.Header>
                <Card.Meta>
                    <span >{orgType.saveDate}</span>
                </Card.Meta>
                <Card.Description>
                    {orgType.definition}
                </Card.Description>
            </Card.Content>
            <Card.Content extra>
                <Button.Group width='2'>
                    <Button basic color='blue' content='Edit' />
                    <Button onClick={cancelSelectOrgType} basic color='grey' content='Cancel' />
                </Button.Group>
            </Card.Content>
        </Card>
    )
}