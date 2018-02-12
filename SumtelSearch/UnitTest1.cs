using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SumtelSearch
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver driver;

        //[OneTimeSetUp] // вызывается перед началом запуска всех тестов
        //public void OneTimeSetUp()
        //{

        //}

        //[OneTimeTearDown] //вызывается после завершения всех тестов
        //public void OneTimeTearDown()
        //{

        //}

        [SetUp] // вызывается перед каждым тестом
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown] // вызывается после каждого теста
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Search()
        {


            Sh avto = new Sh(driver);
            avto.Action();

            Assert.AreNotEqual(avto.Internet, 0);
        }
    }
}
