
using ExpediaAutomation.page_object.Login.constant;
using ExpediaAutomation.page_object.Search.Keywords;
using ExpediaAutomation.utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace ExpediaAutomation
{
    [Binding]
    public class FlightSearchForMulti_CitySteps:BaseTest
    {
        
        [Given(@"open expedia Home page")]
        public void GivenOpenExpediaHomePage()
        {
            InvokeDriver();
        }
        
        [Given(@"Select flight button on home page")]
        public void GivenSelectFlightButtonOnHomePage()
        {
            SearchKeywords sk = new SearchKeywords();
            sk.SelectFlightButton();
        }
        
        [Given(@"Select multi-City option")]
        public void GivenSelectMulti_CityOption()
        {
            SearchKeywords sk = new SearchKeywords();
            sk.SelectMulti_CityOption();
        }
        
        [Given(@"Select add one more flight option")]
        public void GivenSelectAddOneMoreFlightOption()
        {
            SearchKeywords sk = new SearchKeywords();
            sk.SelectAddOneMoreFlightOption();
        }
        
        [Given(@"Select travellers")]
        public void GivenSelectTravellers()
        {
            SearchKeywords sk = new SearchKeywords();
            sk.SelectTravellers(4);
        }
        
        [Given(@"select (.*) and (.*) and (.*)")]
        public void GivenSelectAndAnd(string SourceCity1, string DestinationCity1, string Departdate1)
        {
            SearchKeywords sk = new SearchKeywords();
            sk.SelectSourceCity1AndDestinationCity1AndDepartDate1(SourceCity1, DestinationCity1, Departdate1);

        }
        
        [Given(@"select second last (.*) and (.*)")]
        public void GivenSelectAnd(string p0, string p1)
        {
            SearchKeywords sk = new SearchKeywords();
            sk.SelectDestinationCity2AndDepartDate2(p0, p1);
        }
        
        [Given(@"select last (.*) and (.*)")]
        public void GivenSelectLastAnd(string p0, string p1)
        {
            SearchKeywords sk = new SearchKeywords();
            sk.SelectDestinationCity3AndDepartDate3(p0, p1);
        }
        
        [When(@"I press Search button")]
        public void WhenIPressSearchButton()
        {
            SearchKeywords sk = new SearchKeywords();
            sk.PressSearchButon();
        }
        [Then(@"all searched cities (.*) (.*) (.*) should be match with displayed cities")]
        public void ThenAllSearchedCitiesShouldBeMatchWithDisplayedCities(string p0, string p1, string p2)
        {
            SearchKeywords sk = new SearchKeywords();
           // Console.WriteLine(sk.Trip1Text());
            Assert.IsTrue(sk.Trip1Text().Contains(p0) && sk.Trip1Text().Contains(p1));
            Assert.IsTrue(sk.Trip2Text().Contains(p1) && sk.Trip2Text().Contains(p2));
            Assert.IsTrue(sk.Trip3Text().Contains(p0) && sk.Trip3Text().Contains(p2));
        }


        [Then(@"the total price shown for all travellers should be equal to the price shown for one traveller multiply by toal number of travellers")]
        public void ThenTheTotalPriceShownForAllTravellersShouldBeEqualToThePriceShownForOneTravellerMultiplyByToalNumberOfTravellers()
        {
            driver.Close();
            
        }
    }
}
