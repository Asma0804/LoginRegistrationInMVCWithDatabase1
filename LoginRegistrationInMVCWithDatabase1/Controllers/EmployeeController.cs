using LoginRegistrationInMVCWithDatabase1.Models;
using LoginRegistrationInMVCWithDatabase1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginRegistrationInMVCWithDatabase1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
            public ActionResult Details()
            {
                loginEntities databasecontext    = new loginEntities();                 

                var loginList = (from login in databasecontext.RegisterUsers
                                  select login).ToList();
                return View(loginList);
            }
    }
    

}