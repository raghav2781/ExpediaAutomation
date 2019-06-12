using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpediaAutomation.utility
{
    class ExtentReport
    {
        public static ExtentReports extent;
        public static ExtentTest featureName;

        public static ExtentTest scenerio;
        public static void ExtentReportInitiating()
        {

            ExtentHtmlReporter reporter = new ExtentHtmlReporter(
                    "C:\\Users\\sudeeprana\\source\\repos\\ExpediaAutomation\\ExpediaAutomation\\Reports\\report.html");
            extent = new ExtentReports();
            extent.AttachReporter(reporter);
        }
    }
}
