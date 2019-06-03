
Feature: Flight Search for multi-city


Scenario Outline: test for multi-city flight
       Given open expedia Home page
       And Select flight button on home page
	   And Select multi-City option
	   And Select add one more flight option
	   And Select travellers
	   And select <SourceCity1> and <DestinationCity1> and <Departdate1>
	   And select second last <DestinationCity2> and <Departdate2>
	   And select last <DestinationCity3> and <Departdate3>
       When I press Search button
       Then the total price shown for all travellers should be equal to the price shown for one traveller multiply by toal number of travellers 


Examples: 
	| SourceCity1 | DestinationCity1 | Departdate1  | DestinationCity2 | Departdate2  | DestinationCity3 | Departdate3  |
	| luqa		  | london           | 03/06/2019   | rome             | 06/06/2019   | luqa             |   09/06/2019 |
