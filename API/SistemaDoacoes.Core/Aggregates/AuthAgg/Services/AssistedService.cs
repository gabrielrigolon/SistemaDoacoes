using SistemaDoacoes.Core.Aggregates.AuthAgg.Entities;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Interfaces.Repositories;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDoacoes.Core.Aggregates.AuthAgg.Services
{
    public class AssistedService : IAssistedService
    {
        private readonly IAssistedRepository _assistedRepository;

        public AssistedService(IAssistedRepository assistedRepository)
        {
            _assistedRepository = assistedRepository;
        }

        public IEnumerable<Assisted> GetAssisted()
        {
            var assisteds = _assistedRepository.GetAll().ToList();
            return assisteds.OrderByDescending(x => x.Name);
        }

        public Assisted CreateAssisted(Assisted assisted)
        {
            if (assisted != null)
            {
                var assistedDb = _assistedRepository.Create(assisted);

                return assistedDb;
            }
            return null;
        }

        public Assisted GetAssisted(int idAssisted)
        {
            var assisted = _assistedRepository.GetById(idAssisted);

            return assisted;
        }

        public void DeleteAssisted(int idAssisted)
        {
            _assistedRepository.Delete(idAssisted);
        }

        public Assisted UpdateAssisted(Assisted assisted)
        {

            if (assisted != null)
            {
                var assistedDb = _assistedRepository.Update(assisted);

                return assistedDb;
            }
            return null;
        }
    }
}
