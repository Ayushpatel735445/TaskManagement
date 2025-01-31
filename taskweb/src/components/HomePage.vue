<template>
    <v-container>
        <h1>Home</h1>
        <ul>
            <li v-for="employee in employees" :key="employee.id">
                {{ employee.name }}
            </li>
        </ul>
        <v-btn @click="logout">Logout</v-btn>
    </v-container>
</template>

<script>
import { mapActions } from 'vuex';

export default {
    data() {
        return {
            employees: [
                { id: 1, name: 'John Doe' },
                { id: 2, name: 'Jane Smith' },
            ],
        };
    },
    methods: {
    ...mapActions('auth', ['logout']),
    logout() {
      this.logout();
      this.$router.push('/');
    },
  },
};
</script>