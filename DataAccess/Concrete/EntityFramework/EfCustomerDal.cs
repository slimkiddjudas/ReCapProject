using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarRentalProjectContext>, ICustomerDal
    {
        public List<CustomerDetailsDto> GetCustomerDetails()
        {
            using (CarRentalProjectContext context = new CarRentalProjectContext())
            {
                var result = from c in context.Customers
                    join u in context.Users on c.UserId equals u.UserId
                    select new CustomerDetailsDto
                    {
                        CustomerId = c.CustomerId,
                        CustomerFirstName = u.FirstName,
                        CustomerLastName = u.LastName,
                        CustomerEmail = u.Email,
                        CompanyName = c.CompanyName
                    };
                return result.ToList();
            }
        }
    }
}
