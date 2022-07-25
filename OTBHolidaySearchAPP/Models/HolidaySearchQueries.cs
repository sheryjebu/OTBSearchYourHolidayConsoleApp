using OTBHolidaySearchAPP.Enum;
using OTBHolidaySearchAPP.Exceptions;

namespace OTBHolidaySearchAPP.Models
{
    public class HolidaySearchQueries
    {      
       List<HolidaySearchResult> HolidayResultList = new List<HolidaySearchResult>();
       
        public string[] GetActualAirport(string DepartAirport)
        {
            if (DepartAirport == "Any London Airport")
            {
                var FromAirports = new[] { "LTN", "LGW" };
                return FromAirports;
            }
            else if (DepartAirport == "Any Airport")
            {
                var FromAirports = new[] { "MAN", "LTN", "LGW", "LGW" };
                return FromAirports;
            }
            else
            {
                try
                {
                    if (System.Enum.IsDefined(typeof(DepartLocations), DepartAirport))
                    {
                        var FromAirports = new[] { DepartAirport };
                        return FromAirports;
                    }
                    else
                    {
                        throw (new InvalidDepartureException("Invalid Departure Airport"));
                    }
                }
                catch(InvalidDepartureException departex)
                {
                    Console.WriteLine(departex.Message.ToString());
                    Console.ReadLine();
                    var FromAirports = new[] { DepartAirport };
                    return FromAirports;
                }         
            }
        }

        public List<HolidaySearchResult> GetHolidaySearchResults    ( IList<Hotels> hotelList, IList<Flight> flightList
                                                                     ,string From, string To
                                                                     ,string DepartDate, int Duration
                                                                     )
        {
            HolidayResultList.Clear();
            var FromAirport = GetActualAirport(From);
  
            var SearchResult = from Flight in flightList
                               join Hotels in hotelList on Flight.departure_date equals Hotels.arrival_date
                               where FromAirport.Contains(Flight.@from!)
                               where Flight.to!.Contains(@To)
                               where Flight.departure_date!.Contains(@DepartDate)
                               where Hotels.nights.Equals(Duration)
                               orderby Hotels.price_per_night ascending
                               orderby Flight.price ascending
                               select new HolidaySearchResult()
                                        {
                                           FlightId = Flight.id,
                                           HotelId = Hotels.id,
                                        };

            List<HolidaySearchResult> HolidaySearchResultList = SearchResult.ToList();
            Console.WriteLine("***Search Result***");
            int counter = 0;
            foreach (var item in SearchResult.ToList())
            {
                counter = counter + 1;
               if (counter == 1)
                {
                    HolidayResultList!.Add(item);
                    Console.WriteLine(" FlightId {0}  HotelId {1}", item.FlightId, item.HotelId);
                }
            }
            return HolidayResultList.ToList();

        }
    }

} 


