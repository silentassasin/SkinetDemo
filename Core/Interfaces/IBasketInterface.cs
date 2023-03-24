using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IBasketRepository
    {
        Task<Customerbasket> GetBasketAsync(string id);

        Task<Customerbasket> UpdateBasketAsync(Customerbasket basket);

        Task<bool> DeleteBasketAsync(string id);

    }
}