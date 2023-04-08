import { Navigate, RouteObject, createBrowserRouter } from "react-router-dom";
import App from "../layout/App";
import HomePage from "../../features/home/HomePage";
import OrgTypeDashboard from "../../features/orgtype/dashboard/OrgTypeDashboard";
import OrgTypeForm from "../../features/orgtype/form/OrgTypeForm";
import OrgTypeDetails from "../../features/orgtype/details/OrgTypeDetails";
import TestErrors from "../../features/errors/TestErrors";
import NotFound from "../../features/errors/NotFound";
import ServerError from "../../features/errors/ServerError";
import LoginForm from "../../features/users/LoginForm";
import Stay from "../../features/home/Stay";

export const Routes : RouteObject[] = [
    {
        path :   '/', 
        element : <App />,
        children: [
            {path:'stay', element: <Stay/>},
            {path:'orgType', element: <OrgTypeDashboard/>},
            {path:'orgType/:id', element: <OrgTypeDetails   />},
            {path:'createOrgType', element: <OrgTypeForm key='create'/>},
            {path:'manage/:id', element: <OrgTypeForm key='manage'/>},
            {path:'login', element: <LoginForm/>},
            {path:'errors', element: <TestErrors />},
            {path:'not-found', element: <NotFound />},
            {path:'server-error', element: <ServerError />},
            {path:'*', element: <Navigate replace to='/not-found' />},
        ]
    }
]

export const Router = createBrowserRouter(Routes)