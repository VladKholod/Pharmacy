using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Core
{
    public class Order : BaseEntity
    {
        public DateTime Date { get; set; }
        public OperationType Type { get; set; }
        public int PharmacyId { get; set; }

        public virtual Pharmacy Pharmacy { get; set; }

        public virtual List<OrderDetails> OrderDetailses { get; set; }
        
        public Order()
        {
            OrderDetailses = new List<OrderDetails>();
        }
    }
}
