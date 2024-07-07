<template>
  <div id="app">
    <TopBar />
    <div class="d-flex">
      <SideMenu />
      <div class="container mt-5">
        <router-view></router-view>
      </div>
    </div>
  </div>
</template>

<script>
import TopBar from './components/TopBar.vue';
import SideMenu from './components/SideMenu.vue';

export default {
  name: 'App',
  components: {
    TopBar,
    SideMenu,
  },
};
</script>
