using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRegistiration.Context;
using UserRegistiration.Models;

namespace UserRegistiration.Controllers
{
    public class HomeController : Controller
    {
        UserRegistrationEntities entities = new UserRegistrationEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StarbucksRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StarbucksRegister(StarbucksUserModel model)
        {
            StarbucksUserModel user = new StarbucksUserModel();
            var status = user.MernisVerification(model.tcNo, model.birth_of_date,model.name, model.surname);

            if (status)
            {
                // Veri tabanına kayıt edilecek
                StarbucksUser starbucksUser = new StarbucksUser
                {
                    Name = model.name,
                    Surname = model.surname,
                    TcNo = model.tcNo,
                    BirthOfDate = model.birth_of_date

                };
                entities.StarbucksUsers.Add(starbucksUser);
                entities.SaveChanges();
                return RedirectToAction("Success");
            }
            else
            {
                return RedirectToAction("Failed");

            }
 
        }

        public ActionResult PortalRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PortalRegister(PortalUserModel model)
        {
            // Veritabanına kayıt edilecek
            PortalUser portalUser = new PortalUser
            {
                Name = model.name,
                Surname = model.surname,
                BirthOfDate = model.birth_of_date,
                TcNo = model.tcNo
            };
            entities.PortalUsers.Add(portalUser);
            entities.SaveChanges();
            return RedirectToAction("Success");
        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Failed()
        {
            return View();
        }


    }
}