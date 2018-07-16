using System;
namespace GrowTestApi.Model
{
    public class User
    {
        public long Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public User()
        {
        }
    }
}
