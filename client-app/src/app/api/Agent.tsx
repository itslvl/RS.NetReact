import axios, { AxiosResponse } from 'axios'
import { OrgType } from '../models/OrgType';
import { AxiosError } from 'axios';
import { toast } from 'react-toastify';
import { Router } from '../router/Routes';
import { Store } from '../stores/Store';
import { User, UserFormValues } from '../models/User';
// import { error } from 'console';

const sleep = (delay: number) => {
    return new Promise((resolve) => {
        setTimeout(resolve, delay)
    })
}

axios.defaults.baseURL = 'http://localhost:5006';

axios.interceptors.response.use(async response => {
    // try {
    await sleep(1000);
    return response;
    // } catch (error) {
    //     console.log(error);
    //     return await Promise.reject(error);
    // }
}, (error: AxiosError) => {
    const { data, status, config } = error.response as AxiosResponse;
    switch (status) {
        case 400:
            if (config.method ==='get' && data.errors.hasOwnProperty('id')) {
                Router.navigate('/not-found')
            }
            if (data.errors) {
                const modalStateErrors = [];
                for (const key in data.errors) {
                    if (data.errors[key]) {
                        modalStateErrors.push(data.errors[key])
                    }
                }
                throw modalStateErrors.flat();
            } else {
                toast.error(data);
            }
            break;
        case 401:
            toast.error('unauthorized')
            break;
        case 403:
            toast.error('forbidden')
            break;
        case 404:
            // toast.error('not found')
            Router.navigate('/not-found');
            break;
        case 500:
            // toast.error('server error')
            console.log(error);
            Store.commonStore.setServerError(error);
            Router.navigate('/server-error');
            break;
        // default:
        //     break;
    }
    return Promise.reject(error);
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
    details: (id: string) => request.get<OrgType>(`/orgtype/${id}`),
    create: (orgType: OrgType) => request.post<void>('/orgtype', orgType),
    update: (orgType: OrgType) => request.put<void>(`/orgtype/${orgType.id}`, orgType),
    delete: (id: string) => request.delete<void>(`/orgtype/${id}`)

}
const Account = {
    current: () => request.get<User>('/Account'),
    login: (user: UserFormValues) => request.post<User>('/Account/Login', user),
    register: (user: UserFormValues) => request.post<User>('/Account/register', user)
}
const agent = {
    OrgTypes,
    Account
}

export default agent