using System;
using eNeatStore.Domain.StoreContext.Enums;

namespace eNeatStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public Delivery(EDeliveryStatus deliveryStatus, DateTime createdDate, DateTime estimatedDate)
        {
            DeliveryStatus = EDeliveryStatus.Waiting;
            CreatedDate = DateTime.Now;
            EstimatedDate = DateTime.Now.AddDays(5);
        }

        public EDeliveryStatus DeliveryStatus { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime EstimatedDate { get; private set; }
    }
}