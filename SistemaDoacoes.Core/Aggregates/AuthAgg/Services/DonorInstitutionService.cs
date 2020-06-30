using SistemaDoacoes.Core.Aggregates.AuthAgg.Entities;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Interfaces.Repositories;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDoacoes.Core.Aggregates.AuthAgg.Services
{
    public class DonorInstitutionService : IDonorInstitutionService
    {
        private readonly IDonorInstitutionRepository _donorInstitutionRepository;

        public DonorInstitutionService(IDonorInstitutionRepository donorInstitutionRepository)
        {
            _donorInstitutionRepository = donorInstitutionRepository;
        }

        public IEnumerable<DonorInstitution> GetDonorInstitutions()
        {
            var donorInstitutions = _donorInstitutionRepository.GetAll().ToList();
            return donorInstitutions.OrderByDescending(x => x.FantasyName);
        }

        public DonorInstitution CreateDonorInstitution(DonorInstitution donorInstitution)
        {
            if (donorInstitution != null)
            {
                var donorInstitutionDb = _donorInstitutionRepository.Create(donorInstitution);

                return donorInstitutionDb;
            }
            return null;
        }

        public DonorInstitution GetDonorInstitution(int idDonorInstitution)
        {
            var donorInstitution = _donorInstitutionRepository.GetById(idDonorInstitution);

            return donorInstitution;
        }

        public void DeleteDonorInstitution(int idDonorInstitution)
        {
            _donorInstitutionRepository.Delete(idDonorInstitution);
        }

        public DonorInstitution UpdateDonorInstitution(DonorInstitution donorInstitution)
        {

            if (donorInstitution != null)
            {
                var donorInstitutionDb = _donorInstitutionRepository.Update(donorInstitution);

                return donorInstitutionDb;
            }
            return null;
        }
    }
}
