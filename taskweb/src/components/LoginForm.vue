<template>
  <v-container class="d-flex align-center justify-center" style="min-height: 100vh;">
    <v-row class="ma-0" justify="center">
      <v-col cols="12" sm="6" md="4">
        <v-card class="pa-4" outlined>
          <v-form @submit.prevent="submitForm">
            <v-text-field v-model="model.Email" label="Email" type="email" required />
            <v-text-field v-model="model.Password" label="Password" type="password" required />
            <v-btn color="primary" type="submit" block>Login</v-btn>

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
import { constants } from '@/config/constants';

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
    ...mapActions('auth', ['login']),
    async submitForm() {
      try {
        await this.login(this.model);
        var role = constants.getRoleFromToken();
        
       
        if (role === '1') {
          this.$router.push('/home');
        } else if (role === '2') {
          this.$router.push('/employees');
        }
        
      } catch (error) {
        alert('Login failed: ' + ('Email or password is incorrect!'));
      }
    },
  },
};
</script>
