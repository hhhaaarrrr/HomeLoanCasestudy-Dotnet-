using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASPHome.Models
{
    public class SignIn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string User_Name { get; set; }
        public string User_EmailId { get; set; }
        public string Password { get; set; }
        public string Conformword { get; set; }
    }
}