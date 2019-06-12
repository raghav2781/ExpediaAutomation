using AventStack.ExtentReports;
using ExpediaAutomation.page_object.AutomationPractice.HomePage.HomePageKeywords;
using ExpediaAutomation.page_object.AutomationPractice.SignInPage.SignInPagekeywords;
using ExpediaAutomation.utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using log4net;

namespace ExpediaAutomation.Step_Def
{
    [Binding]
    public class SignInTestsOnAutomationpratice_ComSteps : BaseTest
    {
        //public static readonly ILog logger = LogManager.GetLogger("logger");

        [Given(@"Open automation HomePage")]
        public void GivenOpenAutomationHomePage()
        {
            Log4net.Log4Net();
            Log4net.logger.Info("invoking driver");
            InvokeDriver();
            OpenHomePageOfAutomationPractice();
        }

        [When(@"Click on Sign In button on HomePage")]
        public void WhenClickOnSignInButtonOnHomePage()
        {
            HomePageKeyword hk = new HomePageKeyword();
            hk.ClickOnSignInButtonOnHomePage();
        }

        [When(@"Leave Email and Password field empty and click on SignIn Button on SignInPage")]
        public void WhenLeaveEmailAndPasswordFieldEmptyAndClickOnSignInButtonOnSignInPage()
        {
            SignInPageKeyword sk = new SignInPageKeyword();
            sk.ClickOnSignInButtonOnSignInPage();
        }

        [Then(@"The correct message should be display")]
        public void ThenTheCorrectMessageShouldBeDisplay()
        {
            SignInPageKeyword sk = new SignInPageKeyword();
            ExtentTest test = ExtentReport.extent.CreateTest("login without no credential");
            try { Assert.AreEqual("An email address required.", sk.GetTextWithoutEmailAndPassword());
                test.Log(Status.Pass, "not able to login without Email id");
                test.Info(sk.GetTextWithoutEmailAndPassword());
            }
            catch(AssertFailedException e) {
                test.Log(Status.Fail, "able to login without Email id");
                throw e;
            }
            
        }
        [Then(@"Close the chrome")]
        public void ThenCloseTheChrome()
        {
            driver.Quit();
        }

        [When(@"Enter Email and leave Password field empty and click on SignIn Button on SignInPage")]
        public void WhenEnterEmailAndLeavePasswordFieldEmptyAndClickOnSignInButtonOnSignInPage()
        {
            SignInPageKeyword sk = new SignInPageKeyword();
            sk.SendKeysInEmailField("xyz@gamil.com");
            sk.ClickOnSignInButtonOnSignInPage();
        }

        [Then(@"The correct message should be display without password")]
        public void ThenTheCorrectMessageShouldBeDisplayWithoutPassword()
        {
            SignInPageKeyword sk = new SignInPageKeyword();
            ExtentTest test = ExtentReport.extent.CreateTest("login without password");
            try { Assert.AreEqual("Password is required.", sk.GetTextWithoutPassword());
                test.Log(Status.Pass, "not able to login without password");
                test.Info(sk.GetTextWithoutPassword());
            } catch(AssertFailedException e)
            {
                test.Log(Status.Fail, "able to login without password");
                throw e;
            }
        }

        [When(@"leave Email empty and enter Password and click on SignIn Button on SignInPage")]
        public void WhenLeaveEmailEmptyAndEnterPasswordAndClickOnSignInButtonOnSignInPage()
        {
            SignInPageKeyword sk = new SignInPageKeyword();
            sk.SendKeysInPasswordField("gscxgashg");
            sk.ClickOnSignInButtonOnSignInPage();

        }

        [Then(@"The correct message should be display without email")]
        public void ThenTheCorrectMessageShouldBeDisplayWithoutEmail()
        {
            SignInPageKeyword sk = new SignInPageKeyword();
            ExtentTest test = ExtentReport.extent.CreateTest("login without email");
            try { Assert.AreEqual("An email address required.", sk.GetTextWithoutEmail());
                test.Log(Status.Pass, "not able to login");
                test.Info(sk.GetTextWithoutEmail());
            }catch(AssertFailedException e)
            {
                test.Log(Status.Fail, "able to login");
                throw e;

            }

        }
        [When(@"enter Incorrect EmailId and Password and click on SignIn Button on SignInPage")]
        public void WhenEnterIncorrectEmailIdAndPasswordAndClickOnSignInButtonOnSignInPage()
        {
            SignInPageKeyword sk = new SignInPageKeyword();
            sk.SendKeysInEmailField("xyz@gmail.com");
            sk.SendKeysInPasswordField("gscxgashg");
            sk.ClickOnSignInButtonOnSignInPage();
        }

        [Then(@"The correct message should be display with incorrect credentials")]
        public void ThenTheCorrectMessageShouldBeDisplayWithIncorrectCredentials()
        {
            SignInPageKeyword sk = new SignInPageKeyword();
            ExtentTest test = ExtentReport.extent.CreateTest("Login With ivalid credential on AutomationPractice.com");

            try
            {
                Assert.AreEqual("Authentication failed.", sk.GetTextWithIcorrectCredentials());
                test.Log(Status.Pass, "not able to login");
                test.Info(sk.GetTextWithIcorrectCredentials());
            } catch (AssertFailedException e) {
                test.Log(Status.Fail, "able to login");
                throw e;
            }
            }
        }





    }

