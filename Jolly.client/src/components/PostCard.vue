<template>
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-12 d-flex justify-content-center rounded"><img :src="post?.img" alt=""></div>
            <div class="col-12 d-flex justify-content-center">{{ post?.body }}</div>
        </div>
    </div>
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