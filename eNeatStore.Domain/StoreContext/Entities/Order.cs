using System;
using System.Collections.Generic;
using System.Linq;
using eNeatStore.Domain.StoreContext.Enums;

namespace eNeatStore.Domain.StoreContext.Entities
{
    public class Order
    {
        private readonly IList<OrderItem> _orderItem;
        public Order(Customer customer)
        {
            Customer = customer;
            Number = Guid.NewGuid();
            Status = EOrderStatus.Created;
            CreatedDate = DateTime.Now;
            _orderItem = new List<OrderItem>();
        }
        public Customer Customer { get; private set; }
        public Guid Number { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public IReadOnlyCollection<OrderItem> Items => _orderItem.ToArray();

        public void AddItem()
        {

        }
        public void RemoveItem()
        {

        }
    }
}