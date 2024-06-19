using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall.DB
{
    public class Tenants
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string INN { get; set; }
        public string ContactDetails { get; set; }
        public string KindOfActivity { get; set; }
        public string Category { get; set; }
        public string RentStartDate { get; set; }
        public string RentalTerm { get; set; }
    }
}
