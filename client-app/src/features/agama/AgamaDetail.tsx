import { useEffect } from "react";
import { useStore } from "../../app/stores/Store";
import { observer } from "mobx-react-lite";
import LoadingComponent from "../../app/layout/loadingComponent";
import { Button, Card, Divider, Grid, Header, Icon, Image, Label, List, Segment } from "semantic-ui-react";
import React from 'react'
import { AgamaAPI } from "../../app/models/AgamaAPI";

interface Props {
    selectedAgama: AgamaAPI;
    cancelAgama: () => void;
    openForm: (id: string) => void;
}
export default observer(function AgamaDetail({ selectedAgama, cancelAgama, openForm }: Props) {


    return (
        <>
            <Header className="ui center aligned header black" as='h1'> ___ Detail ___</Header>
            <hr color="red"></hr>
            <Segment>
                <Grid columns={2} relaxed='very'>
                    <Grid.Column>
                        <List divided selection>
                            <List.Item>
                                <Label color='green' horizontal style={{ width: '6em' }} >
                                    Id
                                </Label>
                                {selectedAgama.id}
                            </List.Item>
                            <List.Item>
                                <Label color='grey' horizontal style={{ width: '6em' }} >
                                    Kode
                                </Label>
                                {selectedAgama.kode}
                            </List.Item>
                            <List.Item>
                                <Label color='grey' horizontal style={{ width: '6em' }} >
                                    Kode
                                </Label>
                                {selectedAgama.kode}
                            </List.Item>
                        </List>
                    </Grid.Column>
                    <Grid.Column>
                        <List>
                            <List.Item>
                                <Label color='grey' horizontal style={{ width: '6em' }} >
                                    Time Stamp
                                </Label>
                                {selectedAgama.timestamp}
                            </List.Item>
                            <List.Item>
                                <Label color='grey' horizontal style={{ width: '6em' }} >
                                    Uraian
                                </Label>
                                {selectedAgama.uraian}
                            </List.Item>
                        </List>
                        <Button onClick={() => openForm(selectedAgama.id)} basic color='blue' content='Edit' />
                        <Button onClick={cancelAgama} basic color='grey' content='Cancel' />
                    </Grid.Column>
                </Grid>

                <Divider vertical>//</Divider>
            </Segment >
        </>
    )
})