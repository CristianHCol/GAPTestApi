using System;
using System.Collections.Generic;
using GrowTestApi.Model;
using GrowTestApi.Repositories;


namespace GrowTestApi.Services
{
    public class RiskService : IRiskService
    {
        private readonly IRiskRepository _riskRepository;

        public RiskService(IRiskRepository riskRepository)
        {
            _riskRepository = riskRepository ?? throw new ArgumentNullException(nameof(riskRepository));
        }

        public void InitializedMaster(){
            _riskRepository.InitializedMaster();
        }

        public List<Risk> GetAll()
        {
            return _riskRepository.GetAll();
        }

        public Risk GetById(long id)
        {
            return _riskRepository.GetById(id);
        }

        public bool Create(Risk risk)
        {
            return _riskRepository.Create(risk);
        }

        public bool Update(long id, Risk risk)
        {
            return _riskRepository.Update(id, risk);
        }

        public bool Delete(long id)
        {
            return _riskRepository.Delete(id);
        }
    }
}