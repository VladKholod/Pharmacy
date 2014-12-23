using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Core
{
    public class Pharmacy : BaseEntity
    {
        public string Address { get; set; }
        public int Number { get; set; }
        public string Phone { get; set; }
        public DateTime OpenDate { get; set; }

        public virtual List<Order> Orders { get; set; }
        public virtual List<Storage> Storages { get; set; }

        public Pharmacy()
        {
            Orders = new List<Order>();
            Storages = new List<Storage>();
        }
    }
}
