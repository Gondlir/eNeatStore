using System;
namespace eNeatStore.Domain.StoreContext.Entities
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email {get; set;}
        public string Document {get; set;}
        public string PhoneNumber { get; set; }
        public string Addres {get; set;}

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}