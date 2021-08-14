using Domain.Dtos;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService OrderService)
        {
            _orderService = OrderService;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<OrderReadDto>> Create([FromBody] OrderCreateDto order)
        {
            var newOrder = await _orderService.Create(order);
            return CreatedAtAction(nameof(Create), new { OrderId = newOrder.Id }, newOrder);
        }
        [HttpGet]
        [Route("Get")]
        public IEnumerable<OrderReadDto> Get()
        {
            return _orderService.Get();
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<Guid>> Update([FromBody] OrderUpdateDto order)
        {
            var result = await _orderService.Update(order);

            if (result == Guid.Empty)
            {
                return BadRequest("Product not updated");
            }

            return Ok(result);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<ActionResult> Delete([FromRoute] Guid id)
        {
            await _orderService.Delete(id);

            return Ok();
        }
    }
}
