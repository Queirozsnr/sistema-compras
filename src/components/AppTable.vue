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
            <div class="input-group row">
              <input
                class="border-0 col-10"
                type="text"
                :value="formatCurrency(item.fornecedor1)"
                @blur="updateFornecedor(index, 'fornecedor1', $event.target.value)"
                @focus="unformatCurrency(index, 'fornecedor1')"
                :readonly="readonly"
              />
              <i v-if="!readonly" class="bi bi-check2-circle col-2" role="button" @click="selectFornecedor(index, 'fornecedor1')"></i>
            </div>
          </td>
          <td>
            <div class="input-group">
              <input
                class="border-0 col-10"
                type="text"
                :value="formatCurrency(item.fornecedor2)"
                @blur="updateFornecedor(index, 'fornecedor2', $event.target.value)"
                @focus="unformatCurrency(index, 'fornecedor2')"
                :readonly="readonly"
              />
              <i v-if="!readonly" class="bi bi-check2-circle col-2" role="button" @click="selectFornecedor(index, 'fornecedor2')"></i>
            </div>
          </td>
          <td>
            <div class="input-group">
              <input
                class="border-0 col-10"
                type="text"
                :value="formatCurrency(item.fornecedor3)"
                @blur="updateFornecedor(index, 'fornecedor3', $event.target.value)"
                @focus="unformatCurrency(index, 'fornecedor3')"
                :readonly="readonly"
              />
              <i v-if="!readonly" class="bi bi-check2-circle col-2" role="button" @click="selectFornecedor(index, 'fornecedor3')"></i>
            </div>
          </td>
          <td>
            <div class="input-group">
              <input
                class="border-0 col-10"
                type="text"
                :value="formatCurrency(item.fornecedor4)"
                @blur="updateFornecedor(index, 'fornecedor4', $event.target.value)"
                @focus="unformatCurrency(index, 'fornecedor4')"
                :readonly="readonly"
              />
              <i v-if="!readonly" class="bi bi-check2-circle col-2" role="button" @click="selectFornecedor(index, 'fornecedor4')"></i>
            </div>
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
  data() {
    return {
      selectedFornecedores: [],
    };
  },
  methods: {
    updateFornecedor(index, fornecedor, value) {
      if (!this.readonly) {
        const numericValue = this.unformatCurrencyValue(value);
        this.$emit('update-fornecedor', index, fornecedor, numericValue);
      }
    },
    selectFornecedor(index, fornecedor) {
      const existingSelection = this.selectedFornecedores.find(sel => sel.index === index);
      
      if (existingSelection) {
        existingSelection.fornecedor = fornecedor;
      } else {
        const newSelection = {
          index,
          fornecedor
        };
        this.selectedFornecedores.push(newSelection);
      }
      
      this.$emit('fornecedores-selecionados', this.selectedFornecedores);
    },
    formatCurrency(value) {
      if (value === null || value === undefined || value === '') return '';
      if (typeof value === 'string' && value.includes('R$')) return value;
      const numericValue = parseFloat(value);
      if (isNaN(numericValue)) return '';
      return numericValue.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
    },
    unformatCurrency(index, fornecedor) {
      if (!this.readonly) {
        const item = this.data[index];
        item[fornecedor] = this.unformatCurrencyValue(item[fornecedor]);
      }
    },
    unformatCurrencyValue(value) {
      if (value === null || value === undefined || value === '') return null;
      const numericValue = parseFloat(String(value).replace(/[^0-9,-]+/g, "").replace(',', '.'));
      return isNaN(numericValue) ? null : numericValue;
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

.input-group {
  display: flex;
  align-items: center;
}

input {
  flex: 1;
  border: 1px solid #ccc;
  padding: 5px;
}

.btn {
  margin-left: 5px;
}
</style>
