using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpediaAutomation.page_object.AutomationPractice.SignInPage.SignInConstants
{
    public class SignInConstant
    {
        public static string emailField = "//input[@id='email']";
        public static string passwordField = "//input[@id='passwd']";
        public static string signInButtonOnSignInPage = "//p[@class='submit']//span[1]";
        public static string textWithoutEmailIdAndPassword = "//li[contains(text(),'An email address required.')]";
        public static string textWithoutPassword = "//li[contains(text(),'Password is required.')]";
        public static string textWithoutEmail = "//li[contains(text(),'An email address required.')]";
        public static string textWithIncorrectCredentials = "//li[contains(text(),'Authentication failed.')]";

    }
}
