<template>
    <div class="modal fade" id="supplierPopup" tabindex="-1" aria-labelledby="supplierPopupLabel" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="supplierPopupLabel">Analisar Fornecedor</h5>
            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
          </div>
          <div class="modal-body">
            <ul v-if="product">
              <li v-for="supplier in product.suppliers" :key="supplier.id">
                {{ supplier.name }} - {{ supplier.value }}
                <button class="btn btn-success ms-3" @click="selectSupplier(supplier)">Selecionar</button>
              </li>
            </ul>
            <div v-else>
              Selecione um produto para analisar os fornecedores.
            </div>
          </div>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    name: 'SupplierPopup',
    props: {
      product: Object,
    },
    methods: {
      selectSupplier(supplier) {
        this.$emit('select-supplier', supplier);
      },
    },
  };
  </script>
  