using SistemaDoacoes.Core.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Core.Aggregates.AuthAgg.Entities
{
    public class Donor : Entity
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime BornDate { get; set; }
        public int Schooling { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }
        public Donor()
        {
            Donations = new List<Donation>();
        }
    }
}
