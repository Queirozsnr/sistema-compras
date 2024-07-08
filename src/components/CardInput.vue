<template>
    <div class="card w-100 my-2">
        <div class="card-body d-flex">
            <p class="card-title text-secondary m-1">{{ label }}</p>
            <p class="card-title m-1">{{ value }}</p>
        </div>
    </div>
</template>

<script>
export default {
    name: 'CardInput',
    props: {
        label: {
            type: String,
            required: true
        },
        value: {
            type: String,
            required: true
        }
    }
};
</script>