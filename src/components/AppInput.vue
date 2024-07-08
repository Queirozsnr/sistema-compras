<template>
    <div class="form-group">
        <label :for="id" class="visually-hidden">{{ label }}</label>
        <input :type="type" class="form-control custom-input" :id="id" :placeholder="placeholder"
            v-model="inputValue" />
    </div>
</template>

<script>
export default {
    props: {
        id: String,
        label: String,
        type: {
            type: String,
            default: 'text'
        },
        placeholder: String,
        value: [String, Number]
    },
    computed: {
        inputValue: {
            get() {
                return this.value;
            },
            set(newValue) {
                this.$emit('input', newValue);
            }
        }
    }
};
</script>

<style scoped>
.custom-input {
    height: 4rem;
}
</style>