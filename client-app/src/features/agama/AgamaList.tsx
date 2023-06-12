import { useEffect, useState } from "react";
import { useStore } from "../../app/stores/Store";
import { observer } from "mobx-react-lite";
import LoadingComponent from "../../app/layout/loadingComponent";
import { Header, Label, List, Table } from "semantic-ui-react";
import axios from "axios";

export default observer(function AgamaList() {

    const [agamas, setAgamas] = useState([]);

    useEffect(() => {
        axios.get('http://localhost:5006/agama')
            .then(response => {
                console.log(response);
                setAgamas(response.data);
            })
    }, [])

    return (
        <>
            <Label>Ini List</Label>
            <Header>Daftar Agama</Header>
            <List>
                {agamas.map((agama: any) => (
                    <List.Item key={agama.id}>
                        {agama.id}
                        {agama.uraian}
                        {agama.timestamp}
                        {agama.deleted}
                        {agama.kode}
                    </List.Item>
                ))}
            </List>
            <Table striped>
                <Table.Header>
                    <Table.Row>
                        <Table.HeaderCell>Id</Table.HeaderCell>
                        <Table.HeaderCell>Kode</Table.HeaderCell>
                        <Table.HeaderCell>Uraian</Table.HeaderCell>
                        <Table.HeaderCell>TimeStamp</Table.HeaderCell>
                        <Table.HeaderCell>Deleted</Table.HeaderCell>
                    </Table.Row>
                </Table.Header>

                <Table.Body>
                {agamas.map((agama: any) => (

                    <Table.Row key={agama.id}>
                        <Table.Cell>{agama.id}</Table.Cell>
                        <Table.Cell>{agama.kode}</Table.Cell>
                        <Table.Cell>{agama.uraian}</Table.Cell>
                        <Table.Cell>{agama.timeStamp}</Table.Cell>
                        <Table.Cell>{agama.deleted}</Table.Cell>
                    </Table.Row>
                ))}

                </Table.Body>
            </Table>
        </>
    )
}
)