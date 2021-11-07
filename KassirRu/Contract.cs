using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassirRu
{
    class Contract
    {
        public int Id { get; set; }
        public DateTime Registration_Date { get; set; }
        public string Event_Name { get; set; }
        public decimal Sum { get; set; }
        public string Buyer { get; set; }
        public string Seller { get; set; }
        public int Reserv { get; set; }
        public Contract()
        { }
        public Contract(DateTime Registration_Date, string Event_Name, decimal Sum, string Buyer, string Seller, int Reserv = 0)
        {
            this.Registration_Date = Registration_Date;
            this.Event_Name = Event_Name;
            this.Sum = Sum;
            this.Buyer = Buyer;
            this.Seller = Seller;
            this.Reserv = Reserv;
        }
    }
}
