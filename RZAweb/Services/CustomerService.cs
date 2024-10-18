using RZAweb.Models;

namespace RZAweb.Services
{
    public class CustomerService
    {
        private readonly TlS2300320RzaContext _context;
        public CustomerService(TlS2300320RzaContext context)
        {
            _context = context;
        }
        
        
         public async Task AddCustomerAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        
    }
}
