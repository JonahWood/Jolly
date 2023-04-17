namespace Jolly.Repositories
{
    public class PostsRepository
    {
        private readonly IDbConnection _db;

        public PostsRepository(IDbConnection db)
        {
            _db = db;
        }
        internal Post Create(Post postData)
        {
            string sql = @"
            INSERT INTO posts
            (body, img, createdAt, views)
            VALUES
            (@body, @img, @createdAt, views);
            SELECT LAST_INSERT_ID();
            ";
            int id = _db.ExecuteScalar<int>(sql, postData);
            postData.Id = id;
            return postData;
        }

        internal List<Post> GetAll()
        {
            string sql = @"
            SELECT
            *
            FROM posts;
            ";
            List<Post> posts = _db.Query<Post>(sql).ToList();
            return posts;
        }
    }
}