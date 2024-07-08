<template>
  <nav class="navbar navbar-expand-lg navbar-light bg-light">
    <div class="container-fluid">
      <a class="navbar-brand" href="#">
        <img src="kodigos.png" alt="Logo" class="d-inline-block align-text-top custom-image">
      </a>
      <div class="d-flex align-items-center ms-auto">
        <i class="bi bi-bell-fill" style="font-size: 1.5rem; margin-right: 1rem;"></i>
        <span class="me-3">Administrador</span>
        <i class="bi bi-box-arrow-right" style="font-size: 1.5rem;"></i>
      </div>
    </div>
  </nav>
</template>

<script>
export default {
  name: 'TopBar',
};
</script>

<style scoped>
.custom-image {
  width: 6rem;
}
</style>