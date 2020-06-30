using SistemaDoacoes.Core.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Core.Aggregates.AuthAgg.Entities
{
    public class AssistedInstitution : Entity
    {
        public string Cnpj { get; set; }
        public string FantasyName { get; set; }
        public string CorporateName { get; set; }
        public int QtdAssisted { get; set; }
        public int InstitutionType { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }
        public AssistedInstitution()
        {
            Donations = new List<Donation>();
        }

    }
}
