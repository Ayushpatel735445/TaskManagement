namespace TaskManagement.Infrastructure
{
    public class UnitOfWork(ApplicationDbContext dataContext) : IUnitOfWork
    {
        private readonly ApplicationDbContext _dataContext = dataContext;
        private IDbContextTransaction _dbTransaction;

        public void BeginTransaction()
        {
            _dbTransaction = _dataContext.Database.BeginTransaction();
        }

        public async Task BeginTransactionAsync()
        {
            _dbTransaction = await _dataContext.Database.BeginTransactionAsync();
        }

        public int SaveChanges()
        {
            return _dataContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dataContext.SaveChangesAsync();
        }

        public void Commit()
        {
            _dbTransaction.Commit();
        }

        public async Task CommitAsync()
        {
            await _dbTransaction.CommitAsync();
        }

        public void Rollback()
        {
            _dbTransaction.Rollback();
        }

        public async Task RollbackAsync()
        {
            await _dbTransaction.RollbackAsync();
        }
    }
}
