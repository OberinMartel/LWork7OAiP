using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassirRu
{
    class Stock
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int Percent { get; set; }
        public int EventID { get; set; }
        public Stock()
        { }
        public Stock(DateTime DateStart, DateTime DateEnd, int Percent, int EventID)
        {
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            this.Percent = Percent;
            this.EventID = EventID;
        }
    }
}
