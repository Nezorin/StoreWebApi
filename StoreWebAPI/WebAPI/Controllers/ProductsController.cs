using Domain.Dtos;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService ProductService)
        {
            _productService = ProductService;
        }

        [HttpGet]
        [Route("Get")]
        public IEnumerable<ProductReadDto> Get()
        {
            return _productService.Get();
        }
    }
}
