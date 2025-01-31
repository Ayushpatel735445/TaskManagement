namespace EmployeeTaskManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController(ILogger<AccountController> logger, IAccountManager accountManager) : ControllerBase
    {
        private readonly IAccountManager _accountManager = accountManager;
        private readonly ILogger<AccountController> _logger = logger;  // Only keep here for scalablity of project A.P.

        [HttpPost("seed-database")]
        public async Task<IActionResult> SeedDatabase()
        {
            await _accountManager.InitializeAsync();
            return Ok();
        }

        [HttpPost("login")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> LoginAsync([FromBody] LoginModel model)
        {
            try
            {
                return Ok(await _accountManager.LoginAsync(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  // Can apply logger also - A.P
            }
        }
    }
}
