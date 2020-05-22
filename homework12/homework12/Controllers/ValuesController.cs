using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using homework12.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace homework12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly OrderContext orderDb;

        public ValuesController(OrderContext context)
        {
            orderDb = context;
            if(orderDb.Orders.Count<Order>()<=0)
            {
                Order order = new Order();
                order.Id = 1;
                order.TotalPrice = 50;
                order.Customer = "swx";
                orderDb.Orders.Add(order);
                orderDb.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await orderDb.Orders.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrderById(int id)
        {
            var todoItem = await orderDb.Orders.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }


        [HttpGet("getorder")]
        public ActionResult<List<Order>> GetOrderByCus(string customer)
        {
            List<Order> orders = orderDb.Orders.Where(p => p.Customer == customer).ToList<Order>();
            foreach (Order order in orders)
                order.OrderItems = orderDb.OrderItems.Where(p => p.Order.Id == order.Id).ToList<OrderItem>();
            return orders;
        }

        // POST: api/valus
        [HttpPost]
        public async Task<ActionResult<Order>> PostTodoItem(Order order)
        {
            OrderItem item = new OrderItem();
            item.Id = 1;
            item.SingalPrice = 5;
            item.Amount = 5;
            order.OrderItems.Add(item);
            foreach (OrderItem orderItem in order.OrderItems)
                order.TotalPrice += orderItem.Amount * orderItem.SingalPrice;
            orderDb.Orders.Add(order);
            await orderDb.Orders.AddAsync(order);
            await orderDb.OrderItems.AddRangeAsync(order.OrderItems);
            await orderDb.SaveChangesAsync();

            return order;
        }

        [HttpPost]
        public ActionResult PostOrder(Order order)
        {
            try
            {
                foreach (OrderItem orderItem in order.OrderItems)
                    order.TotalPrice += orderItem.Amount * orderItem.SingalPrice;
                orderDb.Orders.Add(order);
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrderByID(int id)
        {
            var order = orderDb.Orders.Include("OrderItems").FirstOrDefault(p => p.Id == id);
            if (order != null)
            {
                orderDb.Orders.Remove(order);
                orderDb.SaveChanges();
                return Content("删除成功");
            }
            return Content("该订单不存在");
        }

        [HttpPut("{id}")]
        public ActionResult ChangeOrderByID(int id, Order order)
        {
            if (id != order.Id)
                return BadRequest("无法修改");
            try
            {
                orderDb.Entry(order).State = EntityState.Modified;
                foreach (OrderItem orderItem in order.OrderItems)
                    orderDb.Entry(orderItem).State = EntityState.Modified;
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
            return Content("修改成功");
        }
    }
}
