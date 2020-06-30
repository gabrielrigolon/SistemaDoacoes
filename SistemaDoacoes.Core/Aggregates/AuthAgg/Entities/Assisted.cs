using SistemaDoacoes.Core.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Core.Aggregates.AuthAgg.Entities
{
    public class Assisted : Entity
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        public DateTime BornDate { get; set; }
        public int QtdDependents { get; set; }
        public int Schooling { get; set; }
        public bool Householder { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }
        public Assisted()
        {
            Donations = new List<Donation>();
        }
    }
}
