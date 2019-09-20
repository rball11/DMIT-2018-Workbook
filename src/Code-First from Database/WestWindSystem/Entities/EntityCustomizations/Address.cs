using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindSystem.Entities //change .entities.entitycustomizations to .entities to directly affect .entities address class
{
    public partial class Address
    {
        [NotMapped] //means that it is NOT a column in the db table
        public string FullAddress
        {
            get
            {
                string result = $"{Address1}, {City}, {Country}";
                return result;
            }
        }
    }
}
