using RZAweb.Models;
using Microsoft.EntityFrameworkCore;

namespace RZAweb.Services
{
    public class CustomerService
    {
        private readonly TlS2300320RzaContext _context;

        public CustomerService(TlS2300320RzaContext context)
        {
            _context = context;
        }
    }
}
