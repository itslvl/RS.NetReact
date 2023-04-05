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
    editMode: boolean;
    openForm: (id: string) => void;
    closeForm: () => void;
    createOrEdit: (orgType: OrgType) => void;
    deleteOrgType: (id: string) => void;
    submitting: boolean;
}
export default function OrgTypeDashboard({
    orgTypes,
    selectedOrgType,
    selectOrgType,
    cancelSelectOrgType,
    editMode,
    openForm,
    closeForm,
    createOrEdit,
    deleteOrgType,
    submitting }: Props) {
    return (
        <>
            {selectedOrgType && !editMode &&
                <OrgTypeDetails
                    orgType={selectedOrgType}
                    cancelSelectOrgType={cancelSelectOrgType}
                    openForm={openForm}
                />}
            {editMode &&
                <OrgTypeForm
                    closeForm={closeForm}
                    orgType={selectedOrgType}
                    createOrEdit={createOrEdit} 
                    submitting={submitting}
                    />}
            <OrgTypeList
                orgTypes={orgTypes}
                selectOrgType={selectOrgType}
                deleteOrgType={deleteOrgType}
                submitting={submitting}
            />
        </>
    )
}