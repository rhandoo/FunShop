using FunShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.UnitTests.Fakes
{
    public static class FakeCustomer
    {
        public static Customer GetCustomer()
        {
            return new Customer("TestCustomer");
        }
    }
}
