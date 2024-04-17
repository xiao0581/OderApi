using Microsoft.AspNetCore.Mvc;
using OderApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
            private readonly OderRepository _oderRepository;
        public OrdersController(OderRepository oderRepository)
        {
                _oderRepository = oderRepository;
            }
        // GET: api/<OrdersController>
        [HttpGet]
        public List<Order> GetAll()
        {
            return _oderRepository.GetAllOrder();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _oderRepository.GetOrderById(id);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] Order order)
        {
            _oderRepository.AddOrder(order);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order order)
        {
            order.Id = id;
            _oderRepository.UpdateOrder(order);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _oderRepository.DeleteOrder(id);
        }
    }
}
