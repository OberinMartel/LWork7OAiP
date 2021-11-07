using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassirRu
{
    class TicketPack
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Manager { get; set; }
        public DateTime Date { get; set; }
        public int Reservation_Amount { get; set; }
        public int StockID { get; set; }
        public int StockPercent { get; set; }
        public TicketPack()
        { }
        public TicketPack(int Id)
        {
            this.Id = Id;
        }
        public TicketPack(string Name, decimal Cost, int Amount, DateTime Date, string Manager)
        {
            this.Cost = Cost;
            this.Name = Name;
            this.Amount = Amount;
            this.Date = Date;
            this.Manager = Manager;
            Reservation_Amount = 0;
        }
    }
}
