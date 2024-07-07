import { createRouter, createWebHistory } from 'vue-router';
import AnalysisView from '../views/AnalysisView.vue';

const routes = [
  {
    path: '/',
    name: 'Dashboard',
    component: AnalysisView,
  },
  {
    path: '/compras',
    name: 'Compras',
    component: AnalysisView, // Substitua com o componente correto para esta rota
  },
  {
    path: '/relatorios',
    name: 'Relatórios',
    component: AnalysisView, // Substitua com o componente correto para esta rota
  },
  {
    path: '/configuracoes',
    name: 'Configurações',
    component: AnalysisView, // Substitua com o componente correto para esta rota
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
