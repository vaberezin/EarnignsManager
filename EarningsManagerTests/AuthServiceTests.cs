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

        [TestCase("Иванов")]
        [TestCase(null)]
        [TestCase("TestUser")]
        
        public void Login_ShouldResultFalse(string lastName)
        {
            // arrange

            var lastName = "";

            var service = new AuthService();

            // act

            var result = service.Login(lastName);

            // assert

            Assert.IsFalse(result);
        }
    }
}