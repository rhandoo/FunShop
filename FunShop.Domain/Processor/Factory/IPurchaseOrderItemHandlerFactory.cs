using FunShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunShop.Processor;

namespace FunShop.Processor.Factory
{
    public interface IPurchaseOrderItemHandlerFactory
    {
        IPurchaseOrderItemHandler<PurchaseOrderItem> BuildHandler(PurchaseOrderItem purchaseOrderItem);
    }
}
