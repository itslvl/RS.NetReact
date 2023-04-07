import {createContext, useContext} from 'react'
import OrgTypeStore from "./OrgTypeStore";


interface Store {
    orgTypeStore: OrgTypeStore
}

export const Store: Store = {
    orgTypeStore: new OrgTypeStore()
}

export const StoreContext = createContext(Store);

export function useStore() {
    return useContext(StoreContext);
}