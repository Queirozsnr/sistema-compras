<template>
  <div>
    <h2>Tabela de Análise</h2>
    <div class="table-responsive">
      <table class="table table-bordered text-center">
        <thead class="h-3">
          <tr>
            <th class="min-w-8">Código</th>
            <th class="min-w-8">Produto</th>
            <th class="min-w-8">Descrição</th>
            <th class="min-w-8">Quantidade</th>
            <th class="min-w-8">Fornecedor 1</th>
            <th class="min-w-8">Fornecedor 2</th>
            <th class="min-w-8">Fornecedor 3</th>
            <th class="min-w-8">Fornecedor 4</th>
          </tr>
        </thead>
        <tbody>
          <tr v-if="loading">
            <td colspan="8">Carregando...</td>
          </tr>
          <tr v-else v-for="(item, index) in data" :key="index">
            <td>{{ item.codigo }}</td>
            <td>{{ item.produto }}</td>
            <td>{{ item.descricao }}</td>
            <td>{{ item.quantidade }}</td>
            <td>{{ item.fornecedor1 }}</td>
            <td>{{ item.fornecedor2 }}</td>
            <td>{{ item.fornecedor3 }}</td>
            <td>{{ item.fornecedor4 }}</td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script>
import productsService from '../services/products';

export default {
  name: 'AnalysisTable',
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

<style scoped>
.table thead th {
  color: #FFFFFF;
  background-color: #606062;
  border-bottom: 1px solid #606062;
  border: none;
  vertical-align: middle;
}

.table tbody td {
  border: none;
  vertical-align: middle;
}

.table th:first-child {
  border-top-left-radius: 6px;
  border-bottom-left-radius: 6px;
}

.table th:last-child {
  border-top-right-radius: 6px;
  border-bottom-right-radius: 6px;
}

.min-w-8 {
  min-width: 8rem;
}

.h-3 {
  height: 3rem;
}
</style>
