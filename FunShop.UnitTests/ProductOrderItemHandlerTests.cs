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
    public class ProductOrderItemHandlerTests
    {

        private Mock<IShippingSlipService> mockShippingSlipService;

        [TestInitialize]
        public void Setup()
        {
            mockShippingSlipService = new Mock<IShippingSlipService>();
        }

        [TestMethod]
        public void ProcessItem_ShippingService_IsCalled()
        {
            //Arrange
            mockShippingSlipService.Setup(x => x.GenerateShippingSlip(It.IsAny<Product>()));
            var productOrderItemProcessor = new ProductOrderItemHandler(ProductFakes.GetBook(), mockShippingSlipService.Object);

            //Act
            productOrderItemProcessor.Process();

            //Assert
            mockShippingSlipService.Verify(s => s.GenerateShippingSlip(It.IsAny<Product>()));

        }
    }
}
