using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeReportingSystem.ViewMidels;

namespace TimeReportingSystem.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        BusinessLogic<ProjectsViewModel> text = new BusinessLogic<ProjectsViewModel>();
        public ActionResult Index()
        {
            List<ProjectsViewModel> model = text.GetAll();
            return View(model);
        }

    }
}
