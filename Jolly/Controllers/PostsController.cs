namespace Jolly.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly PostsService _postsService;

        public PostsController(PostsService postsService)
        {
            _postsService = postsService;
        }
        [HttpPost]
        public ActionResult<Post> Create([FromBody] Post postData)
        {
            try 
            {
            Post post = _postsService.Create(postData);
            return Ok(post);
            }
            catch (Exception e)
            {
            return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public ActionResult<List<Post>> GetAll()
        {
            try 
            {
            List<Post> posts = _postsService.GetAll();
            return Ok(posts);
            }
            catch (Exception e)
            {
              return BadRequest(e.Message);
            }
        }
    }
}