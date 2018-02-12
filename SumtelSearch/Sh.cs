using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SumtelSearch
{
    public class Sh
    {
        public IWebDriver driver { get; set; }
        public int Internet { get; set; }
        public Sh(IWebDriver driver)

        {
            this.driver = driver;
        }

        public void Action()
        {
            TimeSpan timeout = new TimeSpan(00, 00, 10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://itech:itech@voronezh.sumtel.itech-test.ru");

            var search = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.Name("q")));
            search.SendKeys("Интернет");
            search.Submit();
            var root = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("sr-item")));
            Internet = Convert.ToInt32(root.Count);
        }
    }
}