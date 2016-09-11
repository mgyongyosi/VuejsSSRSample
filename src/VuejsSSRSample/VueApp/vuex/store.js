import Vue from 'vue'
import Vuex from 'vuex'
import { fetchMessages } from './actions'
import minBy from 'lodash/minBy';

Vue.use(Vuex)

const store = new Vuex.Store({
    state: { messages: [], lastFetchedMessageDate: -1 },

    mutations: {
        FETCH_MESSAGES: (state, payload) => {
            state.messages = state.messages.concat(payload);
            state.lastFetchedMessageDate = minBy(state.messages, 'date').date;
        }
    },

    actions: {
        fetchMessages
    },

    getters: {
        messages: state => state.messages,
        lastFetchedMessageDate: state => state.lastFetchedMessageDate
    }
});

export default store;