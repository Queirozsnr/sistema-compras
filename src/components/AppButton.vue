<template>
    <button class="mx-1" :class="[buttonClass, additionalClasses]" @click="handleClick">
        <slot></slot>
    </button>
</template>

<script>
export default {
    name: 'AppButton',
    props: {
        color: {
            type: String,
            default: 'primary',
            validator: value => ['primary', 'secondary', 'cancel'].includes(value)
        },
        onClick: {
            type: Function,
            default: () => { }
        },
        additionalClasses: {
            type: String,
            default: ''
        }
    },
    computed: {
        buttonClass() {
            return {
                'btn': true,
                ['btn-' + this.color]: true
            };
        }
    },
    methods: {
        handleClick() {
            this.onClick();
        }
    }
};
</script>

<style scoped>
.btn {
    padding: 0.5rem 1rem;
    font-size: 1rem;
    border-radius: 0.2rem;
    cursor: pointer;
}

.btn-primary {
    background-color: var(--primary-color);
    border-color: var(--primary-color);
    color: var(--white-color);
}

.btn-secondary {
    background-color: var(--white-color);
    border-color: var(--primary-color);
    color: var(--primary-color);
}

.btn-secondary:hover {
    background-color: var(--primary-color);
    border-color: var(--white-color);
}

.btn-cancel {
    background-color: var(--white-color);
    border-color: var(--secondary-color);
    color: var(--secondary-color);
}

.btn-cancel:hover {
    background-color: var(--secondary-color);
    border-color: var(--secondary-color);
    color: var(--white-color);
}
</style>
