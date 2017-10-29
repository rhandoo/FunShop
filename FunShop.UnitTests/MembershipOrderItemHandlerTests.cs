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
    public class MembershipOrderItemHandlerTests
    {
        private Mock<ICustomerActivationService> mockCustomerActivationService;

        [TestInitialize]
        public void Setup()
        {
            mockCustomerActivationService = new Mock<ICustomerActivationService>();
        }

        [TestMethod]
        public void ProcessItem_CustomerActivationService_IsCalled()
        {
            //Arrange
            mockCustomerActivationService.Setup(x => x.ActivateCustomer(It.IsAny<ClubMembership>()));
            var membershipOrderItemProcessor = new MembershipOrderItemHandler(ClubMembershipFakes.GetBookClubMembership(), mockCustomerActivationService.Object);

            //Act
            membershipOrderItemProcessor.Process();

            //Assert
            mockCustomerActivationService.Verify(s => s.ActivateCustomer(It.IsAny<ClubMembership>()));

        }

    }
}
