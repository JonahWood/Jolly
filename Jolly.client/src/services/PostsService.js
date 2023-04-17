import { AppState } from "../AppState";
import { logger } from "../utils/Logger";
import { api } from "./AxiosService";

class PostsService{
    async getAllPosts(){
        const res = await api.get('api/posts')
        AppState.posts = res.data
        logger.log('posts:', AppState.posts)
    }
}
export const postsService = new PostsService();