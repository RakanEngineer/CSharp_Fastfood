using CSharp_Fastfood.Terminal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace CSharp_Fastfood.Tests
{
    public class OrderShould
    {
        [Fact]
        public void ThrowsExceptionIfCompletedCalledMoreThanOnce()
        {
            // Arrange
            Order sut = new Order("Wonton Soup");
            sut.Completed();

            
            // Act and Assert
            Assert.Throws<InvalidOperationException>(() => sut.Completed());
        }
    }
}
