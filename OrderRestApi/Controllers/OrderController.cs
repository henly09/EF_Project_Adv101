using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderRestApi.Data;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DataContext _context;

        public OrderController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("DisplayAll")]
        public async Task<ActionResult<List<Order>>> Get()
        {
            return Ok(await _context.BakeryOrders.ToListAsync());
        }

        [HttpGet("SelectStudent/{ID}")]
        public async Task<ActionResult<Order>> Get(int ID)
        {
            var order = await _context.BakeryOrders.FindAsync(ID);
            if (order == null)
                return BadRequest("Order not found.");
            return Ok(order);
        }

        [HttpPost("AddOrder")]
        public async Task<ActionResult<List<Order>>> AddOrder(Order order)
        {
            _context.BakeryOrders.Add(order);
            await _context.SaveChangesAsync();

            return Ok(await _context.BakeryOrders.ToListAsync());
        }

        [HttpPut("UpdateOrder")]
        public async Task<ActionResult<List<Order>>> UpdateOrder(Order request)
        {
            var dbOrders = await _context.BakeryOrders.FindAsync(request.ID);
            if (dbOrders == null)
                return BadRequest("Order not found.");

            dbOrders.price = request.price;
            dbOrders.ordered = request.ordered;
            dbOrders.pieces = request.pieces;
            dbOrders.Type_ = request.Type_;
            dbOrders.orderdate = request.orderdate;
            dbOrders.ordertime = request.ordertime;
            dbOrders.fullname = request.fullname;
            dbOrders.email = request.email;
            dbOrders.phonenumber = request.phonenumber;
            dbOrders.address = request.address;

            await _context.SaveChangesAsync();

            return Ok(await _context.BakeryOrders.ToListAsync());
        }

        [HttpDelete("DeleteOrder/{ID}")]
        public async Task<ActionResult<List<Order>>> Delete(int ID)
        {
            var order = await _context.BakeryOrders.FindAsync(ID);
            if (order == null)
                return BadRequest("Order not found.");

            _context.BakeryOrders.Remove(order);
            await _context.SaveChangesAsync();

            return Ok(await _context.BakeryOrders.ToListAsync());
        }
    }




}
