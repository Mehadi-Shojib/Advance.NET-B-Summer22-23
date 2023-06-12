using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabTask1.Models;
namespace LabTask1.Controllers
{
    public class PortfolioController : Controller
    {
     
        public ActionResult Landing()
        {
            ViewBag.Name = "Mehadi Hasan Shojib";
            ViewBag.Email = "shojib8383@gmail.com";
            ViewBag.Bio = "Shojib's vision, determination, and relentless pursuit of success have established him as a prominent figure in the business world. Through his remarkable achievements and his dedication to making a positive impact, Shojib continues to leave an indelible mark on both the entrepreneurial landscape and the lives of those he touches";
            return View();
        }

        public ActionResult Myprofile()
        {
            var p1 = new Profile();
            p1.Name = "Mehadi Hasan";
            p1.Dob = "2000-01-11";
            p1.Nationalities = "Bangladeshi";
            p1.Address = "Tangail,Dhaka,Bangladesh";
            p1.Contact = "01700000000";
            p1.Hobbies =new string[] { "Football","Anime","Gym"};
            p1.Bgroup = "Ab+";
            return View(p1);
        }
        public ActionResult Education()
        {

            var e1 = new Educations();
            var e2 = new Educations();
            var e3 = new Educations();

            e1.Degree = "Bsc";
            e1.Ins = "AIUB";
            e1.Year = "2020-2024";

            e2.Degree = "HSC";
            e2.Ins = "Shaheen School and College";
            e2.Year = "2019";

            e3.Degree = "SSC";
            e3.Ins = "Shaheen School";
            e3.Year = "2016";

            ViewBag.Lists = new Educations[] { e1, e2, e3 };
            return View();
        }
        public ActionResult Project()
        {
            var p1 = new Projects();
            var p2 = new Projects();
            var p3 = new Projects();

            p1.Course = "OOP2";
            p1.Description = "University Book Management ";

            p2.Course = "Machine Learning";
            p2.Description = "Parkinsons Disease Classification";

            p3.Course = "Advamce WebTech";
            p3.Description = "Smart City Service";

            Projects[] List = new Projects[] { p1, p2, p3 };

            return View(List);
        }
        public ActionResult References()
        {

            ViewBag.Name1 = "Tanvir Sir";
            ViewBag.Phone1 = "0190210381024";
            ViewBag.Designation = "Lecturer, FST, AIUB";
            return View();
        }
    }
}