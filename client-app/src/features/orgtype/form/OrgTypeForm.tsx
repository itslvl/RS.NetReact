import React, { ChangeEvent, useState } from 'react';
import { Button, Form, Segment } from 'semantic-ui-react';
import { OrgType } from '../../../app/models/OrgType';

interface Props {
    orgType: OrgType | undefined;
    closeForm: () => void;
    createOrEdit : (OrgType: OrgType) => void;
    submitting : boolean;
}

export default function OrgTypeForm({ orgType: selectedOrgType, closeForm , createOrEdit, submitting}: Props) {

    const initialState = selectedOrgType ?? {
        id: '',
        deleted: 0,
        saveDate: '',
        code: '',
        display: '',
        definition: ''
    }
    const [orgType, setorgType] = useState(initialState)

    function handleSubmit() {
        createOrEdit(orgType);
        // console.log(orgType);
    }

    function handleInputChange(event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) {
        const { name, value } = event.target;
        setorgType({ ...orgType, [name]: value })
    }
    return (
        <Segment clearing>
            <Form onSubmit={handleSubmit} autoComplete='off'>
                <Form.Input placeholder='Id' value={orgType.id} name='id' onChange={handleInputChange}  disabled/>
                <Form.Input type='date' placeholder='Save Date' value={orgType.saveDate} name='saveDate' onChange={handleInputChange} />
                <Form.Input placeholder='Deleted' value={orgType.deleted} name='deleted' onChange={handleInputChange} />
                <Form.Input placeholder='Code' value={orgType.code} name='code' onChange={handleInputChange} />
                <Form.Input placeholder='Display' value={orgType.display} name='display' onChange={handleInputChange} />
                <Form.TextArea placeholder='Definition' value={orgType.definition} name='definition' onChange={handleInputChange} />
                <Button loading={submitting} floated='right' positive type='submit' content='Submit' />
                <Button onClick={closeForm} floated='right' type='button' content='Cancel' />
            </Form>
        </Segment>
    )
}
