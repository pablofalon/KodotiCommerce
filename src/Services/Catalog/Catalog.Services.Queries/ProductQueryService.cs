using Catalog.Persistence.Database;
using Catalog.Services.Queries.DTOs;
using Microsoft.EntityFrameworkCore;
using Services.Common.Collection;
using Services.Common.Mapping;
using Services.Common.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Services.Queries
{

    public interface IProductQueryService
    {
        Task<DataCollection<ProductDTO>> GetAllAsync(int page, int take, IEnumerable<int> products = null);
        Task<ProductDTO> GetByIdAsync(int productId);
    }

    public class ProductQueryService: IProductQueryService
    {
        private ApplicationDbContext _context; 
        public ProductQueryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DataCollection<ProductDTO>> GetAllAsync(int page, int take, IEnumerable<int> products = null )
        {
            var collection = await _context.Products
                .Where(x => products == null || products.Contains(x.ProductId))
                .Include("Stock")
                .OrderByDescending(x => x.ProductId)
                .GetPagedAsync(page, take);

            return collection.MapTo<DataCollection<ProductDTO>>();
        }

        public async Task<ProductDTO> GetByIdAsync(int productId) 
        {
            return (await _context.Products.SingleAsync(x => x.ProductId == productId)).MapTo<ProductDTO>();
        }

    }
}
