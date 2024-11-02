using NUnit.Framework.Legacy;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomateUI.Framework.Extensions;
using System.Runtime.CompilerServices;
using OpenQA.Selenium.DevTools.V128.PWA;
using AutomateUI.Framework.Factories;
using AutomateUI.Framework.PageObjects.EntryPages.Login;
using AutomateUI.Framework.PageObjects.EntryPages.Inventory;
using OpenQA.Selenium.DevTools.V128.DOM;
using FluentAssertions;

namespace AutomateUI
{
    internal class SeleniumTests
    {
        [Test]
        public void Lab()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.saucedemo.com/";
            driver.Manage().Window.Maximize();

            var usernamefield = driver.GetElement("#user-name");
            usernamefield.SendKeys("standard_user");

            var passwordField = driver.GetElement("#password");
            passwordField.SendKeys("secret_sauce");

            var loginButton = driver.GetElement("#login-button");
            loginButton.Click();

            var titleElements = driver.GetElements(".inventory_item_name");
            var titles = titleElements.Select(x => x.Text).ToList();

            ClassicAssert.Contains("Sauce Labs Fleece Jacket", titles);


        }


        [Test]
        public void SouceLabDemo_v2_POM()
        {
            //Launch browser
            IWebDriver driver = new ChromeDriver();

            //Navigate to souce Lab
            driver.Url = "https://www.saucedemo.com/";
            driver.Manage().Window.Maximize();

            //Log in
             var loginPage = EntryPageFactory.Create<LoginPage>(driver);
                 loginPage.Username.SetValue("standard_user");
            loginPage.Password.SetValue("secret_sauce");
            loginPage.LoginButton.Click();

            //Get product names
            var inventoryPage = EntryPageFactory.Create<InventoryPage>(driver);
            var productCards = inventoryPage.ProductCards.Select(x => x.Title).ToList();

            //verify backpack is preset

            productCards.Should().Contain("Sauce Labs Backpack");


        }
    }
}
