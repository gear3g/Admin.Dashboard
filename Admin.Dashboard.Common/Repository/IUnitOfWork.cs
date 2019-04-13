using System;

namespace Admin.Dashboard.Common.Repository
{
    public interface IUnitOfWrok : IDisposable
    {
        void Commit();
        
        void Rollback();
    }
}