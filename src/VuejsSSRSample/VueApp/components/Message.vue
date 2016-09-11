<template>
  <div>
    <h2>{{ message.title }}</h2>
    <p>{{ message.text }}</p>
  </div>
</template>

<script>
  export default {
	props: ['message']
  }
</script>