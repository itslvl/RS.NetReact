import React from 'react';
import ReactDOM from 'react-dom/client';
import 'semantic-ui-css/semantic.min.css'
import './app/layout/styles.css';
import 'react-calendar/dist/Calendar.css';
import 'react-toastify/dist/ReactToastify.min.css';
import 'react-datepicker/dist/react-datepicker.css'
import App from './app/layout/App';
import reportWebVitals from './reportWebVitals';
import { StoreContext, Store } from './app/stores/Store';
import { RouterProvider } from 'react-router-dom';
import { Router } from './app/router/Routes';

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
  <StoreContext.Provider value={Store}>
    <RouterProvider router={Router} />
    {/* <App /> */}
  </StoreContext.Provider>,
  //  <App />
);

// ReactDOM.render(
//   <StoreContext.Provider value={Store}>
//     <App />
//   </StoreContext.Provider>,
//   document.getElementById('root')
// );

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
