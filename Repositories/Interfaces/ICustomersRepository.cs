public interface ICustomersRepository {
  Task<IEnumerable<Customers>> GetAllCustomers();
  Task <Customers> GetCustomerById(int id);
  Task<bool> CreateCustomer(Customers customers);
  Task UpdateCustomer(Customers customers);
  Task DeleteCustomerById(int id);
}