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
      selectedFornecedores: [], // Inicializa o array para armazenar fornecedores selecionados
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

    // Verifica se o índice está dentro dos limites do array de dados
    if (itemIndex >= 0 && itemIndex < this.data.length) {
      const item = { ...this.data[itemIndex] };

      // Verifica se a chave do fornecedor existe no item
      if (item && fornecedorKey in item) {
        item.selecionado = item[fornecedorKey]; // Adiciona o campo selecionado com o valor do fornecedor
        return item;
      } else {
        console.warn(`Item não encontrado para o índice ${itemIndex} ou fornecedor ${fornecedorKey} não existe.`);
        return null; // Retorna null se o item não for encontrado
      }
    } else {
      console.warn(`Índice ${itemIndex} está fora do intervalo.`);
      return null; // Retorna null se o índice estiver fora do intervalo
    }
  }).filter(item => item !== null); // Filtra itens nulos, se houver

  // Emitir o evento 'fornecedores-selecionados' para o componente pai (AnalysisView)
  this.$emit('fornecedores-selecionados', this.selectedFornecedores);
},

  },
};
</script>
