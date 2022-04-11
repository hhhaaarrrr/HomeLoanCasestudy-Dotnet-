using ASPHome.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ASPLoan.Controllers
{

    public class HomeController : Controller
    {
        private MyDbContext db = new MyDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       /* public ActionResult About()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/


        public ActionResult Calcu()
        {
            return View(new Calculation());
        }

        [HttpPost]
        public ActionResult calcu(Calculation u)
        {
           
            u.LoanAmount = (int)(float)(60 * (0.6 * u.Salary));
            u.ROI = 0.085;
            //   u.ROI = (int)(float)0.085;

              db.Calculations.Add(u);

             db.SaveChanges();

            return View(u);
        }
       
        /* public ActionResult Ecalculation()
         {
             return View(new Details());
         }
 */
        public ActionResult Ecalculation(Calculation u)
        {
            u.ROI = 0.085;

            u.EMI = u.LoanAmount * u.ROI * (1 + u.ROI) * u.loantenure / ((1 + u.ROI) * u.loantenure - 1);
            db.Calculations.Add(u);
            
          //  db.SaveChanges();

            return View(u);
        }


        /*public ActionResult Tracking(Personal u)
        {

            var obj = db.PersonalDetailss.Where(x => x.Id.Equals(u.Id) && x.Phonenumber.Equals(u.Phonenumber)).FirstOrDefault();
            if (obj != null)
            {
                return View("Message");
            }
            else if (u.Id == 234 && u.Phonenumber == 23456)
            {
                return View("Message2");
            }
            return View();
        }



       
      

       
        public ActionResult Message()
        {
            return View();
        }

        public ActionResult Message2()
        {
            return View();
        }
*/
        public ActionResult Document()
        {
            return View("Document");
        }
        [HttpPost]
        public ActionResult Document(User user)
        {


            if (user.File != null)
            {
                string path = Server.MapPath("~/App_Data/File");
                string fileName = Path.GetFileName(user.File.FileName);
                string fullPath = Path.Combine(path, fileName);
                user.File.SaveAs(fullPath);

            }
            else if (user.PanCard != null)
            {
                string path = Server.MapPath("~/App_Data/PanCard");
                string fileName = Path.GetFileName(user.PanCard.FileName);
                string fullPath = Path.Combine(path, fileName);
                user.PanCard.SaveAs(fullPath);

            }
            else if (user.VoterId != null)
            {
                string path = Server.MapPath("~/App_Data/VoterId");
                string fileName = Path.GetFileName(user.VoterId.FileName);
                string fullPath = Path.Combine(path, fileName);
                user.VoterId.SaveAs(fullPath);

            }
            else if (user.SalarySlip != null)
            {
                string path = Server.MapPath("~/App_Data/SalarySlip");
                string fileName = Path.GetFileName(user.SalarySlip.FileName);
                string fullPath = Path.Combine(path, fileName);
                user.SalarySlip.SaveAs(fullPath);

            }
            else if (user.LOA != null)
            {
                string path = Server.MapPath("~/App_Data/LOA");
                string fileName = Path.GetFileName(user.LOA.FileName);
                string fullPath = Path.Combine(path, fileName);
                user.LOA.SaveAs(fullPath);

            }
            else if (user.NOCFromBuilder != null)
            {
                string path = Server.MapPath("~/App_Data/NOCFromBuilder");
                string fileName = Path.GetFileName(user.NOCFromBuilder.FileName);
                string fullPath = Path.Combine(path, fileName);
                user.NOCFromBuilder.SaveAs(fullPath);

            }
            else if (user.AgreementToSale != null)
            {
                string path = Server.MapPath("~/App_Data/AgreementToSale");
                string fileName = Path.GetFileName(user.AgreementToSale.FileName);
                string fullPath = Path.Combine(path, fileName);
                user.AgreementToSale.SaveAs(fullPath);

            }

            else
            {
                return View("U have to upload the file");

            }


            return View("info");
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Index");
        }

    }
}
