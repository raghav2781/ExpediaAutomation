using AventStack.ExtentReports.Gherkin.Model;
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
    [BeforeFeature]
    public static void BeforeEveryFeature()
    {
        ExtentReport.featureName = ExtentReport.extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
    }
    [BeforeScenario]
    public static void BeforeEveryScenario() {
        ExtentReport.scenerio = ExtentReport.featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
    }
    [AfterStep]
    public static void AfterEveryStep() {
        

            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();







        if (ScenarioContext.Current.TestError != null)

        {

            switch (stepType)

            {

                case "Given":

                    ExtentReport.scenerio.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);

                    break;

                case "When":

                    ExtentReport.scenerio.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message); ;

                    break;

                case "Then":

                    ExtentReport.scenerio.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message); ;

                    break;

                case "And":

                    ExtentReport.scenerio.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message); ;

                    break;

            }





        }

        else if (ScenarioContext.Current.TestError == null)

        {

            switch (stepType)

            {

                case "Given":

                    ExtentReport.scenerio.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);

                    break;

                case "When":

                    ExtentReport.scenerio.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);

                    break;

                case "Then":

                    ExtentReport.scenerio.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);

                    break;

                case "And":

                    ExtentReport.scenerio.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);

                    break;

            }

        }
    }
    [AfterScenario]
    public static void AfterEveryScenario()
    {
        if (driver != null)
        {
            driver.Quit();
        }
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