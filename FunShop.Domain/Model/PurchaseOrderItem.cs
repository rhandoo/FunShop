using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Model
{
    public abstract class PurchaseOrderItem
    {
        public Guid Id { get;  private set; }

        public decimal Cost { get; protected set; }

        public PurchaseOrderItem()
        {
            this.Id = new Guid();
        }

        public abstract string GetDescription();

    }
}
