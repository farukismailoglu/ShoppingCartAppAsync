using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trendyol.ShoppingCartApp.Repository.Interface;
using Trendyol.ShoppingCartApp.Repository.Models;
using Trendyol.ShoppingCartApp.Service.Interface;
using static Trendyol.ShoppingCartApp.Repository.Util.ExceptionHelper;

namespace Trendyol.ShoppingCartApp.Service.Service
{
    public class CampaignService : ICampaignService
    {
        private readonly ICampaignRepository _campaignRepository;

        public CampaignService(ICampaignRepository campaignRepository) => _campaignRepository = campaignRepository;

        public async Task SaveCampaignAsync(Campaign campaign) => await DoWorkForRepositoryAsync(() => _campaignRepository.SaveAsync(campaign), "ShoppingCart.SaveCampaign");

        public async Task<IEnumerable<Campaign>> FindAllCampaignAsync() => await DoWorkForRepositoryAsync(() => _campaignRepository.FindAllAsync(), "ShoppingCart.FindAllCampaign");

        public async Task<Campaign> FindByIdCampaignAsync(decimal id) => await DoWorkForRepositoryAsync(() => _campaignRepository.FindByIdAsync(id), "ShoppingCart.FindByIdCampaign");

        public async Task DeleteByIdCampaignAsync(decimal id) => await DoWorkForRepositoryAsync(() => _campaignRepository.DeleteByIdAsync(id), "ShoppingCart.DeleteByIdCampaign");

        public async Task DeleteCampaignAsync(Campaign campaign) => await DoWorkForRepositoryAsync(() => _campaignRepository.DeleteAsync(campaign), "ShoppingCart.DeleteCampaign");






    }
}
