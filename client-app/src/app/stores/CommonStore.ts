import { makeAutoObservable } from "mobx";
import { ServerError } from "../models/ServerError";
import { AxiosError } from "axios";

export default class CommonStore {
    error: ServerError | null = null;

    constructor() { makeAutoObservable (this) }

    // setServerError (error: ServerError) {
    //     this.error = error;
    // }


    setServerError (error: AxiosError) {
        const serverError : ServerError = {
            code: error.code ?? 'ERR_UnKnown', 
            message: error.message,
            response: error.response?.data
        }
        this.error = serverError;
    }

}