<template>
    <div class="d-flex flex-column align-items-center side-menu">
      <router-link
        v-for="menu in menus"
        :key="menu.name"
        :to="menu.route"
        class="menu-item"
        :title="menu.name"
      >
        <i :class="menu.icon"></i>
      </router-link>
    </div>
  </template>
  
  <script>
  export default {
    name: 'SideMenu',
    data() {
      return {
        menus: [
          { name: 'Home', icon: 'bi bi-house-door-fill', route: '/' },
          { name: 'Criar Produto', icon: 'bi bi-file-earmark-plus-fill', route: '/compras' },
          { name: 'Relatórios', icon: 'bi bi-file-earmark-text-fill', route: '/relatorios' },
          { name: 'Validar Produto', icon: 'bi bi-clipboard2-check-fill', route: '/validar-produto' },
          { name: 'Relatórios', icon: 'bi bi-clipboard2-data-fill', route: '/relatorios' },
          { name: 'Configurações', icon: 'bi bi-gear', route: '/configuracoes' },
        ],
      };
    },
  };
  </script>
  
  <style>
  .side-menu {
    width: 70px;
    height: 100vh;
    background-color: #343a40;
    padding-top: 20px;
  }
  
  .menu-item {
    display: flex;
    align-items: center;
    justify-content: center;
    margin-bottom: 20px;
    color: #fff;
    font-size: 24px;
    cursor: pointer;
    text-decoration: none;
  }
  
  .menu-item:hover {
    color: #ffc107;
  }
  
  .menu-item::after {
    content: attr(title);
    position: absolute;
    left: 80px;
    background: #343a40;
    color: #fff;
    padding: 5px 10px;
    border-radius: 5px;
    opacity: 0;
    white-space: nowrap;
    transition: opacity 0.3s;
    z-index: 1000;
  }
  
  .menu-item:hover::after {
    opacity: 1;
  }
  </style>
  