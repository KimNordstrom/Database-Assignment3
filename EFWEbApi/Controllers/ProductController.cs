using EFWEbApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Service;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWEbApi.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("count")]
        public List<ProductDTO> GetProductCount()
        {
            var ProductDTOS = new List<ProductDTO>();
            foreach (var product in ProductService.Instance.GetAllProductsCount())
            {
                var productDTO = new ProductDTO() 
                { 
                    Name = product.Name, 
                    Stock = product.Stock, 
                    Status = ProductService.Instance.GetStatus(product.Stock)
                };
                ProductDTOS.Add(productDTO);
            }
            return ProductDTOS;
        }
        
        [HttpPost]
        [Route("update")]
        public void UpdateStock([FromBody] NewCountDTO newCount)
        {
            ProductService.Instance.UpdateStock(newCount.ProductID, newCount.NewCount);
        }

        [HttpGet]
        [Route("list")]
        public List<ProductNameDTO> GetProductsWithPar(string department, int count)
        {
            var ProductDTOS = new List<ProductNameDTO>();
            foreach(var product in ProductService.Instance.GetProductFromParameter(department, count))
            {
                var productDTO = new ProductNameDTO()
                {
                    ProductName = product.Name
                };
                ProductDTOS.Add(productDTO);
            }
            return ProductDTOS;
        }
    }
}
