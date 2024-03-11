<template>
  <div>
    <div>Hello</div>
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
  });


</script>



<style scoped>

</style>
