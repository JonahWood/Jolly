namespace Jolly.Controllers
{
    [ApiController]
    [Route("api/password")]
    public class PasswordsController : ControllerBase
    {
        private readonly PasswordsService _passwordsService;

        public PasswordsController(PasswordsService passwordsService)
        {
            _passwordsService = passwordsService;
        }
        [HttpGet]
        public ActionResult<List<Password>> Find()
        {
            try 
            {
            List<Password> password = _passwordsService.Find();
            return Ok(password);
            }
            catch (Exception e)
            {
            return BadRequest(e.Message);
            }
        }
    }
}