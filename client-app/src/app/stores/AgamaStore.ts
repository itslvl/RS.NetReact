import { makeAutoObservable } from "mobx";


export default class AgamaStore {
    uraian = 'Hello from MobX';

    constructor() {
        makeAutoObservable(this)
    }

    setTitle = () => {
        this.uraian= this.uraian+ '!'
    }

}