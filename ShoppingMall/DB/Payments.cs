using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall.DB
{
    public class Payments
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public string Sum { get; set; }
        public string Purpose { get; set; }
        public string Status { get; set; }
        public string LeaseId { get; set; }
        public string TenantsId { get; set; }
    }
}
