using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int DeliveryQty { get; set; }
    }
}
