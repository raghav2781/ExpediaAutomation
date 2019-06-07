using ExpediaAutomation.utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpediaAutomation.page_object.Login.constant
{
    public class SearchConstant:BaseTest
    {
      
        public static string flightButton = "//a[@id='primary-header-flight']";
        public static string multiCityButton= "//label[@id='flight-type-multi-dest-label-flp']";
        public static string flyingFrom1 = "//input[@id='flight-origin-flp']";
        public static string flyingTo1 = "//input[@id='flight-destination-flp' or @id='flight-destination-hp-flight']";
        public static string departDate1 = "//input[@id='flight-departing-single-flp']";
       
       // public static string flyingFrom2 = "//input[@id='flight-2-origin-hp-flight']";
        public static string flyingTo2 = "//input[@id='flight-2-destination-flp']";
        public static string departDate2 = "//input[@id='flight-2-departing-flp']";
        public static string addNewFlight = "//a[@class='secondary gcw-add-fields']";
        public static string flyingFrom3 = "//input[@id='flight-3-origin-hp-flight']";
        public static string flyingTo3 = "//input[@id='flight-3-destination-flp']";
        public static string departDate3 = "//input[@id='flight-3-departing-flp']";
        public static string searchButton = "//div[@class='cols-nested ab25184-submit']//label[@class='col search-btn-col']//button[@class='btn-primary btn-action gcw-submit']";



        public static string city1source = "//div[@class='multiLineDisplay']";
        public static string city1dest = "//a[@id='aria-option-0']//div[1]";
        public static string travellersButton= "//div[@class='menu-bar gcw-travel-selector-wrapper']//button[@class='trigger-utility menu-trigger btn-utility btn-secondary dropdown-toggle theme-standard pin-left menu-arrow gcw-component gcw-traveler-amount-select gcw-component-initialized']";
        public static string plus = "/html[1]/body[1]/meso-native-marquee[1]/section[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/div[2]/section[1]/form[1]/fieldset[2]/div[1]/div[4]/div[1]/div[1]/ul[1]/li[1]/div[1]/div[1]/div[1]/div[1]/div[4]/button[1]/span[1]/*";
        public static string trip1CitiesText = "//dd[1]";
        public static string trip2CitiesText = "//dd[2]";
        public static string trip3CitiesText = "//dd[3]";
        public static string singleAmount = "//li[1]//span[@class='full-bold no-wrap']";
        public static string totalAmount = "//span[@class='packagePriceTotal']";
        public static string selectButton = "//button[@data-leg0-natural-key='da204c05d0f932aade99dc5e7ab5fb6e' and @data-leg2-natural-key='15760aa1b716bd812ce45cbea8e52e31' and @data-leg1-natural-key='1add4f447240d55133cd243b5ce4dc6b']";


    }

}
    

