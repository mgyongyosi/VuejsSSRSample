<template>
  <div>
    <h1>Messages</h1>
    <Message v-for="msg in messages" :message="msg" />
    <button @click="fetchMessages(lastFetchedMessageDate)">Fetch a message</button>
  </div>
</template>

<script>
  import { mapGetters, mapActions } from 'vuex'
  import Message from './Message.vue'

  export default {
  components: { Message },
  computed: mapGetters(['messages', 'lastFetchedMessageDate']),
  methods: mapActions(['fetchMessages'])
  }
</script>