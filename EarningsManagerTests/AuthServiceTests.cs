using NUnit.Framework;
using EarningsManagerAPI.Services;

namespace EarningsManagerTests
{
    public class AuthServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Иванов")]
        [TestCase("Петров")]
        [TestCase("Сидоров")]
        public void Login_ShouldResultTrue(string lastName)
        {
            // arrange
            

            var service = new AuthService();

            // act

            var result = service.Login(lastName);

            // assert

            Assert.IsTrue(result);
        }

        [Test]
        public void Login_ShouldResultTrue()
        {
            // arrange
            var lastName = "Иванов";

            var service = new AuthService();

            // act

            var result = service.Login(lastName);
            result = service.Login(lastName);

            // assert

            Assert.IsTrue(result);
        }


        [TestCase("")]
        [TestCase(null)]
        
        public void Login_ShouldResultFalse(string lastName)
        {
            // arrange

            //var lastName = "";

            var service = new AuthService();

            // act

            var result = service.Login(lastName);

            // assert

            Assert.IsFalse(result);
        }
    }
}