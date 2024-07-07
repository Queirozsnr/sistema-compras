<template>
  <div>
    <h2>Tabela de Análise</h2>
    <AppTable
      :data="editableData"
      :loading="loading"
      :readonly="readonly"
      @update-fornecedor="updateFornecedor"
    />
  </div>
</template>

<script>
import AppTable from './AppTable.vue';
import productsService from '../services/products';

export default {
  name: 'AnalysisTable',
  components: {
    AppTable,
  },
  data() {
    return {
      data: [],
      editableData: [],
      filteredData: [],
      loading: true,
      readonly: false,
    };
  },
  created() {
    productsService.getData().then(data => {
      this.data = data;
      this.editableData = JSON.parse(JSON.stringify(data));
      this.loading = false;
    });
  },
  methods: {
    updateFornecedor(index, fornecedor, value) {
      this.editableData[index][fornecedor] = value;
      productsService.updateData(this.editableData[index])
        .then(() => {
          console.log('Dados atualizados com sucesso!');
        })
        .catch(error => {
          console.error('Erro ao atualizar os dados:', error);
        });
    },
  }
};
</script>
