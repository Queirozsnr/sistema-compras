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
    <hr class="border-dark my-4">
    <div class="d-flex justify-content-end mb-3">
      <AppButton color="cancel" @click="addFiles">Cancelar</AppButton>
      <AppButton color="secondary" @click="addFiles">Salvar Rascunho</AppButton>
      <AppButton color="primary" @click="openModal('finalizar')">Finalizar</AppButton>
    </div>

    <AppModal v-if="showModalFinalizar" modal-title="Enviar Cotação">
      <div class="d-flex justify-content-center">
        <p class="custom-title fw-bold">Deseja enviar agora como pedido para o Protheus?</p>
      </div>
      <div class="d-flex justify-content-center my-3">
        <AppButton color="cancel" @click="closeModal('finalizar')">Retornar a edição</AppButton>
        <AppButton color="secondary" @click="openModal('reprovar')">Reprovar</AppButton>
        <AppButton color="primary" @click="openModal('finalizar')">Aprovar</AppButton>
      </div>
    </AppModal>

    <AppModal v-if="showModalReprovar" modal-title="Reprovar">
      <div class="container">
        <div class="row">
          <div class="col-12 col-sm-12 col-md-12 col-lg-4">
            <CardInput label="Código" value="001" />
          </div>
          <div class="col-12 col-sm-12 col-md-12 col-lg-8">
            <CardInput label="Descrição" value="Lista de Expediente" />
          </div>
          <div class="col-12 col-sm-12 col-md-12 col-lg-5">
            <CardInput label="Tipo:" value="Material" />
          </div>
        </div>
        <div class="row">
          <p class="custom-title fw-bold mt-1">Justificativa</p>
          <div class="col">
            <CardInput label="Descreva a Justificativa" value="" />
          </div>
        </div>
      </div>
      <div class="d-flex justify-content-end my-3">
        <AppButton color="secondary" @click="closeModal('reprovar')">Cancelar</AppButton>
        <AppButton color="primary" @click="closeModal">Confirmar</AppButton>
      </div>
    </AppModal>

  </div>
</template>

<script>
import AnalysisTable from '../components/AnalysisTable.vue';
import MultiFileUpload from '../components/MultiFileUpload.vue';
import SelectedAnalysisTable from '../components/SelectedAnalysisTable.vue';
import AppButton from '../components/AppButton.vue';
import AppModal from '../components/AppModal.vue';
import CardInput from '../components/CardInput.vue'

export default {
  name: 'AnalysisView',
  components: {
    AnalysisTable,
    CardInput,
    MultiFileUpload,
    SelectedAnalysisTable,
    AppButton,
    AppModal,
  },
  data() {
    return {
      showModalFinalizar: false,
      showModalReprovar: false,
    };
  },
  methods: {
    addFiles() {
      console.log('Adicionando arquivos...');
    },
    openModal(modal) {
      this.setModalVisibility(modal, true);
    },
    closeModal(modal) {
      this.setModalVisibility(modal, false);
    },
    setModalVisibility(modal, isVisible) {
      if (modal === 'finalizar') {
        this.showModalFinalizar = isVisible;
      } else if (modal === 'reprovar') {
        this.showModalReprovar = isVisible;
      } else {
        this.showModalFinalizar = isVisible;
        this.showModalReprovar = isVisible;
      }
    }
  }
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
