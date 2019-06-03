using ExpediaAutomation.page_object.Search.Keywords;
using ExpediaAutomation.utility;
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
        
        [Then(@"the total price shown for all travellers should be equal to the price shown for one traveller multiply by toal number of travellers")]
        public void ThenTheTotalPriceShownForAllTravellersShouldBeEqualToThePriceShownForOneTravellerMultiplyByToalNumberOfTravellers()
        {
            
        }
    }
}
