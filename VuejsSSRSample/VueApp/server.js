import { app, store } from './app'

// push context related data (in our case the initial state of the application) with the context attribute
export default function(context) {
    return new Promise((resolve, reject) => {
        store.replaceState(context);
        resolve(app);
    });
};
