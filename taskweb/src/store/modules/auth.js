import axios from 'axios';
import { constants } from '@/config/constants';
import commit from 'vuex';


const state = {
  token: null,
  role: null,
};

const getters = {
  isAuthenticated: (state) => !!state.token,
  userRole: (state) => state.role,
};

const actions = {
  async login( credentials) {
    console.log("credentials", credentials);
    try {
      const response = await axios.post(constants.baseApi + 'Account/login', credentials);
      const { token, role } = response.data;
      commit('setAuthData', { token, role });
    } catch (error) {
      throw new Error(error.response.data.message);
    }
  },
  logout({ commit }) {
    commit('clearAuthData');
  },
};

const mutations = {
  setAuthData(state, { token, role }) {
    state.token = token;
    state.role = role;
    localStorage.setItem('token', token);
    localStorage.setItem('role', role);
  },
  clearAuthData(state) {
    state.token = null;
    state.role = null;
    localStorage.removeItem('token');
    localStorage.removeItem('role');
  },
};

export default {
  namespaced: true,  // Important to enable namespacing
  state,
  getters,
  actions,
  mutations,
};
