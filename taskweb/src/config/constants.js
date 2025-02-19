import { jwtDecode } from "jwt-decode";

export const constants = {
  baseApi: 'https://localhost:44324/',

  getRoleFromToken() {
    const token = localStorage.getItem('token');
    if (token) {
      try {
        const decodedToken = jwtDecode(token);
        return decodedToken.role || [];
      } catch (error) {
        return [];
      }
    }
    return [];
  },

  IsSessionExpired() {
    const token = localStorage.getItem('token');
    if (token) {
      try {
        const decodedToken = jwtDecode(token);
        const currentTime = Math.floor(Date.now() / 1000); 

        // Check if the token is expired
        if (decodedToken.exp && decodedToken.exp < currentTime) {
          console.warn('Token has expired');
          return false; // Token expired
        }

        return true;
      } catch (error) {
        console.error('Invalid token:', error);
        return [];
      }
    }
    return [];
  }
};