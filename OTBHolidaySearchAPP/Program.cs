// See https://aka.ms/new-console-template for more information/

/* Class1. to store Fight objects file path as environment variable
 * Class2. to store Hotel objects file path as environment variable
 * Class Search - with search() based on user inputs/ output()
 * Class ToLoadJson data
 */

using OTBHolidaySearchAPP.Models;

class Program
{
    static void Main()
    {
        string hotelFileName = "/Users/sheryjebu/Projects/OTBHolidaySearchAPP/OTBHolidaySearchAPP/Hotels.json";
        string flightFileName = "/Users/sheryjebu/Projects/OTBHolidaySearchAPP/OTBHolidaySearchAPP/Flight.json";
        string? From = null; 
        string? To = null;
        string? DepartDate = null;
        int Duration = 0;


        LoadJson loadJson = new LoadJson(hotelFileName,flightFileName);
        var hotelList = loadJson.loadHoteldata(hotelFileName);
        var flightList = loadJson.loadFligtdata(flightFileName);





        SearchQuery searchQuery = new SearchQuery();
        List< HolidaySearchResult> results = searchQuery.HolidaySearch(hotelList, flightList
                                                  , From!, To!
                                                  , DepartDate!, Duration
                                                  );

        /*foreach (var result in results)
        {
            Console.WriteLine("FlightID : {0}", result.FlightId);
           // Console.WriteLine("AirLine : {0}", result.Airline);
            Console.WriteLine("HotelId : {0}", result.HotelId);
            //Console.WriteLine("To : {0}", result.To);

        }*/

    }
}