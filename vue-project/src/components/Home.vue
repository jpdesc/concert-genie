<template>
  <div>
    <div></div>
  </div>
</template>


<script setup>
  import { ref, onMounted } from 'vue';
  import axios from 'axios';

  const topArtists = ref([]);

  onMounted(async () => {
    const response = await axios.get(
      '/api/spotify/top-artists'
    );
    topArtists.value = response.data;
    console.log()
  });


</script>



<style scoped>


</style>
