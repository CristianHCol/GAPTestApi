using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GrowTestApi.Model;
using GrowTestApi.Services;
using GrowTestApi.Repositories;


namespace GrowTestApi.Services
{
    public class AgencyService : IAgencyService
    {
        private readonly IAgencyRepository _agencyRepository;

        public AgencyService(IAgencyRepository agencyRepository)
        {
            _agencyRepository = agencyRepository ?? throw new ArgumentNullException(nameof(agencyRepository));
        }

        public void InitializedMaster()
        {
            _agencyRepository.InitializedMaster();
        }

        public List<Agency> GetAll()
        {
            return _agencyRepository.GetAll();
        }

        public Agency GetById(long id)
        {
            return _agencyRepository.GetById(id);
        }

        public bool Create(Agency agency)
        {
            return _agencyRepository.Create(agency);
        }

        public bool Update(long id, Agency agency)
        {
            return _agencyRepository.Update(id, agency);
        }

        public bool Delete(long id)
        {
            return _agencyRepository.Delete(id);
        }
    }
}