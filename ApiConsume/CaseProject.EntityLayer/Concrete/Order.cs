using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string OBJKEY { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
