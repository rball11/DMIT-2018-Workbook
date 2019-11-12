using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindSystem.DataModels
{
    public class ShippingDirections
    {
        public int ShipperId { get; set; }
        public string TrackingCode { get; set; }
        public decimal? FreightCharge { get; set; }
    }
    //public class ShippedItem
    //{
    //    public int ProductId { get; set; }
    //    public int ShipQuantity { get; set; }
    //}
    public class ShipperSelection
    {
        public int ShipperId { get; set; }
        public string Shipper { get; set; }
    }
    public class OutstandingOrder
    {
        public int OrderId { get; set; }
        public string ShipToName { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredBy { get; set; }
        public int DaysRemaining { get; } // Calculated
        public IEnumerable<OrderItem> OutstandingItems { get; set; }
        public string FullShippingAddress { get; set; }
        public string Comments { get; set; }
    }
    public class OrderItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public short Qty { get; set; }
        public string QtyPerUnit { get; set; }
        public short Outstanding { get; set; } // Calculated as OD.Quantity - Sum(Shipped qty)
    }
}
