namespace Filler.API.Models
{
    public class Receipt
    {
        public  int Id { get; set; }

        public FuelType FuelType { get; set; } 

        public double Litres { get; set; }
        
        public DateTime FillTime { get; set; }

        public double Total { get; set; }

        public Pump UsedPump { get; set; }

        public string UserId { get; set; }

    }
}
