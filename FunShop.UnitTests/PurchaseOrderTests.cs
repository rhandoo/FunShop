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
    public class PurchaseOrderTests
    {

        private Mock<IPurchaseOrderItemHandlerFactory> mockPrchaseOrderItemProcessorFactory;

        [TestInitialize]
        public void Setup()
        {
            mockPrchaseOrderItemProcessorFactory = new Mock<IPurchaseOrderItemHandlerFactory>();
        }

        [TestMethod]
        public void Generate_BookPuchaseOrder_IsSuccessfull()
        {
            //Arrange
            mockPrchaseOrderItemProcessorFactory.Setup(x => x.BuildHandler(It.IsAny<PurchaseOrderItem>())).Returns(new ProductOrderItemHandler(ProductFakes.GetBook()));
            var purchaseOrder = new PurchaseOrder(mockPrchaseOrderItemProcessorFactory.Object);
            purchaseOrder.AddItem(ProductFakes.GetBooks());

            try
            {
                //Act
                purchaseOrder.Generate();
            }
            catch (Exception)
            {
                //Assert
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Generate_VideoPuchaseOrder_IsSuccessfull()
        {
            //Arrange
            mockPrchaseOrderItemProcessorFactory.Setup(x => x.BuildHandler(It.IsAny<PurchaseOrderItem>())).Returns(new ProductOrderItemHandler(ProductFakes.GetVideo()));
            var purchaseOrder = new PurchaseOrder(mockPrchaseOrderItemProcessorFactory.Object);
            purchaseOrder.AddItem(ProductFakes.GetVideos());

             
            try
            {
                //Act
                purchaseOrder.Generate();
            }
            catch (Exception)
            {
                //Assert
                Assert.Fail();
            }

        }

        [TestMethod]
        public void Generate_BookAndVideoPuchaseOrder_IsSuccessfull()
        {
            //Arrange
            mockPrchaseOrderItemProcessorFactory.Setup(x => x.BuildHandler(It.IsAny<PurchaseOrderItem>())).Returns(new ProductOrderItemHandler(ProductFakes.GetVideo()));
            var purchaseOrder = new PurchaseOrder(mockPrchaseOrderItemProcessorFactory.Object);
            purchaseOrder.AddItem(ProductFakes.GetVideos());
            purchaseOrder.AddItem(ProductFakes.GetBooks());

            try
            {
                //Act
                purchaseOrder.Generate();
            }
            catch (Exception)
            {
                //Assert
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Generate_BookClubMembershipPurchaseOrder_IsSuccessfull()
        {
            // Arrange
            mockPrchaseOrderItemProcessorFactory.Setup(x => x.BuildHandler(It.IsAny<PurchaseOrderItem>())).Returns(new MembershipOrderItemHandler(ClubMembershipFakes.GetBookClubMembership()));
            var purchaseOrder = new PurchaseOrder(mockPrchaseOrderItemProcessorFactory.Object);
            purchaseOrder.AddItem(ClubMembershipFakes.GetBookClubMemberships());
            try
            {
                //Act
                purchaseOrder.Generate();
            }
            catch (Exception)
            {
                //Assert
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Generate_VideoClubMembershipPurchaseOrder_IsSuccessfull()
        {
            //Arrange
            mockPrchaseOrderItemProcessorFactory.Setup(x => x.BuildHandler(It.IsAny<PurchaseOrderItem>())).Returns(new MembershipOrderItemHandler(ClubMembershipFakes.GetVideoClubMembership()));
            var purchaseOrder = new PurchaseOrder(mockPrchaseOrderItemProcessorFactory.Object);
            purchaseOrder.AddItem(ClubMembershipFakes.GetVideoClubMemberships());

            try
            {
                //Act
                purchaseOrder.Generate();
            }
            catch (Exception)
            {
                //Assert
                Assert.Fail();
            }

        }

        [TestMethod]
        public void Generate_UltimateClubMembershipPurchaseOrder_IsSuccessfull()
        {
            //Arrange
            mockPrchaseOrderItemProcessorFactory.Setup(x => x.BuildHandler(It.IsAny<PurchaseOrderItem>())).Returns(new MembershipOrderItemHandler(ClubMembershipFakes.GetUltimateClubMembership()));
            var purchaseOrder = new PurchaseOrder(mockPrchaseOrderItemProcessorFactory.Object);
            purchaseOrder.AddItem(ClubMembershipFakes.GetUltimateClubMemberships());

            try
            {
                //Act
                purchaseOrder.Generate();
            }
            catch (Exception)
            {
                //Assert
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Generate_ProductAndClubMembershipPurchaseOrder_IsSuccessfull()
        {
            //Arrange
            mockPrchaseOrderItemProcessorFactory.Setup(x => x.BuildHandler(It.IsAny<PurchaseOrderItem>())).Returns(new MembershipOrderItemHandler(ClubMembershipFakes.GetVideoClubMembership()));
            var purchaseOrder = new PurchaseOrder(mockPrchaseOrderItemProcessorFactory.Object);
            purchaseOrder.AddItem(ClubMembershipFakes.GetVideoClubMemberships());
            purchaseOrder.AddItem(ProductFakes.GetBooks());
            purchaseOrder.AddItem(ProductFakes.GetVideos());
            purchaseOrder.AddItem(ClubMembershipFakes.GetBookClubMemberships());

            try
            {
                //Act
                purchaseOrder.Generate();
            }
            catch (Exception)
            {
                //Assert
                Assert.Fail();
            }

        }

        [TestMethod]
        public void Generate_ClubMembershipPurchaseOrder_TotalCostIsValid()
        {
            //Arrange
            mockPrchaseOrderItemProcessorFactory.Setup(x => x.BuildHandler(It.IsAny<PurchaseOrderItem>())).Returns(new MembershipOrderItemHandler(ClubMembershipFakes.GetVideoClubMembership()));
            var purchaseOrder = new PurchaseOrder(mockPrchaseOrderItemProcessorFactory.Object);

            var clubmembership = ClubMembershipFakes.GetVideoClubMemberships();
            decimal cost = clubmembership.Sum(x => x.Cost);
            purchaseOrder.AddItem(clubmembership);

            //Act
            purchaseOrder.Generate();

            //Assert
            Assert.IsTrue(cost == purchaseOrder.TotalCost);

        }

        [TestMethod]
        public void Generate_ProductPurchaseOrder_TotalCostIsValid()
        {
            //Arrange
            mockPrchaseOrderItemProcessorFactory.Setup(x => x.BuildHandler(It.IsAny<PurchaseOrderItem>())).Returns(new ProductOrderItemHandler(ProductFakes.GetBook()));
            var purchaseOrder = new PurchaseOrder(mockPrchaseOrderItemProcessorFactory.Object);
            var product = ProductFakes.GetBooks();
            decimal cost = product.Sum(x => x.Cost);
            purchaseOrder.AddItem(product);


            //Act 
            purchaseOrder.Generate();

            //Assert
            Assert.IsTrue(cost == purchaseOrder.TotalCost);

        }
    }
}
