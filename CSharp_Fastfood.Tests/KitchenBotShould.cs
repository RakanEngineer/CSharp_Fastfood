using CSharp_Fastfood.Terminal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fastfood.Tests
{
    public class KitchenBotShould
    {
        [Fact]
        public void PlaceOrder()
        {
            // Arrange
            KitchenBot sut = new KitchenBot();
            Order order = new Order("Wonton Soup");

            // Act
            sut.PlaceOrder(order);

            // Assert
            Assert.Equal(1, sut.PendingOrders);

        }
        [Fact]
        public void ProcessOrders()
        {
            // Arrange
            KitchenBot sut = new KitchenBot();
            Order order1 = new Order("Wonton Soup");
            Order order2 = new Order("Chiken Noodle Soup");

            sut.PlaceOrder(order1);
            sut.PlaceOrder(order2);

            // Act
            sut.ProcessOrders();

            // Assert
            Assert.Equal(0, sut.PendingOrders);
        }
    }
}
