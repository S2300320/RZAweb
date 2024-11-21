using Microsoft.EntityFrameworkCore;
using RZAweb.Models;

namespace RZAweb.Services
{
    public class TicketService
    {
        private readonly TlS2300320RzaContext _context;
        public TicketService(TlS2300320RzaContext context)
        {
            _context = context;
        }
        public async Task<List<Ticket>> GetTicketsAsync()
        {
            return await _context.Tickets.ToListAsync();
        }
        public async Task AddTicketAsync(Ticket newTicket)
        {
            await _context.Tickets.AddAsync(newTicket);
            await _context.SaveChangesAsync();
        }
    }
}




