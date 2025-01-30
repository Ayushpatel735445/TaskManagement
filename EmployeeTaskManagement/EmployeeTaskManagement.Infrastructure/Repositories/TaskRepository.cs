

namespace EmployeeTaskManagement.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _dataContext;

        public TaskRepository(ApplicationDbContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
