﻿namespace EmployeeTaskManagement.Core.Adstractions.IManagers
{
    public interface IAccountManager
    {
        Task InitializeAsync();
        Task<string> LoginAsync(LoginModel model);
    }
}
