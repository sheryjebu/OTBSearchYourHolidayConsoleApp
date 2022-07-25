using FluentAssertions;
using OTBHolidaySearchAPP.Models;

namespace HolidaySearchTests;

public class HolidaySearchTests
{
        LoadJson loadJson = new LoadJson();
        HolidaySearchQueries search = new HolidaySearchQueries();
            
        string hotelFileName = "C:/Users/jebum/OneDrive/Documents/OTBSheryShajan/OTBHolidaySearchAPP/Hotels.json";
        string flightFileName = "C:/Users/jebum/OneDrive/Documents/OTBSheryShajan/OTBHolidaySearchAPP/Flight.json";


        [Test]
        public void Search_MAN_to_AGP_Should_Return_EqualfightID_HotelID()
        {
            var hotelList = loadJson.loadHoteldata(hotelFileName);
            var flightList = loadJson.loadFligtdata(flightFileName);
            var expectedResult = new List<HolidaySearchResult>()
                {
                     new HolidaySearchResult
                     {
                       FlightId = 2,
                       HotelId = 9
                     }
                };
       
            var searchResult = search.GetHolidaySearchResults(hotelList, flightList
                                                                ,  "MAN", "AGP"
                                                                , "2023-07-01", 7);
            searchResult.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void Search_MAN_to_AGP_Should_Return_NotEqualfightID_HotelID()
        {
            var hotelList = loadJson.loadHoteldata(hotelFileName);
            var flightList = loadJson.loadFligtdata(flightFileName);
            var expectedResult = new List<HolidaySearchResult>()
                {
                     new HolidaySearchResult
                     {
                       FlightId = 2,
                       HotelId = 0
                     }
                };

            var searchResult = search.GetHolidaySearchResults(hotelList, flightList, "MAN", "AGP"
                                                                , "2023-07-01", 7);
            searchResult.Should().NotBeEquivalentTo(expectedResult);
        }
        [Test]
        public void Search_AnyLondon_to_PMI_Should_Return_EqualfightID_HotelID()
        {
            var hotelList = loadJson.loadHoteldata(hotelFileName);
            var flightList = loadJson.loadFligtdata(flightFileName);
            var expectedResult = new List<HolidaySearchResult>()
                    {
                         new HolidaySearchResult
                         {
                           FlightId = 6,
                           HotelId = 5
                         }
                    };

            var searchResult = search.GetHolidaySearchResults(hotelList, flightList, "Any London Airport", "PMI"
                                                                , "2023-06-15", 10);
            searchResult.Should().BeEquivalentTo(expectedResult);
        }

       [Test]
        public void Search_AnyAirport_to_LPA_Should_Return_EqualfightID_HotelID()
        {
            var hotelList = loadJson.loadHoteldata(hotelFileName);
            var flightList = loadJson.loadFligtdata(flightFileName);
            var expectedResult = new List<HolidaySearchResult>()
                        {
                             new HolidaySearchResult
                             {
                               FlightId = 7,
                               HotelId = 6
                             }
                        };

            var searchResult = search.GetHolidaySearchResults(hotelList, flightList, "Any Airport", "LPA"
                                                                , "2022-11-10", 14);
            searchResult.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void GetActualAirport_For_AnyAirportInput()
        {

            var expectedResult = new[] { "MAN", "LTN", "LGW", "LGW" };

            var searchResult = search.GetActualAirport("Any Airport");
            searchResult.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void GetActualAirport_For_AnyLondonInput()
        {

            var expectedResult = new[] { "LTN", "LGW" };

            var searchResult = search.GetActualAirport("Any London Airport");
            searchResult.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void GetActualAirport_For_ActualInput()
        {

            var expectedResult = new[] { "MAN" };

            var searchResult = search.GetActualAirport("MAN");
            searchResult.Should().BeEquivalentTo(expectedResult);
        }
}



 

