using SistemaDoacoes.Core.Aggregates.AuthAgg.Entities;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Infra.Data.Repositories
{
    public class DonorRepository : Repository<Donor>, IDonorRepository
    {
        public DonorRepository(DataContext dbContext) : base(dbContext)
        {

        }
    }
}

