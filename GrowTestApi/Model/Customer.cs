using System;
namespace GrowTestApi.Model
{
    public class Customer
    {
        public long Id { get; set; }
        public long identification { get; set; }
        public string identificationType { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string MaritalStatus { get; set; }
        public string CellPhone { get; set; }

        public Customer()
        {
        }
    }
}
