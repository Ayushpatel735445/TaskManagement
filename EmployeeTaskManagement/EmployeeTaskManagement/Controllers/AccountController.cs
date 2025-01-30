

namespace EmployeeTaskManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController(ILogger<AccountController> logger, IAccountManager accountManager) : ControllerBase
    {
        private readonly IAccountManager _accountManager = accountManager;
        private readonly ILogger<AccountController> _logger = logger;

        [HttpPost("seed-database")]
        public async Task<IActionResult> SeedDatabase()
        {
            await _accountManager.InitializeAsync();
            return Ok();
        }

    }
}
