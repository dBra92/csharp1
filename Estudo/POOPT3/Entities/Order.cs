using System;
using POOPT3.Entities.Enums;

namespace POOPT3.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + "," + Moment + ", " + Status;
        }
    }
}