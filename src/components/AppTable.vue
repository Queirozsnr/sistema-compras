<template>
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
          <td>{{ item.nome }}</td>
          <td>{{ item.descricao }}</td>
          <td>{{ item.quantidade }}</td>
          <td>
            <input class="border-0" type="number" v-model="editableData[index].fornecedor1" @blur="updateFornecedor(index, 'fornecedor1')" />
          </td>
          <td>
            <input class="border-0" type="number" v-model="editableData[index].fornecedor2" @blur="updateFornecedor(index, 'fornecedor2')" />
          </td>
          <td>
            <input class="border-0" type="number" v-model="editableData[index].fornecedor3" @blur="updateFornecedor(index, 'fornecedor3')" />
          </td>
          <td>
            <input class="border-0" type="number" v-model="editableData[index].fornecedor4" @blur="updateFornecedor(index, 'fornecedor4')" />
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import productsService from '../services/products';

export default {
  name: 'AppTable',
  props: {
    data: {
      type: Array,
      required: true
    },
    loading: {
      type: Boolean,
      default: false
    }
  },
  data() {
    return {
      editableData: JSON.parse(JSON.stringify(this.data))
    };
  },
  watch: {
    data: {
      handler(newData) {
        this.editableData = JSON.parse(JSON.stringify(newData));
      },
      deep: true
    }
  },
  methods: {
    updateFornecedor(index) {
      const updatedItem = this.editableData[index];
      productsService.updateData(updatedItem)
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

input {
  width: 100%;
  border: 1px solid #ccc;
  padding: 5px;
}
</style>
