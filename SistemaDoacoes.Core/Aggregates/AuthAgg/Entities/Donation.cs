using SistemaDoacoes.Core.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Core.Aggregates.AuthAgg.Entities
{
    public class Donation : Entity
    {
        public int IdOrigin { get; set; }
        public virtual Donor Donor { get; set; }
        public virtual DonorInstitution DonorInstitution { get; set; }
        public int IdDestination { get; set; }
        public virtual Assisted Assisted { get; set; }
        public virtual AssistedInstitution AssistedInstitution { get; set; }
        public int Type { get; set; }
        public int Value { get; set; }
    }
}
