using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPHome.Models
{
    public class Calculation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string CustomerName { get; set; }
        public double Salary { get; set; }
        public double ROI { get; set; }
        public double loantenure { get; set; }
        public double EMI { get; set; }
        public double LoanAmount { get; set; }
    }
}