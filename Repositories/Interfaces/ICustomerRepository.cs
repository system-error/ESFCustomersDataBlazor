using ESFCustomersData.Models;

namespace ESFCustomersData.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Symvolaia>> GetCustomers();
    }
}
