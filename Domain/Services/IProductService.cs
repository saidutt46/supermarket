using System;
using System.Collections.Generic;
using Supermarket.Domain.Models;
using System.Threading.Tasks;

namespace Supermarket.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
