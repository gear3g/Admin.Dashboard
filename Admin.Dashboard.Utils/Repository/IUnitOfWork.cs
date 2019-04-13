using System;

namespace Admin.Dashboard.Utils.Repository
{
    public interface IUnitOfWrok : IDisposable
    {
        void Commit();

        void Rollback();
    }
}