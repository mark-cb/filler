namespace Filler.API.Models
{
    public class Receipt
    {
        public  int ReceiptId { get; set; }

        public string UserId { get; set; }

        public FuelType FuelType { get; set; } 

        public double Litres { get; set; }
        
        public DateTime FillTime { get; set; }

        public double Total { get; set; }              

    }
}
