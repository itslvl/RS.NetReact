import React from 'react';
import { Button, Form, Segment } from 'semantic-ui-react';

export default function OrgTypeForm(){
    return(
    <Segment clearing>
        <Form>
            <Form.Input placeholder='Id' />
            <Form.Input placeholder='Save Date' />
            <Form.Input placeholder='Deleted' />
            <Form.Input placeholder='Code' />
            <Form.Input placeholder='Display' />
            <Form.TextArea placeholder='Definition' />
            <Button floated='right' positive type='submit' content='Submit' />
            <Button floated='right'  type='button' content='Cancel' />
        </Form>
    </Segment>
    )
}
