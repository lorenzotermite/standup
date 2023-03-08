using Standup.Model;

namespace Standup.Services
{
    public class CustomerService : ICustomerServcie
    {
        public List<Customer> getCustomer()
        {
            return new List<Customer>
            {
                new Customer { id = Guid.Parse("90FBA319-1D17-40D9-8ADF-8F5B8A618F85"), name = "angelo", surname = "angelo", email = "angelo@gmail.com" },
                new Customer { id = Guid.Parse("C95B731B-A597-42BB-862A-C80F70DC58FF"), name = "Alfio", surname = "Bello", email = "alfio@gmail.com" },
               new Customer { id = Guid.Parse("B1DEFD79-1C07-4EA7-B640-AAA81D03241C"), name = "Paolo", surname = "Lode", email = "Paolo@gmail.com" },
            };
             
               
        }
    }
}
