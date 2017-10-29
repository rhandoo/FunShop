using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunShop.Processor.Factory;
using System.Collections.Generic;
using FunShop.Model;
using Moq;
using FunShop.Processor;
using System.Linq;

namespace FunShop.UnitTests
{
    [TestClass()]
    public class PurchaseOrderItemHandlerFactoryTests
    {
        [TestMethod]
        public void BuildProcessor_Product_GetsPurchaseOrderItemProcessor()
        {
            //Arrange
            var product = ProductFakes.GetVideo();
            var purchaseOrderItemHandlerFactory = new PurchaseOrderItemHandlerFactory();

            //Act
              var handler = purchaseOrderItemHandlerFactory.BuildHandler(product);

            //Assert
            Assert.IsInstanceOfType(handler, typeof(PurchaseOrderItemHandler<Product>));
            Assert.IsNotInstanceOfType(handler, typeof(PurchaseOrderItemHandler<ClubMembership>));

        }

        [TestMethod]
        public void BuildProcessor_ClubMembership_GetsMembershipOrderItemProcessor()
        {
            //Arrange
            var clubMembership = ClubMembershipFakes.GetBookClubMembership();
            var purchaseOrderItemHandlerFactory = new PurchaseOrderItemHandlerFactory();

            //Act
            var handler = purchaseOrderItemHandlerFactory.BuildHandler(clubMembership);

            //Assert
            Assert.IsInstanceOfType(handler, typeof(PurchaseOrderItemHandler<ClubMembership>));
            Assert.IsNotInstanceOfType(handler, typeof(PurchaseOrderItemHandler<Product>));
        }

    }
}
