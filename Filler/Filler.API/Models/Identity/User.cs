using Microsoft.AspNetCore.Identity;

namespace Filler.API.Models.Identity
{
    public class User : IdentityUser
    {
        public List<Receipt> UserReceipts { get; set; }
        public bool FuelSave { get; set; }
    }
}
