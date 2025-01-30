using EmployeeTaskManagement.Core.Adstractions.IRepositories;

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



    }
}
