import React from "react";
import { Grid, List } from 'semantic-ui-react';
import { OrgType } from "../../../app/models/OrgType";
import OrgTypeList from "./OrgTypeList";
import OrgTypeDetails from "../details/OrgTypeDetails";
import OrgTypeForm from "../form/OrgTypeForm";
// import {OrgType} from '../../../app/models/OrgType'

interface Props {
    orgTypes: OrgType[];
    selectedOrgType: OrgType | undefined;
    selectOrgType: (id: string) => void;
    cancelSelectOrgType: () => void;
}
export default function OrgTypeDashboard({
    orgTypes,
    selectedOrgType,
    selectOrgType,
    cancelSelectOrgType }: Props) {
    return (
        <>
            {selectedOrgType &&
                <OrgTypeDetails
                    orgType={selectedOrgType}
                    cancelSelectOrgType={cancelSelectOrgType}
                />}
            <OrgTypeForm />
            <OrgTypeList orgTypes={orgTypes}
                selectOrgType={selectOrgType}
            />
        </>
    )
}