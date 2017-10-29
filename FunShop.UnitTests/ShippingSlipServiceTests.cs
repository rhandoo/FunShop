using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunShop.Processor.Factory;
using System.Collections.Generic;
using FunShop.Model;
using Moq;
using FunShop.Processor;
using System.Linq;
using FunShop.Services;

namespace FunShop.UnitTests
{
    [TestClass()]
    public class ShippingSlipServiceTests
    {
        [TestMethod]
        public void GenerateShippingSlip_Product_IsSuccessfull()
        {
            //Arrange
            var product = ProductFakes.GetBook();
            var shippingSlip = new ShippingSlipService();

            //Assert
            try
            {
                //Act 
                shippingSlip.GenerateShippingSlip(product);
            }
            catch (Exception)
            {

                Assert.Fail();
            }
        }

    }
}
