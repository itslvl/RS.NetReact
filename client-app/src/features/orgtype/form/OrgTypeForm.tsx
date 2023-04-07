import React, { ChangeEvent, useEffect, useState } from 'react';
import { Button, Form, Segment } from 'semantic-ui-react';
import { useStore } from '../../../app/stores/Store';
import { observer } from 'mobx-react-lite';
import { Link, useNavigate, useParams } from 'react-router-dom';
import { OrgType } from '../../../app/models/OrgType';
import LoadingComponent from '../../../app/layout/loadingComponent';
import {v4 as uuid} from 'uuid';

// interface Props {
// orgType: OrgType | undefined;
// closeForm: () => void;
// createOrEdit: (OrgType: OrgType) => void;
// submitting: boolean;
// }

// export default function OrgTypeForm({ orgType: selectedOrgType, closeForm , createOrEdit, submitting}: Props) {
// export default function OrgTypeForm({ createOrEdit, submitting }: Props) {
export default observer(function OrgTypeForm() {

    const { orgTypeStore } = useStore();
    const { selectedOrgType,
        createOrgType,
        updateOrgType,
        loading,
        loadingOrgType,
        loadingInitial } = orgTypeStore;
    const {id} = useParams();
    const navigate = useNavigate();
    const [orgType, setorgType] = useState<OrgType>({
        id: '',
        deleted: 0,
        saveDate: '',
        code: '',
        display: '',
        definition: ''
    });
    useEffect (() => {
        if (id) loadingOrgType(id).then( orgType => setorgType(orgType!))
    },[id, loadingOrgType])

    // const initialState = selectedOrgType ?? {
       
    // }
    // const [orgType, setorgType] = useState(initialState)

    function handleSubmit() {
        if (!orgType.id) {
            orgType.id = uuid();
            createOrgType(orgType).then(() => navigate(`/OrgType/${orgType.id}`))
        } else {
            updateOrgType(orgType).then(() => navigate(`/OrgType/${orgType.id}`))
        }
        // orgType.id ? updateOrgType(orgType) : createOrgType(orgType);
    }

    function handleInputChange(event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) {
        const { name, value } = event.target;
        setorgType({ ...orgType, [name]: value })
    }

    if (loadingInitial) return <LoadingComponent content='loading organizatioan type' />

    return (
        <Segment clearing>
            <Form onSubmit={handleSubmit} autoComplete='off'>
                <Form.Input placeholder='Id' value={orgType.id} name='id' onChange={handleInputChange} disabled />
                <Form.Input type='date' placeholder='Save Date' value={orgType.saveDate} name='saveDate' onChange={handleInputChange} />
                <Form.Input placeholder='Deleted' value={orgType.deleted} name='deleted' onChange={handleInputChange} />
                <Form.Input placeholder='Code' value={orgType.code} name='code' onChange={handleInputChange} />
                <Form.Input placeholder='Display' value={orgType.display} name='display' onChange={handleInputChange} />
                <Form.TextArea placeholder='Definition' value={orgType.definition} name='definition' onChange={handleInputChange} />
                <Button loading={loading} floated='right' positive type='submit' content='Submit' />
                <Button as={Link} to='/OrgType' floated='right' type='button' content='Cancel' />
            </Form>
        </Segment>
    )
})
