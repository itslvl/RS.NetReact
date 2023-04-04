import React from 'react'
import { OrgType } from '../../../app/models/OrgType'
import { Button, Divider, Grid, Item, Label, Segment } from 'semantic-ui-react';

interface Props {
    orgTypes: OrgType[];
    selectOrgType: (id: string) => void;
}

export default function OrgTypeList({ orgTypes, selectOrgType }: Props) {
    return (
        <Segment>
            {/* <Item.Group devided> */}
            {orgTypes.map(orgType => (
                <Item key={orgType.id}>
                    <Item.Content >
                        <Item.Header as='a'>ID : {orgType.id}</Item.Header>
                        <Item.Meta>*</Item.Meta>
                        <Item.Content>
                            <Grid>
                                <Grid.Column width={2}>Code: {orgType.code}</Grid.Column>
                                <Grid.Column width={4}>Display: {orgType.display}</Grid.Column>
                                <Grid.Column width={6}>SaveDate: {orgType.saveDate}</Grid.Column>
                                <Grid.Column width={2}>Delete: {orgType.deleted}</Grid.Column>
                            </Grid>
                        </Item.Content>
                        <Item.Description>
                            <Grid>
                                <Grid.Column width={14}>Definition: {orgType.definition}</Grid.Column>
                                <Grid.Column width={2}>
                                    <Button onClick={() => selectOrgType(orgType.id)} floated='right' content='View' color='blue' />
                                </Grid.Column>
                            </Grid>
                        </Item.Description>
                        <Item.Extra>
                            ***
                            {/* <Button floated='right' content='View' color='blue' /> */}
                            {/* <Label basic content={OrgType.display} /> */}
                        </Item.Extra>
                    </Item.Content>
                </Item>
            ))}
            {/* </Item.Group> */}
        </Segment>
    )
}