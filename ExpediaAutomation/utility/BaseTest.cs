using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ExpediaAutomation.utility
{
    public class BaseTest
        
    {
        public static WebDriverWait wait;
        public static IWebDriver driver;
        public static Actions action;
        public static void InvokeDriver() {
            driver = new ChromeDriver(@"C:\\Users\\sudeeprana\\Desktop\\Selenium\\Drivers\\");
            //OpenHomePage();
            wait = new WebDriverWait(driver, new TimeSpan(0,0,10));
            action = new Actions(driver);

        }
        public static void OpenHomePage() {
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.expedia.co.in/");
        }
        public static void OpenHomePageOfAutomationPractice() {
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("http://automationpractice.com");

        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            if (driver != null)
            {

                driver.Quit();

                ExtentReport.extent.Flush();
            }

        }
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            driver.Navigate().GoToUrl("google.com");
            ExtentReport.ExtentReportInitiating();
        }

    }
}
