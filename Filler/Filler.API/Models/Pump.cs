namespace Filler.API.Models
{
    public class Pump
    {
        public int PumpId { get; set; }

        public int Number { get; set; }

        public bool UnLocked { get; set; }

        
        public Site PumpSite { get; set; }
    }
}
