<template>
  <div class="card custom-width">
    <div class="card-header d-flex">
      <button class="btn btn-primary mx-3" @click="addFiles">Adicionar</button>
      <button class="btn btn-success mx-3" @click="uploadFiles" :disabled="files.length === 0">Upload</button>
      <button class="btn btn-danger mx-3" @click="cancelUpload">Cancelar</button>
    </div>
    <div class="card-body">
      <input
        type="file"
        multiple
        class="d-none"
        @change="handleFileInput"
        ref="fileInput"
      />
      <div v-if="files.length > 0">
        <h3>Arquivos Selecionados</h3>
        <ul class="list-group">
          <li v-for="(file, index) in files" :key="index" class="list-group-item d-flex justify-content-between align-items-center">
            {{ file.name }}
            <button class="btn btn-danger btn-sm" @click="removeFile(index)">X</button>
          </li>
        </ul>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'MultiFileUpload',
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

