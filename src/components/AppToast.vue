<template>
    <div class="toast-container position-fixed top-0 end-0 p-3" style="z-index: 11">
        <div class="toast show align-items-center custom-toast border-0" role="alert" aria-live="assertive"
            aria-atomic="true">
            <div class="d-flex">
                <div class="toast-body fw-bold">
                    {{ message }}
                </div>
                <i class="bi bi-x-lg text-success me-2 m-auto" @click="$emit('close')" role="button"></i>
                <!-- <button type="button" class="btn-close btn-close-white text-primary me-2 m-auto" data-bs-dismiss="toast"
                    aria-label="Close"></button> -->
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
}

.custom-close {
    color: #000000;
}
</style>