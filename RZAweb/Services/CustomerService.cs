using Microsoft.EntityFrameworkCore;
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

        public async Task<Customer?> LogIn(Customer customer)
        {
            return await _context.Customers.FirstOrDefaultAsync(
                c => c.Username == customer.Username &&
                c.Password == customer.Password);
        }
        public async Task ChangePassword(int customerId, string hashedOldpassword, string hashedNewPassword)
        {
            Customer? customer = await _context.Customers.SingleOrDefaultAsync(
                c => c.CustomerId == customerId && c.Password == hashedOldpassword);
            if (customer != null) 
            {
                customer.Password = hashedNewPassword;
                await _context.SaveChangesAsync();

            }
                
            customer.Password = hashedNewPassword;
            await _context.SaveChangesAsync();

        }
        
    }
}
