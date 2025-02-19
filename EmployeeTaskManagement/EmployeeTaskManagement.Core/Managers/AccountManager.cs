

namespace EmployeeTaskManagement.Core.Managers
{
    public class AccountManager : IAccountManager
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AccountManager(IAccountRepository accountRepository, IUnitOfWork unitOfWork)
        {
            _accountRepository = accountRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task InitializeAsync()
        {
            await _accountRepository.InitializeAsync();
        }

        public async Task<string> LoginAsync(LoginModel model)
        {
            var user = await _accountRepository.GetUserByEmailAsync(model.Email) ?? throw new Exception("Email does not exist!");

            if (!user.Password.Equals(model.Password)) throw new Exception("Incorrect password!");

            var role = user.RoleId.ToString(); // can be keep in constants A.P.

            return GenerateBearerToken(user, role);
        }

        private static string GenerateBearerToken(User user, string role)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
             
            var key = Encoding.ASCII.GetBytes("qMCdFDQuF23RV1Y-1Gq9L3cF3VmuFwVbam4fMTdAfpo"); // Can be globally assign in program then get here - A.P>

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    [
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                        new Claim(ClaimTypes.Name, user.FirstName),
                        new Claim(ClaimTypes.GivenName, $"{user.FirstName} {user.LastName}".Trim()),
                        new Claim(ClaimTypes.Role, role),
                    ]),
                Audience = "YourAppUsers",   // Can be globally assign in program then get here - A.P>
                Issuer = "YourApp",          // Can be globally assign in program then get here - A.P>
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials =
                        new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
