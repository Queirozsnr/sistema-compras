// src/main.js ou src/main.ts

import { createApp } from 'vue';
import App from './App.vue';
import router from './router';
import './styles/global-styles.scss'; // Importe seu arquivo de estilos global
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import 'bootstrap-icons/font/bootstrap-icons.css';

createApp(App).use(router).mount('#app');
