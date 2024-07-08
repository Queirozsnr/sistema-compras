<template>
  <div>
    <AppTable :data="editableData" :loading="loading" :readonly="readonly" @update-fornecedor="updateFornecedor"
      @fornecedores-selecionados="handleFornecedoresSelecionados" />
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
  // Atualiza o valor no editableData imediatamente
  this.editableData[index][fornecedor] = value;

  // Atualiza o valor no data original para refletir as mudanças
  this.data[index][fornecedor] = value;

  // Chama o serviço para atualizar os dados no backend
  productsService.updateData(this.editableData[index])
    .then(() => {
      // Emite evento com os novos dados
      this.$emit('update-fornecedor', index, fornecedor, value);
    })
    .catch(error => {
      console.error('Erro ao atualizar os dados:', error);
      // Reverte para o valor anterior se houver um erro
      this.editableData[index][fornecedor] = this.data[index][fornecedor];
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
