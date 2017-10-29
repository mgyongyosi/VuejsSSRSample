import axios from 'axios'

export const fetchMessages = ({ commit }, lastFetchedMessageDate) => {
    axios.get('/home/fetchMessages?lastFetchedMessageDate='+ lastFetchedMessageDate).then( response  => {
        commit("FETCH_MESSAGES", response.data);
    }).catch( err => {
        console.log(err);
    });
}