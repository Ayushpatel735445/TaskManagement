<template>
    <v-container>
      <h1>Employee List</h1>
      <ul>
        <li v-for="employee in employees" :key="employee.id">
          {{ employee.name }}
        </li>
      </ul>
    </v-container>
  </template>
  
  <script>
  export default {
    data() {
      return {
        employees: [
          { id: 1, name: 'John Doe' },
          { id: 2, name: 'Jane Smith' },
        ],
      };
    },
  };
  </script>
  