using Filler.API.Models;

namespace Filler.API.Repositories.Interfaces
{
    public interface IFuelRepo
    {
        public Task<List<Site>> GetSitesAsync();
        public Task<Site> GetSiteAsync(int siteId);

        public Task<List<Pump>> GetPumpsAsync(int siteId);
        public Task<Pump> GetPumpAsync(int pumpId);

        public Task<List<Receipt>> GetReceiptsAsync(string userId);

        public Task<Receipt> GetReceiptAsync(int receiptId);

        public Task<Receipt> AddReceiptAsync(Receipt receipt);
        
    }
}
