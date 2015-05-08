using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeReportingSystem.ViewModels;
using AutoMapper;
using TimeReportingSystem.MapService;

namespace TimeReportingSystem.MapService
{
    public class CommonMapper : IMapper
    {
        static CommonMapper()
        {
            Mapper.CreateMap<Project, DetailsProjectViewModel>();
            Mapper.CreateMap<DetailsProjectViewModel, Project>();
        }

        public object Map(object source, Type sourceType, Type destinationType)
        {
            return Mapper.Map(source, sourceType, destinationType);
        }
    }
}