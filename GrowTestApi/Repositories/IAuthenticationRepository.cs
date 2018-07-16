using System.Collections.Generic;
using GrowTestApi.Model;

namespace GrowTestApi.Repositories
{
    public interface IAuthenticationRepository
    {
        void CreateUser();
        bool Authentication(string username, string password);  
    }
}