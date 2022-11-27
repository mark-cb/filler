namespace Filler.API.Models
{
    public class Pump
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public int Number { get; set; }

        public bool Locked { get; set; }
    }
}
