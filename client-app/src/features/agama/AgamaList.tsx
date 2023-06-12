import { useEffect, useState } from "react";
import { useStore } from "../../app/stores/Store";
import { observer } from "mobx-react-lite";
import LoadingComponent from "../../app/layout/loadingComponent";
import { Header, Label, List, Table } from "semantic-ui-react";
import axios from "axios";
import { AgamaAPI } from "../../app/models/AgamaAPI";
import AgamaListContent from "./AgamaListContent";

export default observer(function AgamaList() {

    const [agamas, setAgamas] = useState<AgamaAPI[]>([]);

    useEffect(() => {
        axios.get<AgamaAPI[]>('http://localhost:5006/agama')
            .then(response => {
                console.log(response);
                setAgamas(response.data);
            })
    }, [])

    return (
        <>
            <Label>Ini List</Label>
            <Header as='h2'>Daftar Agama</Header>

            <AgamaListContent agamas={agamas} />
            {/* agamas merupakan nama interface pada Component AgamaListContent
            sedangkan {agamas} adalah diambil dari useState */}
        </>
    )
}
)