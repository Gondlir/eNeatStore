using eNeatStore.Domain.StoreContext.Enums;

namespace eNeatStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        public EDeliveryStatus DeliveryStatus { get; private set; }
    }
}