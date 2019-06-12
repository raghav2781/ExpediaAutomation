using AventStack.ExtentReports;
using ExpediaAutomation.Api.APIKeywords;
using ExpediaAutomation.utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace ExpediaAutomation.Step_Def
{
    [Binding]
    public class APITestingSteps
    {
       
        [When(@"I register a new User with '(.*)' Username and '(.*)' Password")]
        public void WhenIRegisterANewUserWithUsernameAndPassword(string p0, string p1)
        {
            APIKeyword ak = new APIKeyword();
            ak.SuccessfulRegistrationWithCorrectCredenials(p0, p1);
        }
        
        [Then(@"registration is sucessfull")]
        public void ThenRegistrationIsSucessfull()
        {
            //ExtentTest test = ExtentReport.extent.CreateTest("Registration test on 'reqres.in/api/register' with valid username and password");
            APIKeyword ak = new APIKeyword();
            try { Assert.AreEqual(200, ak.ResponseCode());
                //test.Log(Status.Pass, "Registration successfull (Response code matched)");
            }
            catch (AssertFailedException e)
            {
                //test.Log(Status.Fail, "Registration unsuccessfull(Response code not matched)");
                throw e;
            }
        }
        
        [Then(@"token is generated")]
        public void ThenTokenIsGenerated()
        {
            APIKeyword ak = new APIKeyword();
            //ExtentTest test = ExtentReport.extent.CreateTest("Token Availablity on successfull registration Test");
            try { Assert.IsFalse(ak.Tokenvalue() == null);
              //  test.Log(Status.Pass, "Token is available");
            }
            catch (AssertFailedException e) {
                //test.Log(Status.Fail, "Token is not available");
                throw e;
            }
            
        }
        [When(@"I register a new User with '(.*)' username")]
        public void WhenIRegisterANewUserWithUsername(string p0)
        {
            APIKeyword ak = new APIKeyword();
            ak.UnSuccessfulRegistrationWithOnlyUsername(p0);
        }

        [Then(@"registration is unsucessfull")]
        public void ThenRegistrationIsUnsucessfull()
        {
            APIKeyword ak = new APIKeyword();
            //ExtentTest test = ExtentReport.extent.CreateTest("Registration with only username on 'reqres.in/api/register' Test");
            try { Assert.AreEqual(400, ak.ResponseCode1());
              //  test.Log(Status.Pass, "Registration unsuccessful with only username");
            }
            catch (AssertFailedException e) {
                //test.Log(Status.Fail, "Registration successful with only username");
                throw e;
            }
        }

        [Then(@"An error accured")]
        public void ThenAnErrorAccured()
        {
            APIKeyword ak = new APIKeyword();
            //ExtentTest test = ExtentReport.extent.CreateTest("Checking error presence on registration with only username");
            try { Assert.IsFalse(ak.Error() == null);
              //  test.Log(Status.Pass, "error is present");
            }catch(AssertFailedException e)
            {
                //test.Log(Status.Fail, "error is not present");
                throw e;
            }
        }
        [When(@"I click on user list")]
        public void WhenIClickOnUserList()
        {
            APIKeyword ak = new APIKeyword();
            ak.ListUsers();
        }

        [Then(@"users list opened")]
        public void ThenUsersListOpened()
        {
            APIKeyword ak = new APIKeyword();
            //ExtentTest test = ExtentReport.extent.CreateTest("user list on 'reqres.in/api/register' Test");
            try { Assert.AreEqual(200, ak.ResponseCode2());
              //  test.Log(Status.Pass, "Response code matched");
            }
            catch (AssertFailedException e) {
                //test.Log(Status.Fail, "Response code not matched");
                throw e;
            }
        }

        [Then(@"the data of users should be present")]
        public void ThenTheDataOfUsersShouldBePresent()
        {
            APIKeyword ak = new APIKeyword();
            
        }



    }
}
