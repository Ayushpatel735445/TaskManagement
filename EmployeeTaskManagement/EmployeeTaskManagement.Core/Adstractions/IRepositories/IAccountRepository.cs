namespace EmployeeTaskManagement.Core.Adstractions.IRepositories
{
    public interface IAccountRepository
    {
        Task InitializeAsync();
        Task<User?> GetUserByEmailAsync(string email);
    }
}
