using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KassirRu
{
    class StockContext : DbContext
    {
        public StockContext() : base("KassirRuDB") { }
        public DbSet<Stock> Stocks { get; set; }
        public Stock FindStockWithID(int ID)
        {
            foreach (Stock stock in Stocks)
            {
                if (stock.Id == ID) return stock;
            }
            return null;
        }
    }
}
