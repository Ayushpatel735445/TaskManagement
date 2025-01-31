<template>
  <v-app>
    <v-app-bar app color="primary" dark>
      <v-toolbar-title>Task Management</v-toolbar-title>
      <v-spacer></v-spacer>
      
      
    </v-app-bar>

    <v-main>
      <!-- Route outlet -->
      <router-view />
    </v-main>
  </v-app>
</template>

<script>
export default {
  name: 'App',
};
</script>

<style scoped>
/* Add any global styling here */
</style>
