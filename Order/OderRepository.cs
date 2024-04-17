using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Order
{
    public class OderRepository
    {
        public List<Order> orders = new() {
           
                new Order { Id = 1, OrderName = "Order 1", Orderdate = "2021-01-01" },
                new Order { Id = 2, OrderName = "Order 2", Orderdate = "2021-01-02" },
                new Order { Id = 3, OrderName = "Order 3", Orderdate = "2021-01-03" },
                new Order { Id = 4, OrderName = "Order 4", Orderdate = "2021-01-04" },
                new Order { Id = 5, OrderName = "Order 5", Orderdate = "2021-01-05" }
            };
    

        public List<Order> GetAllOrder()
        {
             return new List<Order>(orders);
        }

        public Order GetOrderById(int id)
        {
            return orders.FirstOrDefault(o => o.Id == id);

        }
        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
        public void UpdateOrder(Order order)
        {
            var existingOrder = GetOrderById(order.Id);
            if (existingOrder != null)
            {
                existingOrder.OrderName = order.OrderName;
                existingOrder.Orderdate = order.Orderdate;
            }
        }
        public void DeleteOrder(int id)
        {
            var order = GetOrderById(id);
            if (order != null)
            {
                orders.Remove(order);
            }
        }
    }
}
