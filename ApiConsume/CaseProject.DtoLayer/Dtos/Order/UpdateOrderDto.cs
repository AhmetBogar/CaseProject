using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.DtoLayer.Dtos.Order
{
    public class UpdateOrderDto
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public string OBJKEY { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
