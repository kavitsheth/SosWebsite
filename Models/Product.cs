using System;

namespace SosWebsite.Models
{
  public class Product
  {
    public string ProductId { get; set; }
    public string Description { get; set; }
    public string Size { get; set; }
    public int CaseSize { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string Barcode { get; set; }
    public short FreeStock { get; set; }
    public short Stock { get; set; }
    public short AllocatedStock { get; set; }
    public short StockOnOrder { get; set; }

  }
}