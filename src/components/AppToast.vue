<template>
    <div class="toast-container position-fixed top-0 end-0 p-3" style="z-index: 11">
        <div class="toast show align-items-center custom-toast border-0" role="alert" aria-live="assertive"
            aria-atomic="true">
            <div class="d-flex">
                <div class="d-flex align-items-center">
                    <i class="bi bi-check text-success me-2 fs-4"></i>
                </div>
                <div class="toast-body fw-bold text-nowrap">
                    {{ message }}
                </div>
                <i class="bi bi-x-lg text-success ms-2 m-auto" @click="$emit('close')" role="button"></i> <!-- Botão de fechar -->
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'AppToast',
    props: {
        message: {
            type: String,
            required: true
        }
    }
};
</script>

<style scoped>
.toast-container {
    z-index: 1050;
}

.custom-toast {
    background-color: #E8F7F0;
    color: var(--success-color);
    min-width: 300px;
    height: auto;
    padding: 15px;
    font-size: 1rem;
}

@media (max-width: 576px) {
    .custom-toast {
        width: 100%;
    }
}
</style>
