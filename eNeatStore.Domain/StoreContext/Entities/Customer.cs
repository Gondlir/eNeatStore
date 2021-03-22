using System;
namespace eNeatStore.Domain.StoreContext.Entities
{
    public class Customer
    {
        public Customer(string name, string email, string document, string phoneNumber, string addres)
        {
            Name = name;
            Email = email;
            Document = document;
            PhoneNumber = phoneNumber;
            Addres = addres;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Document { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Addres { get; private set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}