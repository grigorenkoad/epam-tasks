using AutoMapper;
using BL;
using DAL.Models;
using DAL.Repository;
using DAL.Repository.Contracts;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeReportingSystem.MapService;
using TimeReportingSystem.ViewMidels;
using TimeReportingSystem.ViewModels;

namespace TimeReportingSystem.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        IRepository<Project> repository = new JsonRepository<Project>();
        IRepository<Task> taskRepository = new JsonRepository<Task>();
        //private IMapper _temp;
        [Inject]
        public IMapper ModelMapper { get; set; }
        //public HomeController(IMapper temp)
        //{
        //    _temp = temp; 
        //}
        public ActionResult Index()
        {
            List<Project> model = repository.GetAll().ToList();
            Mapper.CreateMap<Project, ProjectsViewModel>();
            List<ProjectsViewModel> projectsView = Mapper.Map<List<Project>, List<ProjectsViewModel>>(model);
            return View(projectsView);
        }
        
        public ActionResult Details(int id)
        {
            var model = GetProjectsWithTasks();
            var detail = model.FirstOrDefault(x => x.ProjectId == id);
            //Project project = repository.FirstBy(x => x.ProjectId == id);
            
            //Mapper.CreateMap<Project, DetailsProjectViewModel>();
            //var detail = Mapper.Map<Project, DetailsProjectViewModel>(project);
            return View(detail);
        }

        private List<DetailsProjectViewModel> GetProjectsWithTasks()
        {


            IEnumerable<Project> projects = repository.GetAll();
            var model = new List<DetailsProjectViewModel>();
            foreach (var project in projects)
            {
                List<string> tasks = project.Tasks.Select(x => x.Name).ToList();
                model.Add(new DetailsProjectViewModel { ProjectId = project.ProjectId, 
                                                        Name = project.Name, 
                                                        Description = project.Description,
                                                        StartDate = project.StartDate,
                                                        EndDate = project.EndDate,
                                                        TaskName = tasks});
            }
            return model;
        }

        public ActionResult Settings()
        {
            return View();
        }

    }
}
