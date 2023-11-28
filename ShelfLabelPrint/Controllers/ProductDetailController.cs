using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShelfLabelPrint.Services;

namespace ShelfLabelPrint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailController : ControllerBase
    {
        ProductDtlService productDtlService;
        public ProductDetailController(ProductDtlService productDtlService)
        {
            this.productDtlService = productDtlService;
        }
        [HttpGet("GetProductDtl")]
        public string GetProductDtl()
        {
            string connectionString = productDtlService.GetConnectioinString();
            return connectionString;
        }
    }
}
