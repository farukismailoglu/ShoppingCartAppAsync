using Trendyol.ShoppingCartApp.Repository.Data;
using Trendyol.ShoppingCartApp.Repository.Interface;
using Trendyol.ShoppingCartApp.Repository.Models;

namespace Trendyol.ShoppingCartApp.Repository.Repository
{
    public class CampaignRepository : BaseRepository<Campaign, decimal>, ICampaignRepository
    {
        public CampaignRepository() : base(new ShoppingCartAppDbContext())
        { }
    }
}
