import {createContext, useContext} from 'react'
import OrgTypeStore from "./OrgTypeStore";
import CommonStore from './CommonStore';
import UserStore from './UserStore';
    

interface Store {
    orgTypeStore: OrgTypeStore;
    commonStore : CommonStore;
    userStore : UserStore;
    
}

export const Store: Store = {
    orgTypeStore: new OrgTypeStore(),
    commonStore : new CommonStore(),
    userStore : new UserStore()
}

export const StoreContext = createContext(Store);

export function useStore() {
    return useContext(StoreContext);
}