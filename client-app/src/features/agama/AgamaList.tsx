import { useEffect, useState } from "react";
import { useStore } from "../../app/stores/Store";
import { observer } from "mobx-react-lite";
import LoadingComponent from "../../app/layout/loadingComponent";
import { Button, Header, Icon, Input, Label, List, Table } from "semantic-ui-react";
import axios from "axios";
import { AgamaAPI } from "../../app/models/AgamaAPI";
import AgamaListContent from "./AgamaListContent";
import { Link } from "react-router-dom";

interface Props {
    agamas: AgamaAPI[];
    selectAgama: (id: string) => void;
    openForm: () => void;
    deleteItem: (id: string) => void;
}
export default observer(function AgamaList({ agamas, selectAgama, openForm, deleteItem }: Props) {

    return (
        <>
            <Input icon='users' iconPosition='left' placeholder='Search users...' />
            <Header className="ui center aligned header black" as='h1'>
                ==|  LIST  Uji Coba |==
                <Label as='a' color="red" corner onClick={openForm}>
                    <Icon name='add' />
                </Label>

            </Header>
            <hr color="red"></hr>

            <Table className="ui compact table striped">
                <Table.Header>
                    <Table.Row>
                        <Table.HeaderCell>Id</Table.HeaderCell>
                        <Table.HeaderCell>Kode</Table.HeaderCell>
                        <Table.HeaderCell>Uraian</Table.HeaderCell>
                        <Table.HeaderCell>TimeStamp</Table.HeaderCell>
                        <Table.HeaderCell>Deleted</Table.HeaderCell>
                        <Table.HeaderCell>Action</Table.HeaderCell>
                    </Table.Row>
                </Table.Header >

                <Table.Body>
                    {agamas.map((agama: any) => (

                        <Table.Row key={agama.id}>
                            <Table.Cell>
                                {/* <Button > */}
                                {agama.id.substring(0, 7).toUpperCase()}
                                {/* </Button> */}
                            </Table.Cell>
                            <Table.Cell>{agama.kode}</Table.Cell>
                            <Table.Cell>{agama.uraian}</Table.Cell>
                            <Table.Cell>{agama.timeStamp}</Table.Cell>
                            <Table.Cell>{agama.deleted}</Table.Cell>
                            <Table.Cell>
                                <Button.Group>
                                    <Button compact size='mini' positive onClick={() => selectAgama(agama.id)}>Pick</Button>
                                    <Button.Or />
                                    <Button size='mini' negative onClick={() => deleteItem(agama.id)}>Del</Button>
                                </Button.Group>
                                {/* <Button as='a' onClick={() => deleteItem(agama.id)}>Del</Button> */}
                            </Table.Cell>
                        </Table.Row>

                    ))}
                </Table.Body>
            </Table >
            {/* <AgamaListContent agamas={agamas} /> */}
            {/* agamas merupakan nama interface pada Component AgamaListContent
            sedangkan {agamas} adalah diambil dari useState */}
        </>
    )
}
)