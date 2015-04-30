using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TimeReportingSystem.ViewModels
{
    public class DetailsProjectViewModel
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        //public string UserName { get; set; }
        //public string TaskName { get; set; }
        
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}