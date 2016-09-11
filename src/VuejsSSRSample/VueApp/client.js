import { app, store } from './app';

store.replaceState(__INITIAL_STATE__);

app.$mount('.my-app');
