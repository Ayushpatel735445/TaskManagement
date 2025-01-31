import Vue from 'vue';
import App from './App.vue';
import router from './router';
import Vuetify from 'vuetify';
import store from './store';
import 'vuetify/dist/vuetify.min.css'; 

Vue.use(Vuetify);

new Vue({
  render: (h) => h(App),
   store,
   router, // Add router here
  vuetify: new Vuetify(),
}).$mount('#app');