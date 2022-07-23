using Newtonsoft.Json;

namespace OTBHolidaySearchAPP.Models
{
    public class LoadJson
    {
        public string HotelFileName { get; set; }
        public string FlightFileName { get; set; }

        public LoadJson(string hotelFileName, string flightFileName)
        {
            HotelFileName = hotelFileName;
            FlightFileName = flightFileName;
        }

        public IList<Hotels> loadHoteldata(string HotelFileName)
        {
            ///Users/sheryjebu/Projects/OTBHolidaySearchAPP/OTBHolidaySearchAPP/Hotels.json
            string hotelJsonArr = File.ReadAllText(@HotelFileName);
            var hotelList = JsonConvert.DeserializeObject<IList<Hotels>>(hotelJsonArr);

            return hotelList!;
        }

        public IList<Flight> loadFligtdata(string FlightFileName)
        {
            ///Users/sheryjebu/Projects/OTBHolidaySearchAPP/OTBHolidaySearchAPP/Flight.json
            string flightJsonArr = File.ReadAllText(@FlightFileName);
            var flihtList = JsonConvert.DeserializeObject<IList<Flight>>(flightJsonArr);

            return flihtList!;
        }
    }
}

