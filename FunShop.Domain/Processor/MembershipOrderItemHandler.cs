using FunShop.Model;
using FunShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Processor
{
    public class MembershipOrderItemHandler : PurchaseOrderItemHandler<ClubMembership>
    {
        private readonly ICustomerActivationService CustomerActivationService;

        public MembershipOrderItemHandler(ClubMembership clubMembership) : this(clubMembership, new CustomerActivationService())
        {
        }

        public MembershipOrderItemHandler(ClubMembership clubMembership, ICustomerActivationService customerActivationService) : base(clubMembership)
        {
            this.CustomerActivationService = customerActivationService;
        }

        protected override void ProcessItem(ClubMembership clubMembership)
        {
            this.CustomerActivationService.ActivateCustomer(clubMembership);
        }
    }
}
