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
            {

                recordsAdded = true;

                await _dataContext.Role.AddAsync(new Role
                {
                    Name = "Admin",

                });
            }

            if (!await _dataContext.Role.AnyAsync(x => x.Name.Equals("Employee")))
            {

                recordsAdded = true;

                await _dataContext.Role.AddAsync(new Role
                {
                    Name = "Employee",

                });
            }

            if (recordsAdded)
            {
                await _dataContext.SaveChangesAsync();
            }

            if (!await _dataContext.User.AnyAsync(x => x.Email.Equals("Ayush@gmail.com")))
            {

                recordsAdded = true;

                await _dataContext.User.AddAsync(new User
                {
                    Email = "Ayush@gmail.com",
                    FirstName = "Ayush",
                    LastName = "Patel",
                    Password = "A",
                    RoleId =  _dataContext.Role.Where(x => x.Name.Equals("Employee")).Select(x => (int?)x.Id).Single() ?? throw new Exception("Unable to insert forign key!")

                });

            }

            if (!await _dataContext.User.AnyAsync(x => x.Email.Equals("Lucky@gmail.com")))
            {

                recordsAdded = true;

                await _dataContext.User.AddAsync(new User
                {
                    Email = "Lucky@gmail.com",
                    FirstName = "Lucky",
                    LastName = "Patel",
                    Password = "L",
                    RoleId =  1

                });

            }

            if (!await _dataContext.User.AnyAsync(x => x.Email.Equals("vedant@gmail.com")))
            {

                recordsAdded = true;

                await _dataContext.User.AddAsync(new User
                {
                    Email = "vedant@gmail.com",
                    FirstName = "vedant",
                    LastName = "Patel",
                    Password = "A",
                    RoleId = _dataContext.Role.Where(x => x.Name.Equals("Employee")).Select(x => (int?)x.Id).Single() ?? throw new Exception("Unable to insert forign key!")

                });

            }

            if (!await _dataContext.User.AnyAsync(x => x.Email.Equals("surbhi@gmail.com")))
            {

                recordsAdded = true;

                await _dataContext.User.AddAsync(new User
                {
                    Email = "surbhi@gmail.com",
                    FirstName = "surbhi",
                    LastName = "Patel",
                    Password = "s",
                    RoleId = _dataContext.Role.Where(x => x.Name.Equals("Employee")).Select(x => (int?)x.Id).Single() ?? throw new Exception("Unable to insert forign key!")

                });

            }

            if (recordsAdded)
            {
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _dataContext.User.Where(x => x.Email.Equals(email)).SingleOrDefaultAsync();
        }
    }
}

