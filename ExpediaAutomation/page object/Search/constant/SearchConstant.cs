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
        public static string multiCityButton= "/html[1]/body[1]/meso-native-marquee[1]/section[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/div[2]/section[1]/form[1]/fieldset[1]/div[1]/div[3]/label[1]";
        public static string flyingFrom1 = "/html[1]/body[1]/meso-native-marquee[1]/section[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/div[2]/section[1]/form[1]/div[3]/div[1]/div[1]/div[1]/label[1]/input[1]";
        public static string flyingTo1 = "/html[1]/body[1]/meso-native-marquee[1]/section[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/div[2]/section[1]/form[1]/div[3]/div[2]/div[1]/div[1]/label[1]/input[1]";
        public static string departDate1 = "/html[1]/body[1]/meso-native-marquee[1]/section[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/div[2]/section[1]/form[1]/fieldset[2]/div[1]/div[1]/div[1]/label[1]/input[1]";
       
        public static string flyingFrom2 = "//input[@id='flight-2-origin-hp-flight']";
        public static string flyingTo2 = "/html[1]/body[1]/meso-native-marquee[1]/section[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/div[2]/section[1]/form[1]/div[4]/div[1]/fieldset[1]/div[1]/div[2]/div[1]/div[1]/label[1]/input[1]";
        public static string departDate2 = "//html[1]/body[1]/meso-native-marquee[1]/section[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/div[2]/section[1]/form[1]/div[4]/div[1]/fieldset[1]/div[1]/div[3]/div[1]/label[1]/input[1]";
        public static string addNewFlight = "//a[@class='secondary gcw-add-fields']";
        public static string flyingFrom3 = "//input[@id='flight-3-origin-hp-flight']";
        public static string flyingTo3 = "/html[1]/body[1]/meso-native-marquee[1]/section[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/div[2]/section[1]/form[1]/div[4]/div[1]/fieldset[2]/div[1]/div[2]/div[1]/div[1]/label[1]/input[1]";
        public static string departDate3 = "/html[1]/body[1]/meso-native-marquee[1]/section[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/div[2]/section[1]/form[1]/div[4]/div[1]/fieldset[2]/div[1]/div[3]/div[1]/label[1]/input[1]";
        public static string searchButton = "/html[1]/body[1]/meso-native-marquee[1]/section[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/div[2]/section[1]/form[1]/div[8]/label[1]/button[1]";



        public static string city1source = "//div[@class='multiLineDisplay']";
        public static string city1dest = "//a[@id='aria-option-0']//div[1]";
        public static string travellersButton= "//div[@class='menu-bar gcw-travel-selector-wrapper']//button[@class='trigger-utility menu-trigger btn-utility btn-secondary dropdown-toggle theme-standard pin-left menu-arrow gcw-component gcw-traveler-amount-select gcw-component-initialized']";
        public static string plus = "/html[1]/body[1]/meso-native-marquee[1]/section[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]/div[2]/section[1]/form[1]/fieldset[2]/div[1]/div[4]/div[1]/div[1]/ul[1]/li[1]/div[1]/div[1]/div[1]/div[1]/div[4]/button[1]/span[1]/*";
        public static string trip1CitiesText = "//dd[1]";
        public static string trip2CitiesText = "//dd[2]";
        public static string trip3CitiesText = "//dd[3]";

    }

}
    

