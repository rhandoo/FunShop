using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunShop.Model;

namespace FunShop.Processor.Factory
{
    public class PurchaseOrderItemHandlerFactory : IPurchaseOrderItemHandlerFactory
    {
        //private readonly IDictionary<Type, object> PurchaseOrderItemProcessors;

        public PurchaseOrderItemHandlerFactory()
        {
            //  this.PurchaseOrderItemProcessors = new Dictionary<Type, object>();
        }

        public IPurchaseOrderItemHandler<PurchaseOrderItem> BuildHandler(PurchaseOrderItem purchaseOrderItem)
        {
            var purchaseOrderItemType = purchaseOrderItem.GetType().BaseType;

            if (purchaseOrderItemType == typeof(ClubMembership))
            {
                return new MembershipOrderItemHandler(purchaseOrderItem as ClubMembership);
            }
            if (purchaseOrderItemType == typeof(Product))
            {
                return new ProductOrderItemHandler(purchaseOrderItem as Product);
            }

            throw new Exception("purchaseOrderItem not handled");
        }

        //public IPurchaseOrderItemProcessor<PurchaseOrderItem> BuildProcessor_Old(PurchaseOrderItem purchaseOrderItem)
        //{

        //    var processor = this.PurchaseOrderItemProcessors.FirstOrDefault(p => p.Key == purchaseOrderItem.GetType().BaseType);
        //    if (processor.Key == null)
        //    {
        //        throw new Exception("Processor not registeted for Purchaseorderitem");
        //    }

        //    return processor.Value as IPurchaseOrderItemProcessor<PurchaseOrderItem>;
        //}

        //private void RegisterProcessors()
        //{
        //    this.PurchaseOrderItemProcessors.Add(typeof(Product), new MembershipOrderItemProcessor());
        //    this.PurchaseOrderItemProcessors.Add(typeof(ClubMembership), new ProductOrderItemProcessor());
        //}

    }
}