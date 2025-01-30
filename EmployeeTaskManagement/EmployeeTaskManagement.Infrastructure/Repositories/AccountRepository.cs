namespace EmployeeTaskManagement.Infrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _dataContext;

        public AccountRepository(ApplicationDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task InitializeAsync()
        {
            bool recordsAdded = false;

            if (!await _dataContext.Role.AnyAsync(x => x.Name.Equals("Admin")))

                recordsAdded = true;

            await _dataContext.Role.AddAsync(new Role
            {
                Name = "Admin",

            });

            if (!await _dataContext.Role.AnyAsync(x => x.Name.Equals("Employee")))

                recordsAdded = true;

            await _dataContext.Role.AddAsync(new Role
            {
                Name = "Employee",

            });

            if (recordsAdded)
            {
                await _dataContext.SaveChangesAsync();
            }
        }
    }

}
