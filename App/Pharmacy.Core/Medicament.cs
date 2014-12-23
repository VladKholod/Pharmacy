using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Core
{
    public class Medicament : BaseEntity
    {
        public string Name { get; set; }
        public string SerialNumber{ get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual List<Storage> Storages { get; set; }
        public virtual List<MedicamentPriceHistory> MedicinePriceHistories { get; set; }
        public virtual List<OrderDetails> OrderDetailses { get; set; }

        public Medicament()
        {
            Storages = new List<Storage>();
            MedicinePriceHistories = new List<MedicamentPriceHistory>();
            OrderDetailses = new List<OrderDetails>();
        }
    }
}
