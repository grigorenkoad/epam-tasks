﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeReportingSystem.ViewMidels
{
    public class ProjectsViewModel
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TaskId { get; set; }
    }
}