﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateUI
{
    internal class EbayTests
    {
        [Test]
        public void EbayProductPriceIsDisplayed()
        {
            // Launch browser
            var driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // Navigate to Ebay
            driver.Url = "https://www.ebay.com";

            // Search for item
            var searchBar = driver.FindElement(By.CssSelector("input#gh-ac"));
            searchBar.SendKeys("pokemon cards" + Keys.Enter);

            // Click on a product
            var firstProduct = driver.FindElement(By.CssSelector("#srp-river-results .s-item__title"));
            firstProduct.Click();

            // switch tabs
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            // Verify price
            var price = driver.FindElement(By.CssSelector("[data-testid='x-price-primary']")).Text;
        }
    }
}
