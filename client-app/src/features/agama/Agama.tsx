import { observer } from "mobx-react-lite";
import AgamaList from "./AgamaList";
import AgamaEntry from "./AgamaEntry";
import AgamaDetail from "./AgamaDetail";
import { useEffect, useState } from "react";
import { AgamaAPI } from "../../app/models/AgamaAPI";
import { Grid } from "semantic-ui-react";
import { v4 as uuid } from 'uuid'
import agent from "../../app/api/Agent";
import LoadingComponent from "../../app/layout/loadingComponent";

export default observer(function Agama() {

    const [agamas, setAgamas] = useState<AgamaAPI[]>([]);
    const [selectedAgama, setSelectedAgama] = useState<AgamaAPI | undefined>(undefined);
    const [editMode, setEditMode] = useState(false);
    const [loading, setLoading] = useState(true);
    const [submitting, setSubmitting] = useState(false);

    useEffect(() => {
        agent.Agama.list().then(response => {
            let agamas: AgamaAPI[] = [];
            response.forEach(agama => {
                agama.timeStamp = agama.timeStamp.split('T')[0];
                agamas.push(agama);
            })
            setAgamas(agamas)
            setLoading(false)
        })

        // axios.get<AgamaAPI[]>('http://localhost:5006/agama')
        //     .then(response => {
        //         console.log(response);
        //         setAgamas(response.data);
        //     })
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

    function handleDelete(id: string) {
        setAgamas([...agamas.filter(x => x.id != id)])
    }

    function handelCreateOrEdit(agama: AgamaAPI) {
        setSubmitting(true);
        if (agama.id) {
            agent.Agama.update(agama).then(() => {
                setAgamas([...agamas.filter(x => x.id !== agama.id), agama])
                setSelectedAgama(agama);
                setEditMode(false);
                setSubmitting(false);
            })
        } else {
            agama.id = uuid()
            agent.Agama.create(agama).then(() => {
                setAgamas([...agamas, agama])
                setSelectedAgama(agama);
                setEditMode(false);
                setSubmitting(false);
            })
        }
        // agama.id
        //     ? setAgamas([...agamas.filter(x => x.id !== agama.id), agama])
        //     : setAgamas([...agamas, { ...agama, id: uuid() }]);
        // setEditMode(false)
        // setSelectedAgama(agama);

    }
    // const { orgTypeStore } = useStore();
    // const { loadingOrgTypes, orgTypesReg } = orgTypeStore;

    // useEffect(() => {
    //     if (orgTypesReg.size <= 1) loadingOrgTypes();
    // }, [loadingOrgTypes])

    // if (orgTypeStore.loadingInitial) return <LoadingComponent content='Loading App' />

    if (loading) return <LoadingComponent content=" ... Loading" />
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
                            createOrEdit={handelCreateOrEdit}
                            submitting={submitting}
                        />}
                </Grid.Column>
                <Grid.Column width={16}>
                    {selectedAgama && !editMode &&
                        <AgamaDetail selectedAgama={selectedAgama} cancelAgama={handleCancelAgama} openForm={handleOpenForm} />}
                    {/* tapilkan detail agama bila ada nilai agamas[0] */}
                </Grid.Column>
                <Grid.Column width={16}>
                    <AgamaList agamas={agamas} selectAgama={handleSelectAgama}
                        openForm={handleOpenForm} deleteItem={handleDelete} />
                </Grid.Column>
            </Grid>
        </>
    )
}
)