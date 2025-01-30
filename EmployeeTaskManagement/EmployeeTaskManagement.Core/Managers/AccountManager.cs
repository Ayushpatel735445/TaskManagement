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

        public async Task LoginAsync(LoginModel model)
        {
            var user = await _accountRepository.GetUserByEmailAsync(model.Email) ?? throw new Exception("Email does not exist!");

            if (!user.Password.Equals(model.Password))  throw new Exception("Incorrect password!");
        }
    }
}
