﻿using FunShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Services
{
    public interface IShippingSlipService
    {
        void GenerateShippingSlip(Product product);
    }
}
