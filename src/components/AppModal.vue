<template>
    <div class="modal fade show" tabindex="-1" role="dialog"
        style="display: block; background-color: rgba(0, 0, 0, 0.5);">
        <div class="modal-dialog modal-dialog-centered modal-lg" role="document">
            <div class="modal-content rounded-0">
                <div class="modal-header custom-modal-header">
                    <p class="modal-title custom-title fw-bold">{{ modalTitle }}</p>
                </div>
                <div class="modal-body custom-modal-body">
                    <slot></slot>
                </div>
            </div>
        </div>
    </div>
  </template>
  
  <script>
  export default {
    name: 'AppModal',
    props: {
      modalTitle: String
    },
  };
  </script>
  
  <style scoped>
  .custom-modal-header {
    height: 5rem;
  }
  .custom-modal-body {
    min-height: 10rem;
  }
  </style>
  