using Microsoft.EntityFrameworkCore;
using RZAweb.Models;

namespace RZAweb.Services
{
    public class TicketbookingService
    {
        private readonly TlS2300320RzaContext _context;
        public TicketbookingService(TlS2300320RzaContext context)
        {
            _context = context;
        }
        public async Task<List<Ticketbooking>> GetTicketsAsync()
        {
            return await _context.Ticketbookings.ToListAsync();
        }
        public async Task AddTicketbookingAsync(Ticketbooking newTicketbooking)
        {
            await _context.Ticketbookings.AddAsync(newTicketbooking);
            await _context.SaveChangesAsync();
        }
    }
}
