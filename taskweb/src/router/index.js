import Vue from 'vue';
import VueRouter from 'vue-router';
import store from '@/store'; 
//import LoginForm from '@/components/LoginForm.vue';
//import { constants } from '@/config/constants';
// import HomePage from '@/components/HomePage.vue';


Vue.use(VueRouter);

const routes = [
   
    {
        path: '/',
        component: () => import('@/components/LoginForm.vue'),
        meta: { requiresAuth: false }
    },

    {
        path: '/home',
        component: () => import('@/components/HomePage.vue'),
        meta: { requiresAuth: true }
    },
    {
        path: '/tasks',
        component: () => import('@/components/TaskList.vue'),
        meta: { requiresAuth: true },
    },
    {
        path: '/employees',
        component: () => import('@/components/EmployeeList.vue'),
        meta: { requiresAuth: true, adminOnly: true },
    },
];

const router = new VueRouter({
    mode: 'history',
    routes,
});

// Navigation Guards for Role-Based Access
router.beforeEach((to, from, next) => {
    const isAuthenticated = store.getters['auth/isAuthenticated']; 
    const isTokenExpired = store.getters['auth/isTokenExpired']; 
    const role = store.getters['auth/role'];              
     console.log(isAuthenticated  + "1");
     console.log(isTokenExpired + "2");
     console.log(role + "  3");
     console.log(to.meta.requiresAuth + " 4");
     console.log(to.path + " 5");
     if (!to.meta.requiresAuth && (!isAuthenticated || isTokenExpired)) {
        console.log("5");
        return next();
    }

    // if (to.path === '/' && isAuthenticated && !isTokenExpired) {
    //     if (role === '1') {
    //         return next('/home');
    //     } else if (role === '2') {
    //         return next('/employees');
    //     }
    // }

    next();
});

export default router;
