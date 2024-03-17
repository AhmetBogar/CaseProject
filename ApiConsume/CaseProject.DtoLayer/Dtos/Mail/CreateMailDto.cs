using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CreateMailDto
{
    public string To { get; set; }
    public string Subject { get; set; }
    public int OrderId { get; set; }
    public string OBJKEY { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public int SupplierId { get; set; }
    public string SupplierName { get; set; }
    public string AssociationNo { get; set; }
    public string Body
    {
        get
        {
            return "<table border='1'>" +
                   "<tr><th>OrderId</th><td>" + OrderId + "</td></tr>" +
                   "<tr><th>OBJKEY</th><td>" + OBJKEY + "</td></tr>" +
                   "<tr><th>CreatedDate</th><td>" + CreatedDate + "</td></tr>" +
                   "<tr><th>CustomerId</th><td>" + CustomerId + "</td></tr>" +
                   "<tr><th>CustomerName</th><td>" + CustomerName + "</td></tr>" +
                   "<tr><th>SupplierId</th><td>" + SupplierId + "</td></tr>" +
                   "<tr><th>SupplierName</th><td>" + SupplierName + "</td></tr>" +
                   "<tr><th>AssociationNo</th><td>" + AssociationNo + "</td></tr>" +
                   "</table>";
        }
    }
}
