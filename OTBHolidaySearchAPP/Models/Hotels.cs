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

        /*public Hotels(int id, string name, string arrival_date, int price_per_night, List<string> local_airports, int nights)
        {
            this.id = id;
            this.name = name;
            this.arrival_date = arrival_date;
            this.price_per_night = price_per_night;
            this.local_airports = local_airports;
            this.nights = nights;
        }*/
    }
}

