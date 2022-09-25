using Catalog.Services.Queries;
using Catalog.Services.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Common.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductQueryService _service;
     
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, IProductQueryService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<DataCollection<ProductDTO>> GetAllAsync(int page = 1, int take= 10, string ids = null)
        {
            IEnumerable<int> products = null;

            if (!string.IsNullOrEmpty(ids))
            {
                products = ids.Split(",").Select(x => Convert.ToInt32(x));
            }

            return await _service.GetAllAsync(page, take, products);
              
        }

        [HttpGet("{id}")]
        public async Task<ProductDTO> GetByIdAsync(int id)
        {            
            return await _service.GetByIdAsync(id);
        }
    }
}
