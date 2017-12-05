using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTier
{
    public class VehicleStockData : Data
    {
        public VehicleStockData(string connectionString, string tableName, string selectQuery) : base(connectionString, tableName, selectQuery) { }

        public bool IsDuplicateStockNumber(string stockNumber)
        {
            bool result = false;

            stockNumber = stockNumber.Trim();

            string filter = string.Format("StockNumber = {0}", stockNumber);

            if (GetAllRows().Select(filter).Count() > 0)
            {
                result = true;
            }

            return result;
        }

    }
}
