namespace Library.Core.UnitofWork
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
