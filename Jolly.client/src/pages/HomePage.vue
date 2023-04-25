<template>
  <div class="container max-h">
    <div class="row d-flex justify-content-center align-items-center max-h">
      <div v-if="!PWCheck" class="col-md-4 d-flex justify-content-center align-items-center">
        <form @submit.prevent="submit()">
          <label for="title">Blue or purple?</label>
          <input required v-model="editable.password" type="text" class="form-control" id="title">

          <button type="submit" class="mt-1">Submit</button>
        </form>
      </div>
      <div v-if="PWCheck" class="col-md-12">
        <button @click="close()">Close</button>
      </div>
      <div v-if="posts">

        <div class="col-md-12 postCard rounded my-3 py-2" v-for="p in posts">
          <PostCard :post="p" />

        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { ref, computed, onMounted, watchEffect } from 'vue';
import { AppState } from '../AppState';
import { logger } from '../utils/Logger';
import Pop from '../utils/Pop';
import { passwordsService } from '../services/PasswordsService';
import { postsService } from '../services/PostsService'
import { router } from '../router';
import { useRouter } from 'vue-router';
import PostCard from '../components/PostCard.vue';

export default {
  setup() {
    watchEffect(() => {
      if (AppState.PWCheck) {
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
      editable,
      router,
      Pass: computed(() => AppState.PWCheck),
      posts: computed(() => AppState.posts),
      async submit() {
        try {
          logger.log(editable.value.password);
          const input = editable.value.password;
          await passwordsService.getPW(input);
        }
        catch (error) {
          Pop.error(error.message);
          logger.error(error);
        }
      },
      close() {
        AppState.PWCheck = false;
      }
    };
  },
  components: { PostCard }
}
</script>

<style scoped lang="scss">
.postCard {
  background: linear-gradient(-45deg, #1f5321, #35c5c5, #2696aa, #198b6f);
  background-size: 400% 400%;
  animation: gradient 15s ease infinite;
  border: 2px solid rgba(0, 0, 0, 0.662);
}

@keyframes gradient {
  0% {
    background-position: 0% 50%;
  }

  50% {
    background-position: 100% 50%;
  }

  100% {
    background-position: 0% 50%;
  }
}

.max-h {
  min-height: 100vh;
}

.home {
  display: grid;
  height: 80vh;
  place-content: center;
  text-align: center;
  user-select: none;

  .home-card {
    width: 50vw;

    >img {
      height: 200px;
      max-width: 200px;
      width: 100%;
      object-fit: contain;
      object-position: center;
    }
  }
}
</style>
