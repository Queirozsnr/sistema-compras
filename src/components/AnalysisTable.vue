<template>
  <div>
    <h2>Tabela de Análise</h2>
    <AppTable :data="data" :loading="loading" />
  </div>
</template>

<script>
import AppTable from './AppTable.vue';
import productsService from '../services/products';

export default {
  name: 'MainComponent',
  components: {
    AppTable
  },
  data() {
    return {
      data: [],
      loading: true
    };
  },
  created() {
    productsService.getData().then(data => {
      this.data = data;
      this.loading = false;
    });
  }
};
</script>
