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
    }
}
