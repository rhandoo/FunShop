using FunShop.Processor.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Model
{
    public class PurchaseOrder
    {
        public int Id { get; private set; }

        public Customer Customer { get; private set; }

        private IList<PurchaseOrderItem> orderItems = new List<PurchaseOrderItem>();

        private readonly IPurchaseOrderItemHandlerFactory PurchaseOrderItemProcessorFactory;
        public PurchaseOrder(IPurchaseOrderItemHandlerFactory purchaseOrderItemProcessorFactory)
        {
            this.PurchaseOrderItemProcessorFactory = purchaseOrderItemProcessorFactory;
        }

        public void Generate()
        {
            foreach (var item in orderItems)
            {
                var handler = this.PurchaseOrderItemProcessorFactory.BuildHandler(item);
                handler.Process();
            }
        }

        public void AddItem(PurchaseOrderItem purchaseOrderItem)
        {
            orderItems.Add(purchaseOrderItem);
        }

        public void AddItem(IList<PurchaseOrderItem> purchaseOrderItems)
        {
            foreach(var item in purchaseOrderItems)
            {
                orderItems.Add(item);
            }
        }

        public decimal TotalCost { get { return this.orderItems.Sum(x => x.Cost); } }

    }
}
