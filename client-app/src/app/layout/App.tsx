import { Container } from 'semantic-ui-react';
import NavBar from './NavBar';
import { observer } from 'mobx-react-lite';
import { Outlet, useLocation } from 'react-router-dom';
import HomePage from '../../features/home/HomePage';
import { ToastContainer } from 'react-toastify';
import { useStore } from '../stores/Store';
import { useEffect } from 'react';
import LoadingComponent from './loadingComponent';
import ModalContainer from '../common/modals/ModalContainer';

function App() {

  const location = useLocation();
  const { commonStore, userStore } = useStore();

  useEffect(() => {
    if (commonStore.token) {
      userStore.getUser().finally(() => commonStore.setAppLoaded());
    } else {
      commonStore.setAppLoaded();
    }
  }, [commonStore, useStore])


  if (!commonStore.appLoaded) return <LoadingComponent content='Loading app ...' />

  return (
    <>
      <ModalContainer />
      <ToastContainer position='bottom-right' hideProgressBar theme='colored' />
      {location.pathname === '/' ? <HomePage /> : (
        <> <NavBar />
          <Container style={{ marginTop: '5em' }}>
            <Outlet />
          </Container>
        </>
      )}
    </>
  );
}

export default observer(App);
