<template>
  <v-app>
    
    <v-main>
      <LoginForm />
    </v-main>
  </v-app>
</template>

<script>

import LoginForm from './components/LoginForm';


export default {
  name: 'App',

  components: {

    LoginForm
  },

  data: () => ({
    //
  }),
};
</script>
