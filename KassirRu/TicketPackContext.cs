using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KassirRu
{
    class TicketPackContext : DbContext
    {
        public TicketPackContext() : base("KassirRuDB") { }
        public DbSet<TicketPack> TicketPacks { get; set; }

        public TicketPack FindTicketPackWithID(int ID)
        {
            foreach (TicketPack ticketPack in TicketPacks)
            {
                if (ticketPack.Id == ID) return ticketPack;
            }
            return null;
        }
        public TicketPack FindTicketPackWithName(string Name)
        {
            foreach (TicketPack ticketPack in TicketPacks)
            {
                if (ticketPack.Name == Name) return ticketPack;
            }
            return null;
        }
    }
}
