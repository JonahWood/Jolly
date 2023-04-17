namespace Jolly.Services
{
    public class PostsService
    {
        private readonly PostsRepository _repo;

        public PostsService(PostsRepository repo)
        {
            _repo = repo;
        }
        internal Post Create(Post postData)
        {
            Post post = _repo.Create(postData);
            return post;
        }

        internal List<Post> GetAll()
        {
            List<Post> posts = _repo.GetAll();
            return posts;
        }
    }
}