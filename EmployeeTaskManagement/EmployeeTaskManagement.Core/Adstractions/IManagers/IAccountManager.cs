namespace EmployeeTaskManagement.Core.Adstractions.IManagers
{
    public interface IAccountManager
    {
        Task InitializeAsync();
        Task LoginAsync(LoginModel model);
    }
}
