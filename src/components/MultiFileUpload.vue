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
          <li v-for="(file, index) in files" :key="index" class="list-group-item border-0 d-flex justify-content-between align-items-center">
            <div class="d-flex align-items-center">
              <img v-if="isImage(file)" :src="previewImage(file)" class="file-preview me-3" alt="Preview">
              <span class="file-name flex-grow-1">{{ file.name }}</span>
              <span class="file-size">{{ formatFileSize(file.size) }}</span>
            </div>
            <img src="cancel.png" role="button" @click="removeFile(index)">
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
    },
    isImage(file) {
      return file.type.startsWith('image/');
    },
    previewImage(file) {
      return URL.createObjectURL(file);
    },
    formatFileSize(size) {
      const units = ['B', 'KB', 'MB', 'GB', 'TB'];
      let unit = 0;
      while (size >= 1024 && unit < units.length - 1) {
        size /= 1024;
        unit++;
      }
      return `${size.toFixed(1)} ${units[unit]}`;
    }
  }
};
</script>

<style scoped>
.custom-width {
  width: 100%;
  max-width: 80%;
}

.file-preview {
  width: 50px;
  height: 50px;
  object-fit: cover;
}

.file-name {
  margin-right: 10px;
}

.file-size {
  color: gray;
  font-size: 0.9em;
}

@media (max-width: 992px) {
  .custom-width {
    max-width: 100%;
  }
}
</style>
