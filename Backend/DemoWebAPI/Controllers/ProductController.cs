using Demo.Data;
using Demo.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {
        }

        [HttpGet("GetProducts")]
        public IEnumerable<Product> Get()
        {
            //TODO: Create a datalayer which has access to the DBSets
            //using (var db = new DataContext())
            //{
            //    return db.Products.AsEnumerable();
            //}

            return Enumerable.Empty<Product>();
        }
    }
}
