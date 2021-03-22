namespace eNeatStore.Domain.StoreContext.Enums
{
    public enum EOrderStatus
    {
        Created = 0,
        AwaitingPayment = 1,
        Payd = 2,
        Shipped = 3,
        OrderCanceled = 4,
    }
}