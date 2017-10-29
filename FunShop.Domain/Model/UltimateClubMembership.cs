using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Model
{
    public class UltimateClubMembership : ClubMembership
    {
        private const decimal ULTIMATE_MEMBERSHIP_COST = 250;
        public UltimateClubMembership(string title, Customer customer) : base(title, customer)
        {
            this.Cost = ULTIMATE_MEMBERSHIP_COST;
        }

        public override string GetDescription()
        {
            return "Ultimate club membership";
        }
    }
   
}
