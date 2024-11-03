namespace CSharp_Fastfood.Terminal.Models
{
    public class Order
    {
        public string Dish { get; }

        public Order(string dish)
        {
            Dish = dish;
        }

    }
}