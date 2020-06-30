using SistemaDoacoes.Core.Aggregates.AuthAgg.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Core.Aggregates.AuthAgg.Interfaces.Services
{
    public interface IAssistedInstitutionService
    {
            IEnumerable<AssistedInstitution> GetAssistedInstitutions();
            AssistedInstitution GetAssistedInstitution(int idAssistedInstitution);
            AssistedInstitution CreateAssistedInstitution(AssistedInstitution assistedInstitution);
            void DeleteAssistedInstitution(int idAssistedInstitution);
            AssistedInstitution UpdateAssistedInstitution(AssistedInstitution assistedInstitution);

    }
}
