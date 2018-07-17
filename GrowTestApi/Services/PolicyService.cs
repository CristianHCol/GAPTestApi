using System;
using System.Collections.Generic;
using GrowTestApi.Model;
using System.Linq;
using GrowTestApi.Repositories;


namespace GrowTestApi.Services
{
    public class PolicyService : IPolicyService
    {
        private readonly IPolicyRepository _policyRepository;

        public PolicyService(IPolicyRepository policyRepository)
        {
            _policyRepository = policyRepository ?? throw new ArgumentNullException(nameof(policyRepository));
        }

        public List<Policy> GetAll()
        {
            return _policyRepository.GetAll();
        }

        public Policy GetById(long id)
        {
            return _policyRepository.GetById(id);
        }

        public bool Create(Policy policy)
        {
            if (policy.RiskType.Description == "Alto")
            {
                List<CoverageType> L = policy.Coverage.ToList();
                L[0].Percentage = 30;
                policy.Coverage.Remove(L[0]);
                policy.Coverage.Add(L[0]);
            }
            return _policyRepository.Create(policy);
        }

        public bool Update(long id, Policy policy)
        {
            return _policyRepository.Update(id, policy);
        }

        public bool Delete(long id)
        {
            return _policyRepository.Delete(id);
        }
    }
}