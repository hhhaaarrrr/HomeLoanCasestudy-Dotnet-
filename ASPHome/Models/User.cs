using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPHome.Models
{
    public class User
    {
        public string Name { get; set; }
        public HttpPostedFileBase File { get; set; }

        public HttpPostedFileBase PanCard { get; set; }
        public HttpPostedFileBase VoterId { get; set; }
        public HttpPostedFileBase SalarySlip { get; set; }
        public HttpPostedFileBase LOA { get; set; }
        public HttpPostedFileBase NOCFromBuilder { get; set; }
        public HttpPostedFileBase AgreementToSale { get; set; }
    }
}