using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPHome.Models
{
    public class Loan
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       /* [Required(ErrorMessage = "Required")]
        [Display(Name = "ProperityLocation")]*/
        /*public string ProperityLocation { get; set; }

        [Required(ErrorMessage = "Required")]*/
      /*  public string ProperityName { get; set; }
        public double ESAmount { get; set; }
        public string TypeofEmployeement { get; set; }
        public int Retirementage { get; set; }
        public string Organizationtype { get; set; }
        public string EmployerName { get; set; }*/
        public int EMI { get; set; }
        public float ROI { get; set; }
        public int Tenure { get; set; }
        public int LoanAmount { get; set; }
       /* public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string EmailId { get; set; }
        public int Phonenumber { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }

        public double Aadharnumber { get; set; }

        public double Panno { get; set; }
*/
    }
}