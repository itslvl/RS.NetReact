import { RouteObject, createBrowserRouter } from "react-router-dom";
import App from "../layout/App";
import HomePage from "../../features/home/HomePage";
import OrgTypeDashboard from "../../features/orgtype/dashboard/OrgTypeDashboard";
import OrgTypeForm from "../../features/orgtype/form/OrgTypeForm";
import OrgTypeDetails from "../../features/orgtype/details/OrgTypeDetails";

export const Routes : RouteObject[] = [
    {
        path :   '/', 
        element : <App />,
        children: [
            {path:'orgType', element: <OrgTypeDashboard/>},
            {path:'orgType/:id', element: <OrgTypeDetails   />},
            {path:'createOrgType', element: <OrgTypeForm key='create'/>},
            {path:'manage/:id', element: <OrgTypeForm key='manage'/>},
            {path:'', element: <HomePage/>}
        ]
    }
]

export const Router = createBrowserRouter(Routes)