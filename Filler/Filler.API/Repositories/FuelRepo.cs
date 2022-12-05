using Filler.API.Models;
using Filler.API.Models.Sites;
using Filler.API.Repositories;
using Filler.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Filler.API.Repositories
{
    public class FuelRepo : IFuelRepo
    {
        private readonly FuelSiteContext db;

        public FuelRepo(FuelSiteContext context)
        {
            db = context;
        }

        public async Task<Receipt> AddReceiptAsync(Receipt receipt)
        {
            throw new NotImplementedException();
        }

        public async Task<Pump> GetPumpAsync(int pumpId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Pump>> GetPumpsAsync(int siteId)
        {
            return await db.Pumps.Where(p => p.SiteId ==  siteId).ToListAsync().ConfigureAwait(false);

        }

        public async Task<Receipt> GetReceiptAsync(int receiptId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Receipt>> GetReceiptsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<Site?> GetSiteAsync(int siteId)
        {
            return await db.Sites.FindAsync(siteId).ConfigureAwait(false);
        }

        public async Task<List<Site>> GetSitesAsync()
        {
            return await db.Sites.ToListAsync().ConfigureAwait(false);
        }
    }
    
}
