<template>
    <div class="container-fluid">
        <div class="row justify-content-center">
            <div class="col-12 d-flex justify-content-center rounded theimg"><img class="rounded" :src="post?.img" alt="">
            </div>
            <div class="col-12 d-flex justify-content-center text-body">
                <h3>{{ post?.body }}</h3>
            </div>
        </div>

        <div class="row justify-content-center">
            <div class="col-12 d-flex justify-content-center">
                <h6 class="views"><i class="mdi mdi-eye-circle"></i>{{ post?.views }}</h6>
            </div>
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


<style lang="scss" scoped>
.views {
    color: gray;
}

.text-body {
    color: white !important;
    text-shadow: 2px 2px 2px black;
    margin-top: 1em;
}

.theimg {
    border-bottom: 1px solid rgba(0, 0, 0, 0.594);
    padding-bottom: 1em;
}
</style>