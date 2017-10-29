using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Model
{
    public class VideoClubMembership: ClubMembership
    {
        private const decimal VIDEO_MEMBERSHIP_COST = 150;
        public VideoClubMembership(string title, Customer customer) : base(title, customer)
        {
            this.Cost = VIDEO_MEMBERSHIP_COST;
        }

        public override string GetDescription()
        {
            return "Video club membership";
        }
    }
}
