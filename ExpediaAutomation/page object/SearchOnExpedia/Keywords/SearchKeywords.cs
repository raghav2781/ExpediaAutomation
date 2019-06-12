using ExpediaAutomation.page_object.Login.constant;
using ExpediaAutomation.utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;

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
        // private IWebElement FlyingFrom2
        //{
        //  get
        //{
        //    return driver.FindElement(By.XPath(SearchConstant.flyingFrom2));
        //}
        //}
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
        private IWebElement TravellersButton {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.travellersButton));
            }
        }
        private IWebElement PlusButton
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.plus));
            }
        }
        private IWebElement Trip1CityText
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.trip1CitiesText));
            }
        }
        private IWebElement Trip2CityText
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.trip2CitiesText));
            }
        }
        private IWebElement Trip3CityText
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.trip3CitiesText));
            }
        }
        private IWebElement SingleAmount
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.singleAmount));
            }
        }
        private IWebElement TotalAmount
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.totalAmount));
            }
        }
        private IWebElement SelectButton
        {
            get
            {
                return driver.FindElement(By.XPath(SearchConstant.selectButton));
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
        public void SelectSourceCity1AndDestinationCity1AndDepartDate1(string source, string dest, string date)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(FlyingFrom1));
            FlyingFrom1.Click();
            FlyingFrom1.SendKeys(source);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SearchConstant.city1source)));
            City1Source.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SearchConstant.flyingTo1)));
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
            //driver.Close();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SearchConstant.trip1CitiesText)));
        }

        public void SelectTravellers(int travNo) {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SearchConstant.travellersButton)));
            TravellersButton.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SearchConstant.plus)));
            for (int i = 1; i < travNo; i++)
            {
                PlusButton.Click();
            }
        }
        public string Trip1Text() {
            return Trip1CityText.Text;
        }
        public string Trip2Text()
        {
            return Trip2CityText.Text;
        }
        public string Trip3Text()
        {
            return Trip3CityText.Text;
        }

        public string TotalAmountOnMultiply()
        {
            string singleAmount = SingleAmount.Text;
            string sAmt = singleAmount.Substring(2);
            string sAmt1 = sAmt.Replace(",", "");
            float sAmt2 = float.Parse(sAmt1);
            return (4 * sAmt2).ToString();

        }
        public string TotalAmountOnLastPage()
        {
            string parent = driver.CurrentWindowHandle;
            List<string> allWindow = driver.WindowHandles.ToList();
            foreach (string child in allWindow)
            {
                if (!parent.Equals(child))
                {
                    driver.SwitchTo().Window(child);
                }

            }
            string totalAmount = TotalAmount.Text;
            string tAmt = totalAmount.Substring(2);
            string tAmt1 = tAmt.Replace(",", "");
            float tAmt2 = float.Parse(tAmt1);
            driver.Close();
            driver.SwitchTo().Window(parent);
            return tAmt2.ToString();

        }
        public void SelectButtonClick()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SearchConstant.selectButton)));
            SelectButton.Click();
        } 

    }
}
