using ExpediaAutomation.utility;
using TechTalk.SpecFlow;

[Binding]
public sealed class TestRunSingleBrowserHooks:BaseTest
{
    [BeforeTestRun]
    public static void BeforeTestRun()
    {
            
            ExtentReport.ExtentReportInitiating();
        
    }
    [AfterTestRun]
    public static void AfterTestRun()
    {
        if (driver != null)
        {

            driver.Quit();

            
        }
        ExtentReport.extent.Flush();


    }
}