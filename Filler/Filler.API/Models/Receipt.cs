namespace Filler.API.Models
{
    public class Receipt
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public double Total { get; set; }

    }
}
