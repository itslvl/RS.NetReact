import { ChangeEvent, HtmlHTMLAttributes, useEffect, useState } from "react";
import { useStore } from "../../app/stores/Store";
import { observer } from "mobx-react-lite";
import LoadingComponent from "../../app/layout/loadingComponent";
import { Button, Divider, Form, FormGroup, Grid, Header, Image, Input, Label, Segment, TextArea } from "semantic-ui-react";
import { AgamaAPI } from "../../app/models/AgamaAPI";

interface Props {
    selectedAgama: AgamaAPI | undefined;
    selectAgama: (id: string) => void;
    cancelAgama: () => void;
    // editMode: boolean;
    // openForm: (id: string) => void;
    closeForm: () => void;
    createOrEdit: (agama: AgamaAPI) => void;
    submitting: boolean
}

export default observer(function AgamaEntry({ selectAgama, selectedAgama,
    cancelAgama, closeForm, createOrEdit, submitting }: Props) {

    const initialState = selectedAgama ?? {
        id: '',
        kode: 0,
        deleted: 0,
        uraian: '',
        timeStamp: ''
    }

    const [agamaForm, setAgamaForm] = useState(initialState);

    function handleSubmit() {
        createOrEdit(agamaForm)
        // console.log(agamaForm);
    }

    function handleInput(event: ChangeEvent<HTMLInputElement>) {
        const { name, value } = event.target;
        setAgamaForm({ ...agamaForm, [name]: value })
        // console.log('agamaForm', agamaForm)
        // console.log('initial', initialState)
    }

    return (
        <>
            <Header className="ui center aligned header black" as='h1'> ___ ENTRY ___</Header>
            <Segment clearing>
                <Form onSubmit={handleSubmit} autoComplete='off'>
                    <Form.Group widths='equal'>
                        <Form.Field
                            // id='form-input-control-first-name'
                            control={Input}
                            label='Id' placeholder='Id'
                            value={agamaForm.id} name='id'
                            onChange={handleInput}
                        />
                        <Form.Field
                            // id='form-input-control-first-name'
                            control={Input}
                            label='Kode'
                            placeholder='Kode'
                            value={agamaForm.kode} name='kode'
                            onChange={handleInput}
                        />
                        <Form.Field
                            // id='form-input-control-first-deleted'
                            control={Input}
                            label='Deleted'
                            placeholder='Deleted'
                            value={agamaForm.deleted} name='deleted'
                            onChange={handleInput}
                        />
                    </Form.Group>
                    {/* <Form.Field
                        // id='form-input-control-first-deleted'
                        control={Input}
                        label='Time Stamp'
                        placeholder='timeStamp'
                        type='date'
                        value={agamaForm.timeStamp} name='timeStamp'
                        onChange={handleInput}
                    /> */}
                    <Form.Field
                        id='form-textarea-control-opinion'
                        control={TextArea}
                        label='Uraian'
                        placeholder='Uraian'
                        value={agamaForm.uraian} name='uraian'
                        onChange={handleInput}
                    />
                    <Button loading={submitting} onClick={handleSubmit} floated='right' positive type='submit' content='Submit' />
                    {/* <Button onClick={handleSubmit} floated='right' positive type='submit' content='Submit' /> */}
                    <Button onClick={closeForm} floated='right' type='button' content='Cancel' />
                </Form>
            </Segment>
        </>
    )
}
)