<template>
  <div>
    <b-container>
      <h1>Vue App bundled with Parcels {{message}}</h1>
      <b-alert show>Welcome Alert</b-alert>
    </b-container>
  </div>
</template>

<script>
export default {
  name: "App",
  data() {
    return {
      message: "testing data"
    };
  },
  created() {
    fetch("https://localhost:5001/api/games/");
    console.log("created");
  }
};
</script>

<style>
</style>