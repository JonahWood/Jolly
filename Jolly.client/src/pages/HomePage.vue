<template>
  <div class="container">
    <div class="row d-flex justify-content-center">
      <div v-if="!PWCheck" class="col-md-4">
        <form @submit.prevent="submit()">
          <label for="title">Blue or purple?</label>
          <input required v-model="editable.password" type="text" class="form-control" id="title">

          <button type="submit" class="mt-1">Submit</button>
        </form>
      </div>
      <div v-if="PWCheck" class="col-12">
        <button @click="close()">Close</button>
      </div>
      <div class="col-12">
        <img v-if="PWCheck" src="https://codeworks.blob.core.windows.net/public/assets/img/projects/Airport.jpg" alt="">
      </div>
    </div>
  </div>
</template>

<script>
import { ref, computed, onMounted } from 'vue';
import { AppState } from '../AppState';
import { logger } from '../utils/Logger';
import Pop from '../utils/Pop';
import { passwordsService } from '../services/PasswordsService'

export default {
  setup() {
    let editable = ref({})
    async function getPW() {
      try {
        // await passwordsService.getPW()
      }
      catch (error) {
        Pop.error(error.message)
        logger.error(error)
      }
    }


    return {
      editable,
      PWCheck: computed(() => AppState.PWCheck),
      async submit() {
        try {

          logger.log(editable.value.password)
          const pw = editable.value.password
          await passwordsService.getPW(pw)
          if (pw == 'password') {
            AppState.PWCheck = true
          }
        }
        catch (error) {
          Pop.error(error.message)
          logger.error(error)
        }
      },
      close() {
        AppState.PWCheck = false
      }
    }
  }
}
</script>

<style scoped lang="scss">
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
