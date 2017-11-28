using Entities;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int requestgift;
            // Create the order
            var details = new List<SalesOrderDetail>();
            SalesOrder order = CreateOrder(details);
            var specialgift = details.Count(c => ((SmallLight)c.Product).Shape != "");
            // Create the gift request and send the external provider the oorder request:
            if (specialgift > 3)
            {
                // Call the service for the external provider:
                using (var repository = new RequestRepository())
                {
                    requestgift = repository.GenerateRequest(new Delivery() { DeliveryDate = DateTime.Now, DeliveryQty = 3 });
                }
            }
        }

        private static SalesOrder CreateOrder(List<SalesOrderDetail> details)
        {
            // Create the order
            SalesOrder order = new SalesOrder();
            order.CustomerID = 34567;
            order.OrderDate = DateTime.Now;
            order.SalesOrderId = 56478;
            order.SalesOrderNumber = "SN-0987-345Y";
            order.SalesPersonID = 23432;
            order.ShipToAddress = "Fake Street 123";

            details = new List<SalesOrderDetail>()
            {
                new SalesOrderDetail() {
                    Product = new SmallLight() { LightColor = Color.White, LightPower = 15, LightMaterial= Material.Plastic, Shape = "L" },
                    OrderQty = 5,
                    UnitPrice = 1000,
                    UnitPriceDiscount = 0 },
                new SalesOrderDetail() {
                    Product = new SmallLight() { LightColor = Color.Blue, LightPower = 9, LightMaterial= Material.Glass, Shape = "B" },
                    OrderQty = 5,
                    UnitPrice = 1000,
                    UnitPriceDiscount = 0 },
                new SalesOrderDetail() {
                    Product = new SmallLight() { LightColor = Color.Transparent, LightPower = 12, LightMaterial= Material.Glass, Shape = "A" },
                    OrderQty = 5,
                    UnitPrice = 1000,
                    UnitPriceDiscount = 0 }
            };

            // Add the order details:
            order.OrderDetails = details;
            // Return the order:
            return order;
        }
    }
}
