import Vue from 'vue';
import VueRouter from 'vue-router';
import LoginForm from '@/components/LoginForm.vue';
// import HomePage from '@/components/HomePage.vue';


Vue.use(VueRouter);

const routes = [
    { path: '/', component: LoginForm },

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
    // const isAuthenticated = localStorage.getItem('token'); // Replace with Vuex state if desired
    // const userRole = localStorage.getItem('role'); // Replace with Vuex state
    const isAuthenticated = "authenticaetd"; // Replace with Vuex state if desired
    //const userRole = localStorage.getItem('role'); // Replace with Vuex state
    console.log("isAuthenticated", isAuthenticated);
    if (to.meta.requiresAuth && !isAuthenticated) {
        return next('/');
    }

    next();
});

export default router;
