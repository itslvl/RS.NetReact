import { observer } from "mobx-react-lite";
import AgamaList from "./AgamaList";
import AgamaEntry from "./AgamaEntry";
import AgamaDetail from "./AgamaDetail";
import { useEffect } from "react";
import { Grid } from "semantic-ui-react";
import LoadingComponent from "../../app/layout/loadingComponent";
import { useStore } from "../../app/stores/Store";

export default observer(function Agama() {
    const { agamaStore } = useStore()

    
    // const [agamas, setAgamas] = useState<AgamaAPI[]>([]);
    // const [selectedAgama, setSelectedAgama] = useState<AgamaAPI | undefined>(undefined);
    // const [editMode, setEditMode] = useState(false);
    // const [loading, setLoading] = useState(true);
    // const [submitting, setSubmitting] = useState(false);

    useEffect(() => {
        agamaStore.loadAgamas();
    }, [agamaStore])

    // function handleSelectAgama(id: string) {
    //     setSelectedAgama(agamas.find(x => x.id === id))
    // }

    // function handleCancelAgama() {
    //     setSelectedAgama(undefined)
    // }

    // function handleOpenForm(id?: string) {
    //     id ? handleSelectAgama(id) : handleCancelAgama();
    //     setEditMode(true)
    // }

    // function handleCloseForm() {
    //     setEditMode(false)
    // }

    // function handleDelete(id: string, timeStamp: string) {
    //     setSubmitting(true);
    //     agent.Agama.delete(id, timeStamp).then(() => {
    //         setAgamas([...agamas.filter(x => x.id != id)])
    //         // setEditMode(false);
    //         setSubmitting(false);
    //     })
    //     // setAgamas([...agamas.filter(x => x.id != id)])
    // }

    // function handelCreateOrEdit(agama: AgamaAPI) {
    //     setSubmitting(true);
    //     if (agama.id) {
    //         agent.Agama.update(agama).then(() => {
    //             setAgamas([...agamas.filter(x => x.id !== agama.id), agama])
    //             setSelectedAgama(agama);
    //             setEditMode(false);
    //             setSubmitting(false);
    //         })
    //     } else {
    //         agama.id = uuid()
    //         agama.timeStamp = new Date().toISOString()
    //         agent.Agama.create(agama).then(() => {
    //             setAgamas([...agamas, agama])
    //             setSelectedAgama(agama);
    //             setEditMode(false);
    //             setSubmitting(false);
    //         })
    //     }
    //     // agama.id
    //     //     ? setAgamas([...agamas.filter(x => x.id !== agama.id), agama])
    //     //     : setAgamas([...agamas, { ...agama, id: uuid() }]);
    //     // setEditMode(false)
    //     // setSelectedAgama(agama);

    // }
    // const { orgTypeStore } = useStore();
    // const { loadingOrgTypes, orgTypesReg } = orgTypeStore;

    // useEffect(() => {
    //     if (orgTypesReg.size <= 1) loadingOrgTypes();
    // }, [loadingOrgTypes])

    // if (orgTypeStore.loadingInitial) return <LoadingComponent content='Loading App' />

    if (agamaStore.loadingInitial) return <LoadingComponent content=" ... Loading" />

    return (
        <>
            {/* <Grid>
                <AgamaEntry />
            </Grid>
            <Grid>
                <AgamaList agamas={agamas} />

            </Grid> */}
            {/* <h2>{agamaStore.uraian}</h2>
            <Button content='add exclamation' positive onClick={agamaStore.setTitle} /> */}
            <Grid>
                <Grid.Column width={16}>
                    {/* //Jika editMode = true */}
                    {agamaStore.editMode &&
                        <AgamaEntry
                            // selectedAgama={selectedAgama}
                            // selectAgama={handleSelectAgama} 
                            // cancelAgama={handleCancelAgama}
                            // editMode={editMode} openForm={handleOpenForm}
                            // closeForm={handleCloseForm}
                            // createOrEdit={handelCreateOrEdit}
                            // submitting={submitting}
                        />}
                </Grid.Column>
                <Grid.Column width={16}>
                    {agamaStore.selectedAgama && !agamaStore.editMode &&
                        <AgamaDetail
                        // selectedAgama={selectedAgama}
                        // cancelAgama={handleCancelAgama} 
                        // openForm={handleOpenForm} 
                        />}
                    {/* tapilkan detail agama bila ada nilai agamas[0] */}
                </Grid.Column>
                <Grid.Column width={16}>
                    <AgamaList 
                    // agamas={agamaStore.agamas}
                    //     // selectAgama={handleSelectAgama}
                    //     submitting={submitting}
                    //     // openForm={handleOpenForm} 
                    //     deleteItem={handleDelete}
                         />
                </Grid.Column>
            </Grid>
        </>
    )
}
)