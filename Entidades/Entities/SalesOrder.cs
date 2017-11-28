using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SalesOrder
    {
        public int SalesOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string SalesOrderNumber { get; set; }
        public int CustomerID { get; set; }
        public int SalesPersonID { get; set; }
        public string ShipToAddress { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal TotalDue { get; set; }
        public IEnumerable<SalesOrderDetail> OrderDetails { get; set; }

    }

    public class SalesOrderDetail
    {
        public int SalesOrderDetailId { get; set; }
        public Light Product { get; set; }
        public int OrderQty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceDiscount { get; set; }
    }

}
