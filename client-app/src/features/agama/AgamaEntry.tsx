import { useEffect } from "react";
import { useStore } from "../../app/stores/Store";
import { observer } from "mobx-react-lite";
import LoadingComponent from "../../app/layout/loadingComponent";
import { Divider, Form, Grid, Header, Image, Label, Segment } from "semantic-ui-react";

export default observer(function AgamaEntry() {

    // const { orgTypeStore } = useStore();
    // const { loadingOrgTypes, orgTypesReg } = orgTypeStore;

    // useEffect(() => {
    //     if (orgTypesReg.size <= 1) loadingOrgTypes();
    // }, [loadingOrgTypes])

    // if (orgTypeStore.loadingInitial) return <LoadingComponent content='Loading App' />

    return (
        <>
            <Header className="ui center aligned header black" as='h1'> ___ ENTRY ___</Header>
            <hr color="red"></hr>
            <Segment>
                <Form>
                    {/* <div className="qfc-container">
                        <div className="inputBox">
                            <input />
                            <span>Id</span>
                        </div>
                        <div className="inputBox">
                            <input placeholder='Kode' />
                            <span>Kode</span>
                        </div>
                    </div> */}
                    <Grid columns={2} relaxed='very'>
                        <Grid.Column>
                            {/* https://www.youtube.com/watch?v=BMphVl9suxA */}
                            <fieldset >
                                <div className="inputBox">
                                    <input placeholder="" required />
                                    <span>Is</span>
                                </div>
                                <div className="inputBox">
                                    <input placeholder="" required />
                                    <span>Dua</span>
                                </div>
                            </fieldset>
                        </Grid.Column>
                        <Grid.Column>
                            <div className="wrapper">
                                <div className="input-data">
                                    <input placeholder="" required />
                                    <label>Uraian</label>
                                </div>
                            </div>

                        </Grid.Column>
                    </Grid>

                    <Divider vertical>And</Divider>
                </Form>
            </Segment>
            <hr color="red"></hr>
        </>
    )
}
)