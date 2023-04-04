import React from 'react'
import { OrgType } from '../../../app/models/OrgType'
import { Button, Divider, Grid, Item, Label, Segment } from 'semantic-ui-react';
interface Props {
    orgtypes: OrgType[];
}
export default function OrgTypeList({ orgtypes }: Props) {
    return (
        <Segment>
            {/* <Item.Group devided> */}
                {orgtypes.map(OrgType => (
                    <Item key={OrgType.id}>
                        <Item.Content >
                            <Item.Header as='a'>ID : {OrgType.id}</Item.Header>
                            <Item.Meta>*</Item.Meta>
                            <Item.Content>
                                <Grid>
                                    <Grid.Column width={2}>Code: {OrgType.code}</Grid.Column>
                                    <Grid.Column width={4}>Display: {OrgType.display}</Grid.Column>
                                    <Grid.Column width={6}>SaveDate: {OrgType.saveDate}</Grid.Column>
                                    <Grid.Column width={2}>Delete: {OrgType.deleted}</Grid.Column>
                                </Grid>
                            </Item.Content>
                            <Item.Description>
                                <Grid>
                                    <Grid.Column width={14}>Definition: {OrgType.definition}</Grid.Column>
                                    <Grid.Column width={2}>
                                        <Button floated='right' content='View' color='blue' />
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