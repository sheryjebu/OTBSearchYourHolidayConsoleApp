namespace OTBHolidaySearchAPP.Models
{
    public class SearchQuery
    {
        public List<HolidaySearchResult>? HolidayResultList { get; private set; }

        public IList<Hotels>? hotelList { get; set; }
        public IList<Flight>? flightList { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public string? DepartDate { get; set; }
        public int? Duration { get; set; }

       /* public SearchQuery( IList<Hotels> hotelList, IList<Flight> flightList
                           , string from, string to
                           , string departDate
                           , int duration
                          )
        {
            this.hotelList = hotelList;
            this.flightList = flightList;
            From = from;
            To = to;
            DepartDate = departDate;
            Duration = duration;
        }*/



        public List<HolidaySearchResult> HolidaySearch( IList<Hotels> hotelList, IList<Flight> flightList
                                                      ,string From ,String To
                                                      ,string DepartDate, int Duration
            // List<UserInput> userInputs
                                                      )
        {
           // List<UserInput> inputs = new List<UserInput>;

            var SearchResult = from Flight in flightList
                               join Hotels in hotelList on Flight.departure_date equals Hotels.arrival_date
                                where Flight.@from == From//"MAN"
                                where Flight.to == To //"AGP"
                               where Flight.departure_date == DepartDate//"2023-07-01"
                               where Hotels.nights == Duration//7
                                select (new HolidaySearchResult()
                                        {
                                            FlightId = Flight.id,
                                            //Airline = Flight.airline,
                                            //From = Flight.@from,
                                            //To = Flight.to,
                                            HotelId = Hotels.id

                                        });
            Console.WriteLine("***Search Result***");
            foreach (HolidaySearchResult item in SearchResult.ToList())
            {
                HolidayResultList!.Add(item);
            }
           // HolidayResultList = SearchResult.Cast<HolidaySearchResult>().ToList();
            return HolidayResultList;
        }
    }

    
}

