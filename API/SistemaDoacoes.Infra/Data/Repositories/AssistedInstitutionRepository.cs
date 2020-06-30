using SistemaDoacoes.Core.Aggregates.AuthAgg.Entities;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Infra.Data.Repositories
{
    public class AssistedInstitutionRepository : Repository<AssistedInstitution>, IAssistedInstitutionRepository
    {
        public AssistedInstitutionRepository(DataContext dbContext) : base(dbContext)
        {

        }
    }
}
