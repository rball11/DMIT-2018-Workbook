using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindSystem.DAL;
using WestWindSystem.DataModels;

namespace WestWindSystem.BLL
{
    public class OrderProcessingController
    {
        public List<OutstandingOrder> LoadOrders(int supplierId)
        {
            //        Validation:
            //            Make sure the SupplierID exists, otherwise throw an exception.
            //            [Advanced:] Make sure the logged-in user works for the identified supplier.
            //            Query for outstanding orders, getting data from the following tables:
            //TODO: List table names
            throw new NotImplementedException();
        }
        public List<ShipperSelection> ListShippers()
        {
            using (var context = new WestWindContext())
            {
                var result = from shipper in context.Shippers
                             select new ShipperSelection
                             {
                                 ShipperId = shipper.ShipperID,
                                 Shipper = shipper.CompanyName
                             };
                return result.ToList();
            }
        }

        #region Commands
        public void ShipOrder(int orderId, ShippingDirections shipping, List<ShippedItem> items)
        {
            throw new NotImplementedException();
            //TODO: Validation steps
            /*
                OrderID must be valid
                ShippingDirections is required (cannot be null)
                List<ShippedItem> cannot be empty/null
                The products must be on the order AND items that this supplier provides
                Quantities must be greater than zero and less than or equal to the quantity outstanding
                Shipper must exist
                Freight charge must be either null (no charge) or > $0.00
             */
            //TODO: tables that must be updated/inserted/deleted/etc
            /*
                Create new Shipment
                Add all manifest items
                Check if order is complete; if so, update Order.Shipped
             */
        }
        #endregion
    }
}
