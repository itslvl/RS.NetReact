import { useEffect, useState } from "react";
import { useStore } from "../../app/stores/Store";
import { observer } from "mobx-react-lite";
import LoadingComponent from "../../app/layout/loadingComponent";
import { Header, Label, List, Table } from "semantic-ui-react";
import axios from "axios";
import { AgamaAPI } from "../../app/models/AgamaAPI";
import AgamaListContent from "./AgamaListContent";

interface Props {
    agamas : AgamaAPI[]
}
export default observer(function AgamaList({agamas} : Props) {

    return (
        <>
            <AgamaListContent agamas={agamas} />
            {/* agamas merupakan nama interface pada Component AgamaListContent
            sedangkan {agamas} adalah diambil dari useState */}
        </>
    )
}
)