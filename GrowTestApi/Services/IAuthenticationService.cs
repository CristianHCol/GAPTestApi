using System.Collections.Generic;
using GrowTestApi.Model;


namespace GrowTestApi.Services
{
    public interface IAuthenticationService
    {
        void CreateUser();
        bool Authentication(string username, string password);
    }
}
