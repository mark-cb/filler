namespace Filler.API.Models
{
    public class Pump
    {
        public Guid? Id { get; }

        public int Number { get; }

        public bool Locked { get; set; }
    }
}
