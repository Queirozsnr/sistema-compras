<template>
  <div class="container-fluid">
    <div class="row">
      <div class="col-md-6 bg-image">
      </div>
      <div class="col-md-6 d-flex align-items-center">
        <div class="container">
          <div class="row justify-content-center">
            <div class="col-lg-8 col-md-10 col-sm-12 d-inline-grid justify-content-center">
              <img src="../../public/kodigos.png" alt="Logo" class="img-fluid mb-4">
              <form @submit.prevent="login">
                <div class="mb-3">
                  <div class="input-group">
                    <input type="text" id="username" placeholder="Login" v-model="username"
                      class="form-control border-right-0">
                    <span class="input-group-text bg-white"><i class="bi bi-person-circle"></i></span>
                  </div>
                </div>

                <div class="mb-3">
                  <div class="input-group">
                    <input type="password" id="password" placeholder="Senha" v-model="password"
                      class="form-control border-right-0">
                    <span class="input-group-text bg-white"><i class="bi bi-lock-fill"></i></span>
                  </div>
                </div>
                <div class="d-grid gap-2">
                  <AppButton color="primary" @click="login()">Acessar</AppButton>
                </div>
              </form>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import AppButton from '../components/AppButton.vue'
export default {
  name: 'LoginView',
  components: {
    AppButton,
  },
  data() {
    return {
      username: '',
      password: ''
    };
  },
  methods: {
    login() {
      this.$router.push('/dashboard');
    }
  }
};
</script>

<style scoped>
.bg-image {
  background-image: url('../../public/fundo-login2.png');
  background-size: cover;
  background-position: center;
  height: 100vh;
}

.border-right-0 {
  border-right: none;
}

@media (max-width: 768px) {
  .bg-image {
    height: 50vh;
  }
}
</style>
