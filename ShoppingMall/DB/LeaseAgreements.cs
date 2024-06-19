using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall.DB
{
    public class LeaseAgreements
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public string DateOfConlusion { get; set; }
        public string Validity { get; set; }
        public string Rents { get; set; }
        public string TermsOfPayment { get; set; }
        public string DepositSize { get; set; }
        public string PremisesId { get; set; }
        public string TenantId { get; set; }
    }
}
