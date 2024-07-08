<template>
  <div>
    <AppTable :data="dataSelected" :loading="loading" :readonly="readonly" />
  </div>
</template>

<script>
import AppTable from './AppTable.vue';
import productsService from '../services/products';

export default {
  name: 'SelectedAnalysisTable',
  props: {
    dataSelected: {
      type: Array,
      required: true,
    },
  },
  components: {
    AppTable,
  },
  data() {
    return {
      data: [],
      editableData: [],
      filteredData: [],
      loading: true,
      readonly: true,
    };
  },
  created() {
    productsService.getData().then(data => {
      this.data = data;
      this.editableData = JSON.parse(JSON.stringify(data));
      this.loading = false;
    });
  },
};
</script>