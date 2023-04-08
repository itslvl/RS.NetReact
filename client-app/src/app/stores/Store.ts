import {createContext, useContext} from 'react'
import OrgTypeStore from "./OrgTypeStore";
import CommonStore from './CommonStore';


interface Store {
    orgTypeStore: OrgTypeStore;
    commonStore : CommonStore;
}

export const Store: Store = {
    orgTypeStore: new OrgTypeStore(),
    commonStore : new CommonStore()
}

export const StoreContext = createContext(Store);

export function useStore() {
    return useContext(StoreContext);
}