<template>
  <div>
    <AppTable
      :data="editableData"
      :loading="loading"
      :readonly="readonly"
      @update-fornecedor="updateFornecedor"
      @fornecedores-selecionados="handleFornecedoresSelecionados"
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
      loading: true,
      readonly: false,
      selectedFornecedores: [],
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
        .then(() => {})
        .catch(error => {
          console.error('Erro ao atualizar os dados:', error);
        });
    },
    handleFornecedoresSelecionados(selectedFornecedores) {
  this.selectedFornecedores = selectedFornecedores.map(sel => {
    const itemIndex = sel.index;
    const fornecedorKey = sel.fornecedor;
    if (itemIndex >= 0 && itemIndex < this.data.length) {
      const item = { ...this.data[itemIndex] };

      if (item && fornecedorKey in item) {
        item.selecionado = item[fornecedorKey];
        return item;
      } else {
        console.warn(`Item não encontrado para o índice ${itemIndex} ou fornecedor ${fornecedorKey} não existe.`);
        return null;
      }
    } else {
      console.warn(`Índice ${itemIndex} está fora do intervalo.`);
      return null;
    }
  }).filter(item => item !== null);

  this.$emit('fornecedores-selecionados', this.selectedFornecedores);
},

  },
};
</script>
