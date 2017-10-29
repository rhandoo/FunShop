using FunShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Processor
{
    public abstract class PurchaseOrderItemHandler<T> : IPurchaseOrderItemHandler<T> where T:PurchaseOrderItem
    {
        private readonly T PurchaseOrderItem;

        protected PurchaseOrderItemHandler(T purchaseOrderItem)
        {
            this.PurchaseOrderItem = purchaseOrderItem;
        }

        public void Process()
        {
            this.ProcessItem(PurchaseOrderItem);
        }

        protected abstract void ProcessItem(T purchaseOrderItem);
    }
}
