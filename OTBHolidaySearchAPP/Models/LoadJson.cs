using Newtonsoft.Json;

namespace OTBHolidaySearchAPP.Models
{
    public class LoadJson
    {
        public string? HotelFileName { get; set; }
        public string? FlightFileName { get; set; }

        public IList<Hotels> loadHoteldata(string HotelFileName)
        {
            string hotelJsonArr = File.ReadAllText(@HotelFileName);
            var hotelList = JsonConvert.DeserializeObject<IList<Hotels>>(hotelJsonArr);

            return hotelList!;
        }

        public IList<Flight> loadFligtdata(string FlightFileName)
        {
            string flightJsonArr = File.ReadAllText(@FlightFileName);
            var flihtList = JsonConvert.DeserializeObject<IList<Flight>>(flightJsonArr);

            return flihtList!;
        }
    }
}

