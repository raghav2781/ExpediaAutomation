using ExpediaAutomation.page_object.Login.constant;
using ExpediaAutomation.utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExpediaAutomation.page_object.Search.Keywords
{
    public class SearchKeywords : BaseTest
    {
        private IWebElement FlightButton
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.flightButton));
            }
        }
        private IWebElement MultiCityButton {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.multiCityButton));
            }
        }
        private IWebElement FlyingFrom1
        {
            get {
                return driver.FindElement(By.XPath(SearchConstant.flyingFrom1));
            }
        }
        private IWebElement FlyingTo1
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.flyingTo1));
            }
        }
        private IWebElement DepartDate1
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.departDate1));
            }
        }
        private IWebElement FlyingFrom2
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.flyingFrom2));
            }
        }
        private IWebElement FlyingTo2
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.flyingTo2));
            }
        }
        private IWebElement DepartDate2
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.departDate2));
            }
        }
        private IWebElement AddNewFlight
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.addNewFlight));
            }
        }
        private IWebElement FlyingFrom3
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.flyingFrom3));
            }
        }
        private IWebElement FlyingTo3
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.flyingTo3));
            }
        }
        private IWebElement DepartDate3
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.departDate3));
            }
        }
        private IWebElement SeachButton
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.searchButton));
            }
        }
        private IWebElement City1Source
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.city1source));
            }
        }
        private IWebElement City1Dest
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.city1dest));
            }
        }

        public void SelectFlightButton()
        {
            FlightButton.Click();
        }

        public void SelectMulti_CityOption()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(MultiCityButton)).Click();
            MultiCityButton.Click();
        }
        public void SelectAddOneMoreFlightOption()
        {
            wait.Until(ExpectedConditions.TextToBePresentInElement(AddNewFlight, "Add another flight"));
            action.MoveToElement(AddNewFlight).Build().Perform();
            AddNewFlight.Click();
        }
        public void SelectTravellers()
        {
            
        }
        public void SelectSourceCity1AndDestinationCity1AndDepartDate1(string source,string dest, string date)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(FlyingFrom1));
            FlyingFrom1.Click();
            FlyingFrom1.SendKeys(source);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SearchConstant.city1source)));
            City1Source.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(FlyingTo1));
            FlyingTo1.Click();
            FlyingTo1.SendKeys(dest);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SearchConstant.city1dest)));
            City1Dest.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(DepartDate1));
            DepartDate1.Click();
            DepartDate1.SendKeys(date);

        }
        public void SelectDestinationCity2AndDepartDate2(string dest, string date)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(FlyingFrom1));
            FlyingFrom1.Click();
            FlyingTo2.Click();
            FlyingTo2.SendKeys(dest);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SearchConstant.city1dest)));
            City1Dest.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(DepartDate2));
            DepartDate2.Click();
            DepartDate2.SendKeys(date);

        }
        public void SelectDestinationCity3AndDepartDate3(string dest, string date)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(FlyingTo3));
            FlyingTo3.Click();
            FlyingTo3.SendKeys(dest);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SearchConstant.city1source)));
            City1Source.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(DepartDate3));
            DepartDate3.Click();
            DepartDate3.SendKeys(date);

        }
        public void PressSearchButon()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(SeachButton));
            SeachButton.Click();
            driver.Close();
        }




        public void SelectFlightForMultiCity(string sourceCity1,string destinationCity1, string date1,
                                             string destinationCity2, string date2, 
                                             string destinationCity3, string date3)
        {
            InvokeDriver();

            FlightButton.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(MultiCityButton)).Click();
            MultiCityButton.Click();
            wait.Until(ExpectedConditions.TextToBePresentInElement(AddNewFlight, "Add another flight"));
            action.MoveToElement(AddNewFlight).Build().Perform();
            AddNewFlight.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(FlyingFrom1));


            FlyingFrom1.Click();
            FlyingFrom1.SendKeys(sourceCity1);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SearchConstant.city1source)));
            City1Source.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(FlyingTo1));
            FlyingTo1.Click();
            FlyingTo1.SendKeys(destinationCity1);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SearchConstant.city1dest)));
            City1Dest.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(DepartDate1));
            DepartDate1.Click();
            DepartDate1.SendKeys(date1);
            wait.Until(ExpectedConditions.ElementToBeClickable(FlyingFrom1));
            FlyingFrom1.Click();
           

            FlyingTo2.Click();
            FlyingTo2.SendKeys(destinationCity2);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SearchConstant.city1dest)));
            City1Dest.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(DepartDate2));
            DepartDate2.Click();
            DepartDate2.SendKeys(date2);
            wait.Until(ExpectedConditions.ElementToBeClickable(FlyingTo3));

            FlyingTo3.Click();
            FlyingTo3.SendKeys(destinationCity3);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SearchConstant.city1source)));
            City1Source.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(DepartDate3));
            DepartDate3.Click();
            DepartDate3.SendKeys(date3);

            wait.Until(ExpectedConditions.ElementToBeClickable(SeachButton));
            SeachButton.Click();
            driver.Close();


        }

        
    }
}
