using System;
using Xunit;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class Tests
    {
        [Fact]
        public void GetContents_produces_all_orders()
        {
            var orders = new Orders();
            var order = new Order(1234);
            order.Add(new Product(4321, "T-Shirt", ProductSize.Medium, "21.00"));
            order.Add(new Product(6789, "Socks", ProductSize.Medium, "8.00"));
            orders.Add(order);

            var ordersWriter = new OrdersWriter(orders);

            var expectedOrder =
                "<orders>" +
                    "<order id='1234'>" +
                        "<product id='4321' color='red' size='medium'>" +
                            "<price currency='USD'>" +
                            "21.00" +
                            "</price>" +
                        "T-Shirt" +
                        "</product>" +
                        "<product id='6789' color='red' size='medium'>" +
                            "<price currency='USD'>" +
                            "8.00" +
                            "</price>" +
                        "Socks" +
                        "</product>" +
                    "</order>" +
                "</orders>";
            Assert.Equal(expectedOrder, ordersWriter.GetContents());
        }

        [Fact]
        public void GetContents_produces_no_orders()
        {
            var orders = new Orders();
            var ordersWriter = new OrdersWriter(orders);

            var expectedOrder =
            "<orders>" +
            "</orders>";

            Assert.Equal(expectedOrder, ordersWriter.GetContents());
        }
    }
}

