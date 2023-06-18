import { Button, Divider, Grid, Header, Label, List, Segment } from "semantic-ui-react";
import { useStore } from "../../app/stores/Store";
import LoadingComponent from "../../app/layout/loadingComponent";
import { observer } from "mobx-react-lite";

// interface Props {
// selectedAgama: AgamaAPI;
// cancelAgama: () => void;
// openForm: (id: string) => void;
// }
export default observer(function AgamaDetail() {

    const { agamaStore } = useStore()
    const { selectedAgama: agama, openForm, cancelAgama } = agamaStore

    if (!agama) return <LoadingComponent />

    return (
        <>
            <Header className="ui center aligned header black" as='h1'> ___ Detail ___</Header>
            {/* {console.log(selectedAgama)} */}
            <hr color="red"></hr>
            <Segment>
                <Grid columns={2} relaxed='very'>
                    <Grid.Column>
                        <List divided selection>
                            <List.Item>
                                <Label color='green' horizontal style={{ width: '6em' }} >
                                    Id
                                </Label>
                                {agama.id}
                            </List.Item>
                            <List.Item>
                                <Label color='grey' horizontal style={{ width: '6em' }} >
                                    Deleted
                                </Label>
                                {agama.kode}
                            </List.Item>
                            <List.Item>
                                <Label color='grey' horizontal style={{ width: '6em' }} >
                                    Kode
                                </Label>
                                {agama.deleted}
                            </List.Item>
                        </List>
                    </Grid.Column>
                    <Grid.Column>
                        <List>
                            <List.Item>
                                <Label color='grey' horizontal style={{ width: '6em' }} >
                                    Time Stamp
                                </Label>
                                {agama.timeStamp}
                            </List.Item>
                            <List.Item>
                                <Label color='grey' horizontal style={{ width: '6em' }} >
                                    Uraian
                                </Label>
                                {agama.uraian}
                            </List.Item>
                        </List>
                        <Button onClick={() => openForm(agama.id)} basic color='blue' content='Edit' />
                        <Button onClick={() => cancelAgama()} basic color='grey' content='Cancel' />
                    </Grid.Column>
                </Grid>

                <Divider vertical>//</Divider>
            </Segment >
        </>
    )
})