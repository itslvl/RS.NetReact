import { observer } from "mobx-react-lite";
import AgamaList from "./AgamaList";
import AgamaEntry from "./AgamaEntry";
import AgamaDetail from "./AgamaDetail";
import { useEffect, useState } from "react";
import { AgamaAPI } from "../../app/models/AgamaAPI";
import axios from "axios";
import { Grid } from "semantic-ui-react";

export default observer(function Agama() {

    const [agamas, setAgamas] = useState<AgamaAPI[]>([]);
    const [selectedAgama, setSelectedAgama] = useState<AgamaAPI | undefined>(undefined);
    const [editMode, setEditMode] = useState(false);

    useEffect(() => {
        axios.get<AgamaAPI[]>('http://localhost:5006/agama')
            .then(response => {
                console.log(response);
                setAgamas(response.data);
            })
    }, [])

    function handleSelectAgama(id: string) {
        setSelectedAgama(agamas.find(x => x.id === id))
    }

    function handleCancelAgama() {
        setSelectedAgama(undefined)
    }

    function handleOpenForm(id?: string) {
        id ? handleSelectAgama(id) : handleCancelAgama();
        setEditMode(true)
    }

    function handleCloseForm() {
        setEditMode(false)
    }
    // const { orgTypeStore } = useStore();
    // const { loadingOrgTypes, orgTypesReg } = orgTypeStore;

    // useEffect(() => {
    //     if (orgTypesReg.size <= 1) loadingOrgTypes();
    // }, [loadingOrgTypes])

    // if (orgTypeStore.loadingInitial) return <LoadingComponent content='Loading App' />

    return (
        <>
            {/* <Grid>
                <AgamaEntry />
            </Grid>
            <Grid>
                <AgamaList agamas={agamas} />

            </Grid> */}
            <Grid>
                <Grid.Column width={16}>
                    {/* //Jika editMode = true */}
                    {editMode &&
                        <AgamaEntry selectedAgama={selectedAgama}
                            selectAgama={handleSelectAgama} cancelAgama={handleCancelAgama}
                            // editMode={editMode} openForm={handleOpenForm}
                            closeForm={handleCloseForm}
                        />}
                </Grid.Column>
                <Grid.Column width={16}>
                    {selectedAgama && !editMode &&
                     <AgamaDetail selectedAgama={selectedAgama} cancelAgama={handleCancelAgama} openForm={handleOpenForm} />}
                    {/* tapilkan detail agama bila ada nilai agamas[0] */}
                </Grid.Column>
                <Grid.Column width={16}>
                    <AgamaList  agamas={agamas} selectAgama={handleSelectAgama} openForm={handleOpenForm} />
                </Grid.Column>
            </Grid>
        </>
    )
}
)