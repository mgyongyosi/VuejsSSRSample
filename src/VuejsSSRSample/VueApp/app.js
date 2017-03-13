import Vue from 'vue';
import App from './components/App.vue';
import store from './vuex/store.js';

const app = new Vue({
    store, 
    ...App
});
//Comment
export { app, store };