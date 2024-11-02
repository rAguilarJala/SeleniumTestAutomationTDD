using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomateUI
{
    public class Class1
    {
        [Test]
        public void Lab()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.saucedemo.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();

            var usernamefield = driver.FindElement(By.CssSelector("#user-name"));
            usernamefield.SendKeys("standard_user");

            var passwordField = driver.FindElement(By.CssSelector("#password"));
            passwordField.SendKeys("secret_sauce");

            var loginButton = driver.FindElement(By.CssSelector("#login-button"));
            loginButton.Click();

            var titleElements = driver.FindElements(By.CssSelector(".inventory_item_name"));
            var titles = titleElements.Select(x =>  x.Text).ToList();

            ClassicAssert.Contains("Sauce Labs Fleece Jacket", titles);


        }
    }
}
