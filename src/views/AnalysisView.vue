<template>
  <div>
    <h4 class="fw-bold">Análise de Valores</h4>

    <div class="container">
      <div class="row custom-width">
        <div class="col-12 col-sm-12 col-md-12 col-lg-3">
          <CardInput label="Código" value="001" />
        </div>
        <div class="col-12 col-sm-12 col-md-12 col-lg-6">
          <CardInput label="Descrição" value="Lista de Expediente" />
        </div>
        <div class="col-12 col-sm-12 col-md-12 col-lg-3">
          <CardInput label="Tipo:" value="Material" />
        </div>
      </div>
      
    </div>

    <hr class="border-dark my-4">
    <AnalysisTable />
    <hr class="border-dark my-4">
    <MultiFileUpload />
    <hr class="border-dark my-4">
    <SelectedAnalysisTable />

  </div>
</template>

<script>
import AnalysisTable from '../components/AnalysisTable.vue';
import CardInput from '../components/CardInput.vue';
import MultiFileUpload from '../components/MultiFileUpload.vue'
import SelectedAnalysisTable from '../components/SelectedAnalysisTable.vue'

export default {
  name: 'AnalysisView',
  components: {
    AnalysisTable,
    CardInput,
    MultiFileUpload,
    SelectedAnalysisTable,
  },
};
</script>

<style>
.custom-width {
  width: 65%;
}
@media (max-width: 992px) {
  .custom-width {
    width: 100%;
  }
}
</style>
