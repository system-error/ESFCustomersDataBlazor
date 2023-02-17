using ESFCustomersData.Data;
using ESFCustomersData.Models;
using ESFCustomersData.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ESFCustomersData.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly CustomersDbContext _context;

        public CustomerRepository(CustomersDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Symvolaia>> GetCustomers()
        {
            
            return await _context.symvolaia
                .OrderBy(symvolaia => symvolaia.afm)
                .ToListAsync();
        }
    }
}
