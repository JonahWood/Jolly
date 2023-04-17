namespace Jolly.Controllers
{
    [ApiController]
    [Route("api/password")]
    public class PasswordsController : ControllerBase
    { 
        private readonly PasswordsService passwordsService;

        public PasswordsController(PasswordsService passwordsService)
        {
            this.passwordsService = passwordsService;
        }
        [HttpGet]
        public ActionResult<List<Password>> GetAll()
        {
            try 
            {
            List<Password> passwords = passwordsService.GetAll();
            return Ok(passwords);
            }
            catch (Exception e)
            {
            return BadRequest(e.Message);
            }
        }
    }
}