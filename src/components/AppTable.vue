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
            <input
              class="border-0"
              type="number"
              v-model="item.fornecedor1"
              @blur="handleBlur(index, 'fornecedor1', item.fornecedor1)"
              :readonly="readonly"
            />
          </td>
          <td>
            <input
              class="border-0"
              type="number"
              v-model="item.fornecedor2"
              @blur="handleBlur(index, 'fornecedor2', item.fornecedor2)"
              :readonly="readonly"
            />
          </td>
          <td>
            <input
              class="border-0"
              type="number"
              v-model="item.fornecedor3"
              @blur="handleBlur(index, 'fornecedor3', item.fornecedor3)"
              :readonly="readonly"
            />
          </td>
          <td>
            <input
              class="border-0"
              type="number"
              v-model="item.fornecedor4"
              @blur="handleBlur(index, 'fornecedor4', item.fornecedor4)"
              :readonly="readonly"
            />
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
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
    },
    readonly: {
      type: Boolean,
      default: false
    }
  },
  methods: {
    handleBlur(index, fornecedor, value) {
      if (!this.readonly) {
        this.$emit('update-fornecedor', index, fornecedor, value);
      }
    }
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
