<template>
    <tr>
      <td>{{ product.name }}</td>
      <td>
        <ul>
          <li v-for="supplier in product.suppliers" :key="supplier.id">{{ supplier.name }}</li>
        </ul>
      </td>
      <td>
        <ul>
          <li v-for="supplier in product.suppliers" :key="supplier.id">{{ supplier.value }}</li>
        </ul>
      </td>
      <td>
        <button class="btn btn-primary" @click="showPopup(product)">Analisar</button>
      </td>
    </tr>
  </template>
  
  <script>
  export default {
    name: 'ProductRow',
    props: {
      product: Object,
    },
    methods: {
      showPopup(product) {
        this.$emit('show-popup', product);
      },
    },
  };
  </script>
  