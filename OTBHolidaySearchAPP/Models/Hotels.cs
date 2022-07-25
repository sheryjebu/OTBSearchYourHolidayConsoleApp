namespace OTBHolidaySearchAPP.Models
{
    public class Hotels
    {
        public int id { get; set; }
        public string name { get; set; }
        public string arrival_date { get; set; }
        public int price_per_night { get; set; }
        public List<string> local_airports { get; set; }
        public int nights { get; set; }

      
    }
}

