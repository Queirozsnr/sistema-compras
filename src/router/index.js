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
    component: AnalysisView,
  },
  {
    path: '/relatorios',
    name: 'Relatórios',
    component: AnalysisView,
  },
  {
    path: '/validar-produto',
    name: 'Validar Produto',
    component: AnalysisView,
  },
  {
    path: '/configuracoes',
    name: 'Configurações',
    component: AnalysisView,
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
