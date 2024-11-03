
namespace CSharp_Fastfood.Terminal.Models
{
    public class Order
    {
        public string Dish { get; }
        public DateTime? CompletedAt { get; private set; }

        public Order(string dish)
        {
            Dish = dish;
        }

        public void Completed()
        {
            if (CompletedAt != null) 
                throw new InvalidOperationException("order already completed");

                CompletedAt = DateTime.Now;
        }
    }
}