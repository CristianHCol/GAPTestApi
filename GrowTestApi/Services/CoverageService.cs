using System;
using System.Collections.Generic;
using GrowTestApi.Model;
using GrowTestApi.Repositories;


namespace GrowTestApi.Services
{
    public class CoverageService : ICoverageService
    {
        private readonly ICoverageRepository _coverageRepository;

        public CoverageService(ICoverageRepository coverageRepository)
        {
            _coverageRepository = coverageRepository ?? throw new ArgumentNullException(nameof(coverageRepository));
        }

        public void InitializedMaster()
        {
            _coverageRepository.InitializedMaster();
        }

        public List<CoverageType> GetAll()
        {
            return _coverageRepository.GetAll();
        }

        public CoverageType GetById(long id)
        {
            return _coverageRepository.GetById(id);
        }

        public bool Create(CoverageType coverage)
        {
            return _coverageRepository.Create(coverage);
        }

        public bool Update(long id, CoverageType coverage)
        {
            return _coverageRepository.Update(id, coverage);
        }

        public bool Delete(long id)
        {
            return _coverageRepository.Delete(id);
        }
    }
}