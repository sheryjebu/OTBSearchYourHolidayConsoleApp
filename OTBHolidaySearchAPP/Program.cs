// See https://aka.ms/new-console-template for more information/
// OTB Holiday Search program //
using OTBHolidaySearchAPP.Models;

class Program
{
    static void Main()
    {
        string? nights;
        string flightFileName = "C:/Users/jebum/OneDrive/Documents/OTBSheryShajan/OTBHolidaySearchAPP/Flight.json";
        string hotelFileName = "C:/Users/jebum/OneDrive/Documents/OTBSheryShajan/OTBHolidaySearchAPP/Hotels.json";

        LoadJson loadJson = new LoadJson();
        var hotelList = loadJson.loadHoteldata(hotelFileName);
        var flightList = loadJson.loadFligtdata(flightFileName);


        //Get user input
        UserInput   userInput = new UserInput();
        Console.WriteLine("Enter Departing From : ");
        userInput.DepartFrom = Console.ReadLine();

        Console.WriteLine("Enter Traveling To : ");
        userInput.TravlTo = Console.ReadLine();

        Console.WriteLine("Enter Departure Date (ex: YYYY-MM-DD) :");
        userInput.DepartDate = Console.ReadLine();

        Console.WriteLine("Enter Duration (Nights) :");
        nights = Console.ReadLine();
        userInput.Nights = Convert.ToInt32(nights);

        HolidaySearchQueries searchQuery = new HolidaySearchQueries();
        List<HolidaySearchResult> results = searchQuery.GetHolidaySearchResults(hotelList, flightList,userInput.DepartFrom!
                                                                                        , userInput.TravlTo!
                                                                                        , userInput.DepartDate!
                                                                                        , userInput.Nights);
    }
}