import axios from 'axios';
import { constants } from '@/config/constants';
 

const state = {
  token: localStorage.getItem('token') || null,
  tokenExpired: constants.IsSessionExpired(),
  roleId: constants.getRoleFromToken(),
};

const getters = {
  isAuthenticated: (state) => !!state.token,
  isTokenExpired: (state) => !!state.tokenExpired,
  role: (state) => state.roleId,
};

const actions = {
  async login({ commit }, credentials) {
    try {
      const response = await axios.post(`${constants.baseApi}Account/login`, credentials);
      var token = response.data;
      commit('setAuthData', { token });
    } catch (error) {
      throw new Error(error); 
    }
  },
  logout({ commit }) {
    commit('clearAuthData');
  },
};

const mutations = {
  setAuthData(state, { token}) {
    state.token = token;
    localStorage.setItem('token', token);
  },
  clearAuthData(state) {
    state.token = null;
    localStorage.removeItem('token');
  },
};

export default {
  namespaced: true,
  state,
  getters,
  actions,
  mutations,
};
