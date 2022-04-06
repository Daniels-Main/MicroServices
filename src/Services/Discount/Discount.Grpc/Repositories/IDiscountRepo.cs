using Discount.Grpc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount.Grpc.Repositories
{
    public interface IDiscountRepo
    {
        Task<Coupon> GetDisc(string productName);

        Task<bool> CreateDisc(Coupon coupon);
        Task<bool> UpdateDisc(Coupon coupon);
        Task<bool> DeleteDisc(string productName);
    }
}
