using CaseProject.DtoLayer.Dtos.Customer;
using CaseProject.DtoLayer.Dtos.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.DtoLayer.Dtos.Order
{
    public class ResultOrderDto
    {
        public int OrderId { get; set; }
        public string OBJKEY { get; set; }
        public DateTime CreatedDate { get; set; }

        public int CustomerId { get; set; } 
        public string CustomerName { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string AssociationNo { get; set; }
    }
}
