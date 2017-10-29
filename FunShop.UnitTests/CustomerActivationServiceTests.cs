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
    public class CustomerActivationServiceTests
    {

        [TestMethod]
        public void ActivateCustomer_ClubMembership_IsSuccessfull()
        {
            //Arrange
            var clubMembership = ClubMembershipFakes.GetBookClubMembership();
            var customerActivationService = new CustomerActivationService();

            
            try
            {
                //Act 
                customerActivationService.ActivateCustomer(clubMembership);
            }
            catch (Exception)
            {
                //Assert
                Assert.Fail();
            }
        }
    }
}
