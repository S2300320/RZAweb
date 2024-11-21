using Microsoft.EntityFrameworkCore;
using RZAweb.Models;


namespace RZAweb.Services
{
    public class AttractionService
    {
        private readonly TlS2300320RzaContext _context;

        public AttractionService(TlS2300320RzaContext context)
        {
            _context = context;
        }

        public async Task<List<Attraction>> GetAttractionsAsync()
        {
            return await _context.Attractions.ToListAsync();
        }
    }
}
