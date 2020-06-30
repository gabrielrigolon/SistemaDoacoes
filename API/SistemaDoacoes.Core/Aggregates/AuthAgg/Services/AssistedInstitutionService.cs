using SistemaDoacoes.Core.Aggregates.AuthAgg.Entities;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Interfaces.Repositories;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDoacoes.Core.Aggregates.AuthAgg.Services
{
    public class AssistedInstitutionService : IAssistedInstitutionService
    {
        private readonly IAssistedInstitutionRepository _assistedInstitutionRepository;

        public AssistedInstitutionService(IAssistedInstitutionRepository assistedInstitutionRepository)
        {
            _assistedInstitutionRepository = assistedInstitutionRepository;
        }

        public IEnumerable<AssistedInstitution> GetAssistedInstitutions()
        {
            var assistedInstitutions = _assistedInstitutionRepository.GetAll().ToList();
            return assistedInstitutions.OrderByDescending(x => x.FantasyName);
        }

        public AssistedInstitution CreateAssistedInstitution(AssistedInstitution assistedInstitution)
        {
            if (assistedInstitution != null)
            {
                var assistedInstitutionDb = _assistedInstitutionRepository.Create(assistedInstitution);

                return assistedInstitutionDb;
            }
            return null;
        }

        public AssistedInstitution GetAssistedInstitution(int idAssistedInstitution)
        {
            var assistedInstitution = _assistedInstitutionRepository.GetById(idAssistedInstitution);

            return assistedInstitution;
        }

        public void DeleteAssistedInstitution(int idAssistedInstitution)
        {
            _assistedInstitutionRepository.Delete(idAssistedInstitution);
        }

        public AssistedInstitution UpdateAssistedInstitution(AssistedInstitution assistedInstitution)
        {

            if (assistedInstitution != null)
            {
                var assistedInstitutionDb = _assistedInstitutionRepository.Update(assistedInstitution);

                return assistedInstitutionDb;
            }
            return null;
        }
    }
}
