using SistemaDoacoes.Core.Aggregates.AuthAgg.Entities;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDoacoes.Core.Aggregates.AuthAgg.Services
{
    public class DonationService
    {
        private readonly IDonationRepository _donationRepository;

        public DonationService(IDonationRepository donationRepository)
        {
            _donationRepository = donationRepository;
        }

        public IEnumerable<Donation> GetDonations()
        {
            var donations = _donationRepository.GetAll().ToList();
            return donations.OrderByDescending(x => x.Id);
        }

        public Donation CreateDonation(Donation donation)
        {
            if (donation != null)
            {
                var donationDb = _donationRepository.Create(donation);

                return donationDb;
            }
            return null;
        }

        public Donation GetDonation(int idDonation)
        {
            var donation = _donationRepository.GetById(idDonation);

            return donation;
        }

        public void DeleteDonation(int idDonation)
        {
            _donationRepository.Delete(idDonation);
        }

        public Donation UpdateDonation(Donation donation)
        {

            if (donation != null)
            {
                var donationDb = _donationRepository.Update(donation);

                return donationDb;
            }
            return null;
        }
    }
}
