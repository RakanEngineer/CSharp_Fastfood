
namespace CSharp_Fastfood.Terminal.Models
{
    public class KitchenBot
    {
        private static Queue<Order> orderQueue  = new Queue<Order>();
        public int PendingOrders
        {
            get
            {
                return orderQueue.Count();
            }
        }

        public void PlaceOrder(Order order)
        {
            orderQueue.Enqueue(order);
        }
    }
}