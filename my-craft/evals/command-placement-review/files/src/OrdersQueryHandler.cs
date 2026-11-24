using Acme.Orders.Api;
using Acme.Orders.Domain;

namespace Acme.Orders.Application;

public class OrdersQueryHandler(IOrderRepository orders)
{
    public List<OrderApiModel> AllOrders()
    {
        var result = new List<OrderApiModel>();
        foreach (var order in orders.All())
        {
            result.Add(new OrderApiModel
            {
                Id = order.Id,
                CustomerName = order.CustomerName,
                Status = order.Status.ToString(),
                LineCount = order.Lines.Count
            });
        }
        return result;
    }
}
