using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpediaAutomation.utility
{
    public class BaseTest
        
    {
        public static WebDriverWait wait;
        public static IWebDriver driver;
        public static Actions action;
        public static void InvokeDriver() {
            driver = new ChromeDriver(@"C:\\Users\\sudeeprana\\Desktop\\Selenium\\Drivers\\");
            OpenHomePage();
            wait = new WebDriverWait(driver, new TimeSpan(0,0,5));
            action = new Actions(driver);

        }
        public static void OpenHomePage() {
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://www.expedia.co.in/");
        }

    }
}
