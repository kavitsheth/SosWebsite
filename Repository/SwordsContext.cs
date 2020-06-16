using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Odbc;
using System.Threading.Tasks;
using SosWebsite.Models;

namespace SosWebsite.Repository
{
  public static class SwordsContext
  {
    private static IEnumerable<Product> products;

    private static DateTime cacheExpiry;

    public static async Task<IEnumerable<Product>> GetProductsAsync()
    {
      if (DateTime.Now < cacheExpiry)
      {
        return products;
      }
      string connectionString = "DSN=Swords ODBC Driver";
      string query = "select pbd_prod_code, TRIM(pbd_prod_name) + ' ' + pbd_prod_unit, pbd_prod_unit, pbd_prod_pack, (SELECT TOP 1 DATEADD(day,-1, A.bsj_putaway_date) FROM admin.sffbsj A WHERE A.bsj_prod_ptr=P.pbd_prod_ptr AND A.bsj_type=1 ORDER BY A.bsj_move_date DESC), pxd_ean_code, psd_stk_qty, psd_stk_qty+psd_booked_qty, psd_booked_qty, psd_po_qty from admin.sffpbd p left join admin.sffpsd on psd_prod_ptr = pbd_prod_ptr and psd_stock_loc = 1 left join admin.sffpxd_details on pxd_prod_ptr = pbd_prod_ptr";
      OdbcConnection odbcConnection = new OdbcConnection(connectionString);
      OdbcCommand odbcCommand = new OdbcCommand(query, odbcConnection) { CommandTimeout = 90 };
      DbDataReader reader = null;
      List<Product> output = null;
      try
      {
        odbcConnection.Open();
        reader = await odbcCommand.ExecuteReaderAsync();
        if (reader.HasRows)
        {
          while (reader.Read())
          {
            output.Add(new Product
            {

            });
          }
        }
      }
      catch (Exception)
      {

      }
      finally
      {
        reader?.Close();
        odbcConnection?.Close();
        odbcCommand?.Dispose();
        odbcConnection?.Dispose();
      }
      cacheExpiry = DateTime.Now.AddMinutes(10);
      return output as IEnumerable<Product>;
    }
  }
}