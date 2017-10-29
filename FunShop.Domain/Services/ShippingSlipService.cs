using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunShop.Model;

namespace FunShop.Services
{
    public class ShippingSlipService : IShippingSlipService
    {
        public void GenerateShippingSlip(Product product)
        {
            Console.Write("Shipping Slip Generated for " + product.GetDescription());
        }
    }
}
