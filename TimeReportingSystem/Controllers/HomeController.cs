using AutoMapper;
using BL;
using DAL.Models;
using DAL.Repository;
using DAL.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeReportingSystem.ViewMidels;
using TimeReportingSystem.ViewModels;

namespace TimeReportingSystem.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        IRepository<Project> repository = new JsonRepository<Project>();
        public ActionResult Index()
        {
            List<Project> model = repository.GetAll().ToList();
            Mapper.CreateMap<Project, ProjectsViewModel>();
            List<ProjectsViewModel> projectsView = Mapper.Map<List<Project>, List<ProjectsViewModel>>(model);
            return View(projectsView);
        }

        public ActionResult Details(int id)
        {
            Project project = repository.FirstBy(x => x.ProjectId == id);
            Mapper.CreateMap<Project, DetailsProjectViewModel>();
            var detail = Mapper.Map<Project, DetailsProjectViewModel>(project);
            return View(detail);
        }

    }
}
