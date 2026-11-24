namespace Acme.Orders.Domain;

public interface IOrderRepository
{
    Order? Find(Guid id);

    IReadOnlyList<Order> All();

    void Save(Order order);
}
