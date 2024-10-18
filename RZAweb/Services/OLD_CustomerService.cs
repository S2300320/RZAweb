using RZAweb.Models;
using Microsoft.EntityFrameworkCore;

namespace RZAweb.Services
{
    public class OLD_CustomerService
    {
        private readonly TlS2300320RzaContext _context;

        public OLD_CustomerService(TlS2300320RzaContext context)
        {
            _context = context;
        }
    }
}
