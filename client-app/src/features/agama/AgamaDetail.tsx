import { useEffect } from "react";
import { useStore } from "../../app/stores/Store";
import { observer } from "mobx-react-lite";
import LoadingComponent from "../../app/layout/loadingComponent";
import { Button, Card, Divider, Grid, Header, Icon, Image, Label, Segment } from "semantic-ui-react";
import React from 'react'
import { AgamaAPI } from "../../app/models/AgamaAPI";

interface Props {
    agama: AgamaAPI
}
export default observer(function AgamaDetail({ agama }: Props) {


    return (
        <>
            <Header className="ui center aligned header black" as='h1'> ___ Detail ___</Header>
            <hr color="red"></hr>
            <div>
                <div className="col-6">
                    satu
                </div>
                <div className="col-sm-4">
                    dua
                </div>
            </div>
        </>
    )
})