<template>
    <p>{{ post?.body }}</p>
</template>


<script>
import { computed } from '@vue/reactivity';
import { AppState } from '../AppState';

export default {
    props: { post: { type: Object, required: true } },
    setup() {
        return {

        }
    }
}
</script>


<style lang="scss" scoped></style>