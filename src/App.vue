<template>
  <div id="app">
    <TopBar v-if="!$route.meta.hideTopBar" />
    <div :class="getFlexClass">
      <SideMenu v-if="!$route.meta.hideSideMenu" />
      <div :class="getPageContainerClass">
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
  computed: {
    getFlexClass() {
      return {
        'd-flex': !this.$route.meta.isLoginPage,
      };
    },
    getPageContainerClass() {
      return {
        'container': !this.$route.meta.isLoginPage,
        'mt-5': !this.$route.meta.isLoginPage,
      };
    }
  }
};
</script>
