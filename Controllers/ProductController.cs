using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstAPI.Models;
using FirstAPI.INterface;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepo<int, Product> _repo;

        public ProductController(IRepo<int, Product> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [ProducesResponseType(typeof(ICollection<Product>),200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ICollection<Product>> Get()
        {
            IList<Product> products = _repo.GetAll().ToList();
            if(products==null)
            {
                return NotFound("The Product is not available");
            }
            else
            {
                return Ok(products);
            }
        }
    }
}
