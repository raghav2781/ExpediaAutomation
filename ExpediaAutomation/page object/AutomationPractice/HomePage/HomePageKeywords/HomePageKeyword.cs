using ExpediaAutomation.page_object.AutomationPractice.HomePage.HomePageConstants;
using ExpediaAutomation.utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpediaAutomation.page_object.AutomationPractice.HomePage.HomePageKeywords
{
    class HomePageKeyword:BaseTest
    {
        private static IWebElement SignInButtonOnHomePage{
            get
            {
                return driver.FindElement(By.XPath(HomePageConstant.signInButtonOnHomePage));
            }
        }





        public void ClickOnSignInButtonOnHomePage() {
            SignInButtonOnHomePage.Click();
        }
        
    }
}
