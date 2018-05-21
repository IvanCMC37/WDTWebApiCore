using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCore.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCore.Controllers
{
    //set route of the api
    [Route("api/orders")]
    public class OrdersController : Controller
    {
        private readonly OrderContext _context;

        public OrdersController(OrderContext context)
        {
            _context = context;
        }

        // GET: api/orders
        [HttpGet]
        public async Task<IEnumerable<Order>> Get()
        {
            var orders = await _context.Order.ToArrayAsync();

            return orders;
        }

        // GET: api/orders/5
        [HttpGet("{id}")]
        public async Task<Order> Get(int id)
        {
            return await _context.Order.FirstOrDefaultAsync(x => x.ProductID == id);
        }
    }
}
