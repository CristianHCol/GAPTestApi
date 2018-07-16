using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GrowTestApi.Model;
using GrowTestApi.Services;
using GrowTestApi.Repositories;


namespace GrowTestApi.Services
{
    public class AuthencationService : IAuthenticationService
    {
        private readonly IAuthenticationRepository _authRepository;

        public AuthencationService(IAuthenticationRepository authRepository)
        {
            _authRepository = authRepository ?? throw new ArgumentNullException(nameof(authRepository));
        }

        public void CreateUser()
        {
            _authRepository.CreateUser();
        }

        public bool Authentication(string username, string password)
        {
            return _authRepository.Authentication(username, password);
        }
    }
}