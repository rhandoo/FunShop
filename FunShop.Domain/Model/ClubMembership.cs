using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Model
{
    public abstract class ClubMembership: PurchaseOrderItem
    {
        public Customer Customer { get; private set; }

        public string Title { get; private set; }

        public ClubMembership(string title, Customer customer)
        {
            this.Title = title;
            this.Customer = customer;
        }
    }
}
