using eNeatStore.Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
namespace eNeatStore.Tests
{
    [TestClass]
    public class CustomerTests
    {
        private Customer _customer;
        private Order _order;
        private Product _tshirt;
        public CustomerTests()
        {
            string name = "Kaoe";
            string email = "batman@dc.com.br";
            string document = "00000000000";
            string phone = "33752244";
            string addres = "Gothan City";
            _customer = new Customer(name, email, document, phone, addres);
            _order = new Order(_customer);
            // _tshirt = new Product("T - Shirt", "T - Shirt", "tshirt.jpg", 35M, 10);
        }

        [TestMethod]
        public void CreateOrderSuccedd()
        {

            //Assert.AreEqual(true, _order.Number);
        }
    }
}
