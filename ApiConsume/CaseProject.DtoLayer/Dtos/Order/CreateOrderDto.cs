using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.DtoLayer.Dtos.Order
{
    public record CreateOrderDto()
    {
        public string OBJKEY { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public DateTime CreatedDate { get; set; } 
    }

}
