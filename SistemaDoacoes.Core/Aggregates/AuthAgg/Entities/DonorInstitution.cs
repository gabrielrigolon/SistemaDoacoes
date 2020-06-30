using SistemaDoacoes.Core.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Core.Aggregates.AuthAgg.Entities
{
    public class DonorInstitution : Entity
    {
        public string Cnpj { get; set; }
        public string FantasyName { get; set; }
        public string CorporateName { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }
        public DonorInstitution()
        {
            Donations = new List<Donation>();
        }
    }
}
