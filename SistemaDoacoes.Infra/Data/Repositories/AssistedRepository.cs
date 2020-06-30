using SistemaDoacoes.Core.Aggregates.AuthAgg.Entities;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Infra.Data.Repositories
{
    public class AssistedRepository : Repository<Assisted>, IAssistedRepository
    {
        public AssistedRepository(DataContext dbContext) : base(dbContext)
        {

        }
    }
}
