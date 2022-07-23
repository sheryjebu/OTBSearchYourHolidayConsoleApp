namespace OTBHolidaySearchAPP.Models
{
    public class Flight
    {
        public int id { get; set; }
        public string? airline { get; set; }
        public string? from { get; set; }
        public string? to { get; set; }
        public int price { get; set; }
        public string? departure_date { get; set; }

      /*  public Flight(int id, string airline, string from, string to, int price, string departure_date)
        {
            this.id = id;
            this.airline = airline;
            this.from = from;
            this.to = to;
            this.price = price;
            this.departure_date = departure_date;
        }*/
    }
}

