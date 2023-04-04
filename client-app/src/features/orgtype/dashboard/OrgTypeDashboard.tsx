import React from "react";
import { Grid, List } from 'semantic-ui-react';
import { OrgType } from "../../../app/models/OrgType";
import OrgTypeList from "./OrgTypeList";
import OrgTypeDetails from "../details/OrgTypeDetails";
// import {OrgType} from '../../../app/models/OrgType'

interface Props {
    orgtypes: OrgType[];
}
export default function OrgTypeDashboard({ orgtypes }: Props) {
    return (
        // <Grid>
        <>
            {/* <Grid.Column width='16'> */}
            {orgtypes[0] &&
                <OrgTypeDetails orgType={orgtypes[0]} />}
            <OrgTypeList orgtypes={orgtypes} />
            {/* </Grid.Column> */}

        </>
        // </Grid>
    )
}