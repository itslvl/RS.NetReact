import { makeAutoObservable } from "mobx";
import { ServerError } from "../models/ServerError";
import { AxiosError } from "axios";

export default class CommonStore {
    error: ServerError | null = null;
    token: string | null = null;
    appLoaded = false;

    constructor() { makeAutoObservable(this) }

    setServerError(error: AxiosError) {
        const serverError: ServerError = {
            code: error.code ?? 'ERR_UnKnown',
            message: error.message,
            response: error.response?.data
        }
        this.error = serverError;
    }

    setToken = (token: string | null) =>{
        if (token) localStorage.setItem('jwt', token);
        this.token = token;
    }

    setAppLoaded = () => {
        this.appLoaded = true;
    }

}