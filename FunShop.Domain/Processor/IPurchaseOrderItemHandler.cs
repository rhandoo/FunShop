using FunShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunShop.Processor
{
    public interface IPurchaseOrderItemHandler<out T> where T : PurchaseOrderItem
    {
        void Process();
    }
}
