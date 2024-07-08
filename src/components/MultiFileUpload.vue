<template>
  <div class="card custom-width">
    <div class="card-header d-flex">
      <AppButton color="primary" @click="addFiles">Adicionar</AppButton>
      <AppButton color="secondary" @click="uploadFiles" :disabled="files.length === 0">Upload</AppButton>
      <AppButton color="cancel" @click="cancelUpload">Cancelar</AppButton>
    </div>
    <div class="card-body">
      <input type="file" multiple class="d-none" @change="handleFileInput" ref="fileInput" />
      <div v-if="files.length > 0">
        <h3>Arquivos Selecionados</h3>
        <ul class="list-group">
          <li v-for="(file, index) in files" :key="index"
            class="border-0 list-group-item d-flex justify-content-between align-items-center">
            {{ file.name }}
            <button class="btn btn-danger btn-sm" @click="removeFile(index)">X</button>
          </li>
        </ul>
      </div>
    </div>
  </div>
</template>

<script>
import AppButton from '../components/AppButton.vue'

export default {
  name: 'MultiFileUpload',
  components: {
      AppButton,
    },
  data() {
    return {
      files: []
    };
  },
  methods: {
    handleFileInput(event) {
      this.files.push(...Array.from(event.target.files));
    },
    addFiles() {
      this.$refs.fileInput.click();
    },
    uploadFiles() {
      alert(`Fazendo upload de ${this.files.length} arquivo(s).`);
    },
    cancelUpload() {
      this.files = [];
      this.$refs.fileInput.value = null;
    },
    removeFile(index) {
      this.files.splice(index, 1);
    }
  }
};
</script>

<style scoped>
.d-flex {
  display: flex;
}

.justify-content-between {
  justify-content: space-between;
}

.custom-width {
  width: 80%;
}

@media (max-width: 992px) {
  .custom-width {
    width: 100%;
  }
}
</style>
