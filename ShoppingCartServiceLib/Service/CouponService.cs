using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trendyol.ShoppingCartApp.Repository.Interface;
using Trendyol.ShoppingCartApp.Repository.Models;
using Trendyol.ShoppingCartApp.Repository.Repository;
using Trendyol.ShoppingCartApp.Service.Interface;
using static Trendyol.ShoppingCartApp.Repository.Util.ExceptionHelper;

namespace Trendyol.ShoppingCartApp.Service.Service
{
    public class CouponService : ICouponService
    {
        private readonly ICouponRepository _couponRepository;

        public CouponService(CouponRepository couponRepository) => _couponRepository = couponRepository;

        public async Task SaveCouponAsync(Coupon coupon) => await DoWorkForRepository(() => _couponRepository.SaveAsync(coupon), "ShoppingCoupon.SaveCoupon");

        public async Task<IEnumerable<Coupon>> FindAllCouponAsync() => await DoWorkForRepositoryAsync(() => _couponRepository.FindAllAsync(), "ShoppingCoupon.FinAllCoupon");

        public async Task<Coupon> FindByIdCouponAsync(decimal id) => await DoWorkForRepositoryAsync(() => _couponRepository.FindByIdAsync(id), "ShoppingCart.FindByIdCoupon");

        public async Task DeleteByIdCouponAsync(decimal id) => await DoWorkForRepositoryAsync(() => _couponRepository.DeleteByIdAsync(id), "ShoppingCart.DeleteByIdCoupon");

        public async Task DeleteCouponAsync(Coupon coupon) => await DoWorkForRepositoryAsync(() => _couponRepository.DeleteAsync(coupon), "ShoppingCart.DeleteCoupon");
    }
}
