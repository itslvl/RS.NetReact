import { useEffect } from "react";
import { useStore } from "../../app/stores/Store";
import { observer } from "mobx-react-lite";
import LoadingComponent from "../../app/layout/loadingComponent";
import { Button, Divider, Form, FormGroup, Grid, Header, Image, Input, Label, Segment, TextArea } from "semantic-ui-react";
import { AgamaAPI } from "../../app/models/AgamaAPI";

interface Props {
    selectedAgama : AgamaAPI | undefined;
    selectAgama : (id : string) => void;
    cancelAgama : () => void;
}

export default observer(function AgamaEntry({selectAgama, selectedAgama, cancelAgama} : Props) {

    // const { orgTypeStore } = useStore();
    // const { loadingOrgTypes, orgTypesReg } = orgTypeStore;

    // useEffect(() => {
    //     if (orgTypesReg.size <= 1) loadingOrgTypes();
    // }, [loadingOrgTypes])

    // if (orgTypeStore.loadingInitial) return <LoadingComponent content='Loading App' />

    return (
        <>
            <Header className="ui center aligned header black" as='h1'> ___ ENTRY ___</Header>
            <Segment clearing>
                <Form>
                    <Form.Group widths='equal'>
                        <Form.Field
                            // id='form-input-control-first-name'
                            control={Input}
                            label='Id'
                            placeholder='Id'
                        />
                        <Form.Field
                            // id='form-input-control-first-name'
                            control={Input}
                            label='Kode'
                            placeholder='Kode'
                        />
                        <Form.Field
                            // id='form-input-control-first-deleted'
                            control={Input}
                            label='Deleted'
                            placeholder='Deleted'
                        />
                        {/* <Form.Input placeholder='Id' label='Id' />
                        <Form.Input placeholder='Kode' />
                        <Form.Input placeholder='Deleted' />
                        <Form.Input placeholder='TimeStamp' />
                        <Form.Input placeholder='Uraian' /> */}
                    </Form.Group>
                    <Form.Field
                        // id='form-input-control-first-deleted'
                        control={Input}
                        label='Time Stamp'
                        placeholder='timeStamp'
                    />
                    <Form.Field
                        id='form-textarea-control-opinion'
                        control={TextArea}
                        label='Uraian'
                        placeholder='Uraian'
                    />
                    <Button floated='right' positive type='submit' content='Submit'/>
                    <Button floated='right'  type='button' content='Cancel'/>
                </Form>
            </Segment>
        </>
    )
}
)