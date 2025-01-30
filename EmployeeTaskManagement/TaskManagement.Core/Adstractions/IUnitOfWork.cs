namespace TaskManagement.Core.Adstractions
{
    public interface IUnitOfWork
    {
        void BeginTransaction();

        Task BeginTransactionAsync();

        int SaveChanges();

        Task<int> SaveChangesAsync();

        void Commit();

        Task CommitAsync();

        void Rollback();

        Task RollbackAsync();
    }
}
