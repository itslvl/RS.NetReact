import { makeAutoObservable, runInAction } from "mobx";
import { AgamaAPI } from "../models/AgamaAPI";
import agent from "../api/Agent";
import { v4 as uuid } from 'uuid'


export default class AgamaStore {
    agamas: AgamaAPI[] = []
    selectedAgama: AgamaAPI | undefined = undefined
    editMode = false
    loading = false
    loadingInitial = false
    submitting = false

    // const [agamas, setAgamas] = useState<AgamaAPI[]>([]);
    // const [selectedAgama, setSelectedAgama] = useState<AgamaAPI | undefined>(undefined);
    // const [editMode, setEditMode] = useState(false);
    // const [loading, setLoading] = useState(true);
    // const [submitting, setSubmitting] = useState(false);

    constructor() {
        makeAutoObservable(this)
    }

    loadAgamas = async () => {
        this.setLoadingInitial(true)
        try {
            const agamas = await agent.Agama.list()
            // runInAction(() => {
            agamas.forEach(agama => {
                // agama.timeStamp = agama.timeStamp.split('T')[0];
                this.agamas.push(agama)
            })
            this.setLoadingInitial(false)
            // })
        } catch (error) {
            console.log(error)
            // runInAction(() => {
            this.setLoadingInitial(false)
            // })
        }
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state
    }

    selectAgama = (id: string) => {
        this.selectedAgama = this.agamas.find(c => c.id === id)
    }

    cancelAgama = () => {
        this.selectedAgama = undefined
    }

    openForm = (id?: string) => {
        id ? this.selectAgama(id) : this.cancelAgama()
        this.editMode = true
    }

    closeForm = () => {
        this.editMode = false
    }

    createAgama = async (agama: AgamaAPI) => {
        this.loading = true
        agama.id = uuid()
        agama.timeStamp = new Date().toISOString()
        try {
            await agent.Agama.create(agama)
            runInAction(() => {
                this.agamas.push(agama)
                this.cancelAgama()
                this.editMode = false
                this.loading = false
            })
        } catch (error) {
            console.log(error)
            runInAction(() => {
                this.editMode = false
                // this.loading = false
            })
        }
    }

    updateAgama = async (agama: AgamaAPI) => {
        this.loading = true
        // agama.id = uuid()
        try {
            await agent.Agama.update(agama)
            runInAction(() => {
                this.agamas = [...this.agamas.filter(c => c.id !== agama.id), agama]
                this.selectedAgama = agama
                this.editMode = false
                this.loading = false
            })
        } catch (error) {
            console.log(error)
            runInAction(() => {
                // this.editMode = false
                this.loading = false
            })
        }
    }

    deleteAgama = async (id: string, timeStamp: string) => {
        this.loading = true
        try {
            await agent.Agama.delete(id, timeStamp)
            runInAction(() => {
                this.agamas = [...this.agamas.filter(c => c.id !== id)]
                // if (this.selectedAgama?.id === id) this.cancelAgama;
                this.loading = false
            })
        } catch (error) {
            console.log(error)
            runInAction(() => {
                this.loading = false
            })
        }
    }

}