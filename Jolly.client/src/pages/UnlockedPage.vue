<template>
    <div class="container">
        <div class="row">
            <div class="col-md-12" v-for="p in posts">
                <PostCard :post="p" />

            </div>
        </div>
    </div>
</template>


<script>
import { onMounted, ref, watchEffect } from 'vue';
import { useRouter } from 'vue-router';
import Pop from '../utils/Pop';
import { logger } from '../utils/Logger';
import { postsService } from '../services/PostsService';
import { AppState } from '../AppState';
import { computed } from '@vue/reactivity';
import PostCard from '../components/PostCard.vue';

export default {
    setup() {
        onMounted(() => {
            AppState.safe = true
        })
        watchEffect(() => {
            if (AppState.safe) {
                getAllPosts();
            }
        });
        let editable = ref({});
        let router = useRouter();
        async function getAllPosts() {
            try {
                AppState.posts = [];
                await postsService.getAllPosts();
            }
            catch (error) {
                Pop.error(error.message);
                logger.error(error);
            }
        }
        return {
            router,
            editable,
            posts: computed(() => AppState.posts),
        };
    },
    components: { PostCard }
}
</script>


<style lang="scss" scoped></style>