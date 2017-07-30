using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalManagement.Models;

namespace HospitalManagement.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            LoginModel obj = new LoginModel();
            
            return View(obj);
        }
        [HttpPost]
        public ActionResult Index(LoginModel objlogin)
        {
            

            return View(objlogin);
        }
    }
}