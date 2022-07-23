using OTBHolidaySearchAPP.Models;

namespace Test;

public class Tests
{
        IList<Hotels> hotelList_0 = new List<Hotels>();
        IList<Hotels> hotelList_1 = new List<Hotels>();
        IList<Hotels> hotelList_2 = new List<Hotels>();

        IList<Flight> flightList_0 = new List<Flight>();
        IList<Flight> flightList_1 = new List<Flight>();
        IList<Flight> flightList_2 = new List<Flight>();



        Hotels hotels = new Hotels();
        Flight flight = new Flight();
        SearchQuery search = new SearchQuery();

        [SetUp]
        public void Setup()
        {

            //Hotel list
            hotels.id = 9;
            hotels.name = "Nh Malaga";
            hotels.arrival_date = "2023-07-01";
            hotels.price_per_night = 83;
            //hotels.local_airports = ["AGP"];
            hotels.nights = 7;
            hotelList_0.Add(hotels);

            hotels.id = 5;
            hotels.name = "Sol Katmandu Park & Resort";
            hotels.arrival_date = "2023-06-15";
            hotels.price_per_night = 60;
            //hotels.local_airports = ["AGP"];
            hotels.nights = 10;
            hotelList_1.Add(hotels);

            hotels.id = 6;
            hotels.name = "Club Maspalomas Suites and Spa";
            hotels.arrival_date = "2022-11-10";
            hotels.price_per_night = 75;
            //hotels.local_airports = ["AGP"];
            hotels.nights = 14;
            hotelList_2.Add(hotels);

            //Flight list
            flight.id = 2;
            flight.airline = "Oceanic Airlines";
            flight.departure_date = "2023-07-01";
            flight.from = "MAN";
            flight.to = "AGP";
            flight.price = 245;
            flightList_0.Add(flight);

            flight.id = 6;
            flight.airline = "Fresh Airways";
            flight.departure_date = "2023-06-15";
            flight.from = "LGW";
            flight.to = "PMI";
            flight.price = 75;
            flightList_1.Add(flight);


            flight.id = 7;
            flight.airline = "Trans American Airlines";
            flight.departure_date = "2022-11-10";
            flight.from = "MAN";
            flight.to = "LPA";
            flight.price = 125;
            flightList_2.Add(flight);



        }

        [Test]
        public void SearchMANtoAGP_Should_Return_fightID_HotelID()
        {

            string From = "MAN";
            string To = "AGP";
            string DepartDate = "2023/07/01";
            int Duration = 7;

            var expectedResult = new List<HolidaySearchResult>()
            {
                 new HolidaySearchResult
                 {
                   FlightId = 2,
                   HotelId = 9
                 }
            };

            var result = search.HolidaySearch(hotelList_0, flightList_0
                                            , From, To, DepartDate
                                            , Duration
                                            );


            Assert.That(result, Is.EqualTo(expectedResult));

        }

    }