<template>
    <v-container class="d-flex align-center justify-center" style="min-height: 100vh;">
      <v-row class="ma-0" justify="center">
        <v-col cols="12" sm="6" md="4">
            <v-card class="pa-4" outlined>
          <v-form>
            <v-text-field v-model="model.email" label="Email" type="email" required />
            <v-text-field v-model="model.password" label="Password" type="password" required />
            <v-btn color="primary" @click="submitForm" block>Login</v-btn>
            
            <!-- Forgot Password and Sign Up options -->
            <v-row class="mt-4" justify="space-between">
              <v-col cols="6">
                <v-btn text>Forgot Password?</v-btn>
              </v-col>
              <v-col cols="6" class="text-right">
                <v-btn text>Sign Up</v-btn>
              </v-col>
            </v-row>
          </v-form>
          </v-card>
        </v-col>
      </v-row>
    </v-container>
  </template>
  
  <script>
  import { mapActions } from 'vuex';
  
  export default {
    data() {
      return {
        model: {
          Email: '',
          Password: '',
        },
      };
     
    },
    methods: {
      ...mapActions('auth', ['login']), // Map the login action from the auth module
      async submitForm() {
        try {
            console.log(this.model);
          await this.login(this.model);
          this.$router.push('/home'); // Navigate to the home page after login
        } catch (error) {
          alert('Login failed: ' + error.message);
        }
      },
    },
  };
  </script>
  