import axios, { AxiosResponse } from 'axios'
import { OrgType } from '../models/OrgType';
import { error } from 'console';

const sleep = (delay: number) => {
    return new Promise((resolve) => {
        setTimeout(resolve, delay)
    })
}

axios.defaults.baseURL = 'http://localhost:5006';

axios.interceptors.response.use(async response => {
    try {
        await sleep(1000);
        return response;
    } catch (error) {
        console.log(error);
        return await Promise.reject(error);
    }
})

const respondBody = <T,>(response: AxiosResponse<T>) => response.data;
const request = {
    get: <T,>(url: string) => axios.get<T>(url).then(respondBody),
    post: <T,>(url: string, body: {}) => axios.post<T>(url, body).then(respondBody),
    put: <T,>(url: string, body: {}) => axios.put<T>(url, body).then(respondBody),
    delete: <T,>(url: string) => axios.delete<T>(url).then(respondBody)
}
const OrgTypes = {
    list: () => request.get<OrgType[]>('/orgtype'),
    details: (id: string ) => request.get<OrgType>(`/orgtype/${id}`),
    create: (orgType: OrgType) => request.post<void>('/orgtype', orgType ),
    update: (orgType: OrgType) => request.put<void>(`/orgtype/${orgType.id}`, orgType),
    delete: (id: string) => request.delete<void>(`/orgtype/${id}`)

}
const agent = {
    OrgTypes
}

export default agent