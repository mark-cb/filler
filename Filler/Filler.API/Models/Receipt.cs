namespace Filler.API.Models
{
    public class Receipt
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public FuelType FuelType { get; set; } 

        public double Litres { get; set; }
        
        public DateTime FillTime { get; set; }

        public double Total { get; set; }

    }
}
