using eNeatStore.Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace eNeatStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateCustomerSuccedd()
        {
            string name = "Kaoe";
            string email = "batman@dc.com.br";
            string document = "00000000000";
            string phone = "33752244";
            string addres = "Gothan City";

            var customer = new Customer(name, email, document, phone, addres);

            Assert.Fail();
        }
    }
}
