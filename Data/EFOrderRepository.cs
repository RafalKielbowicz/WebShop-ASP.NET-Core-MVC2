using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebShop.Models;

namespace WebShop.Data
{
    public class EFOrderRepository : IOrderRepository
    {
        private AppDbContext context;

        public EFOrderRepository(AppDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Order> Orders => 
            context.Orders
            .Include(o => o.Lines)
            .ThenInclude(l => l.Product);

        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Product));
            if(order.OrderID == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}