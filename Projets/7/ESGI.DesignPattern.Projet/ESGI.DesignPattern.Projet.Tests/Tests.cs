using System;
using Xunit;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class Tests
    {
        [Fact]
        public void Discount()
        {
            var discount = new Discount();

            var net = new Money(1002);
            var total = discount.DiscountFor(net);

            Assert.Equal(new Money(901.8m), total);
        }

    }
}

