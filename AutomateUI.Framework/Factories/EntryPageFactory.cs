using AutomateUI.Framework.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateUI.Framework.Factories
{
    public static class EntryPageFactory
    {
        /// <summary>
        /// Creates an entry page.
        /// </summary>
        public static TPage Create<TPage>(IWebDriver driver) where TPage : PomBase, new()
        {
            var page = new TPage()
            {
                Driver = driver
            };

            return page;
        }
    }
}