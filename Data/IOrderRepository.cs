using System.Linq;
using WebShop.Models;

namespace WebShop.Data
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}