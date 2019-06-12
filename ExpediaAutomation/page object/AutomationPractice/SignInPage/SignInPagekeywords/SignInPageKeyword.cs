using ExpediaAutomation.page_object.AutomationPractice.SignInPage.SignInConstants;
using ExpediaAutomation.utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpediaAutomation.page_object.AutomationPractice.SignInPage.SignInPagekeywords
{
    class SignInPageKeyword:BaseTest
    {
        private IWebElement EmailField {
            get {
                return driver.FindElement(By.XPath(SignInConstant.emailField));

            }

        }
        private IWebElement PasswordField
        {
            get
            {
                return driver.FindElement(By.XPath(SignInConstant.passwordField));

            }
        }
        private IWebElement SignInButton
        {
            get
            {
                return driver.FindElement(By.XPath(SignInConstant.signInButtonOnSignInPage));

            }
        }
        private IWebElement TextWithoutEmailIdAndPassword
        {
            get
            {
                return driver.FindElement(By.XPath(SignInConstant.textWithoutEmailIdAndPassword));

            }
        }
        private IWebElement TextWithoutPassword
        {
            get
            {
                return driver.FindElement(By.XPath(SignInConstant.textWithoutPassword));
            }
        }
        private IWebElement TextWithoutEmail
        {
            get
            {
                return driver.FindElement(By.XPath(SignInConstant.textWithoutEmail));
            }
        }
        private IWebElement TextWithIncorrectCredentials
        {
            get
            {
                return driver.FindElement(By.XPath(SignInConstant.textWithIncorrectCredentials));
            }
        }




        public void SendKeysInEmailField(string emailId)
        {
            EmailField.SendKeys(emailId);
        }
        public void SendKeysInPasswordField(string password)
        {
            PasswordField.SendKeys(password);
        }
        public void ClickOnSignInButtonOnSignInPage()
        {
            SignInButton.Click();
        }
        public string GetTextWithoutEmailAndPassword()
        {
            return TextWithoutEmailIdAndPassword.Text;
        }
        public string GetTextWithoutPassword()
        {
            return TextWithoutPassword.Text;
        }
        public string GetTextWithoutEmail()
        {
            return TextWithoutEmail.Text;
        }
        public string GetTextWithIcorrectCredentials()
        {
            return TextWithIncorrectCredentials.Text;
        }
    }
}
