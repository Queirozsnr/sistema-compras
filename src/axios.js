import axios from 'axios';

const axiosInstance = axios.create({
  baseURL: 'http://localhost:32769/',
});

export default axiosInstance;
