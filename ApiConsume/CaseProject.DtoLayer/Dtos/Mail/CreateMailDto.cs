using System;

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
            return $@"
                <table style='border-collapse: collapse; width: 100%;'>
                    <tr style='background-color: #f8f9fa;'>
                        <th style='border: 1px solid #dee2e6; padding: 8px;'>Order ID</th>
                        <td style='border: 1px solid #dee2e6; padding: 8px;'>{OrderId}</td>
                    </tr>
                    <tr style='background-color: #f8f9fa;'>
                        <th style='border: 1px solid #dee2e6; padding: 8px;'>Object Key</th>
                        <td style='border: 1px solid #dee2e6; padding: 8px;'>{OBJKEY}</td>
                    </tr>
                    <tr style='background-color: #f8f9fa;'>
                        <th style='border: 1px solid #dee2e6; padding: 8px;'>Created Date</th>
                        <td style='border: 1px solid #dee2e6; padding: 8px;'>{CreatedDate}</td>
                    </tr>
                    <tr style='background-color: #f8f9fa;'>
                        <th style='border: 1px solid #dee2e6; padding: 8px;'>Customer ID</th>
                        <td style='border: 1px solid #dee2e6; padding: 8px;'>{CustomerId}</td>
                    </tr>
                    <tr style='background-color: #f8f9fa;'>
                        <th style='border: 1px solid #dee2e6; padding: 8px;'>Customer Name</th>
                        <td style='border: 1px solid #dee2e6; padding: 8px;'>{CustomerName}</td>
                    </tr>
                    <tr style='background-color: #f8f9fa;'>
                        <th style='border: 1px solid #dee2e6; padding: 8px;'>Supplier ID</th>
                        <td style='border: 1px solid #dee2e6; padding: 8px;'>{SupplierId}</td>
                    </tr>
                    <tr style='background-color: #f8f9fa;'>
                        <th style='border: 1px solid #dee2e6; padding: 8px;'>Supplier Name</th>
                        <td style='border: 1px solid #dee2e6; padding: 8px;'>{SupplierName}</td>
                    </tr>
                    <tr style='background-color: #f8f9fa;'>
                        <th style='border: 1px solid #dee2e6; padding: 8px;'>Association No</th>
                        <td style='border: 1px solid #dee2e6; padding: 8px;'>{AssociationNo}</td>
                    </tr>
                </table>";
        }
    }
}
