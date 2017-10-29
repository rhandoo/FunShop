using FunShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Services
{
    public class CustomerActivationService : ICustomerActivationService
    {
        public void ActivateCustomer(ClubMembership clubMembership)
        {
            Console.Write("Customer Activate");
        }
    }
}
