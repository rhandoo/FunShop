using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Model
{
    public class BookClubMembership : ClubMembership
    {
        private const decimal BOOK_MEMBERSHIP_COST = 100;
        public BookClubMembership(string title, Customer customer) : base(title, customer)
        {
            this.Cost = BOOK_MEMBERSHIP_COST;
        }

        public override string GetDescription()
        {
            return "Book club membership";
        }
    }
}
