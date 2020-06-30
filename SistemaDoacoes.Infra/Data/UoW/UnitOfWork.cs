using Microsoft.EntityFrameworkCore;
using SistemaDoacoes.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDoacoes.Infra.Data.UoW
{
    public class UnityOfWork : IUnityOfWork
    {
        protected readonly DataContext DbContext;
        public UnityOfWork(DataContext dbContext)
        {
            DbContext = dbContext;
        }
        public bool Commit()
        {
            try
            {
                if (DbContext.ChangeTracker.Entries().Any(e =>
                    e.State == EntityState.Added || e.State == EntityState.Deleted || e.State == EntityState.Modified))
                {
                  //  Log.Information("Commit Done");
                    return DbContext.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception e)
            {
                //Log.Error($"Commit Failed. The reason is {e.Message}");
                throw;
            }
        }
    }
}
