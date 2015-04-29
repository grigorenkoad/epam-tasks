using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    class TaskReport
    {
        public int TaskReportId { get; set; }
        public DateTime DateOfReport { get; set; }
        public int Effort { get; set; }
        public DateTime TimeCreatedOrEdited { get; set; }

        public TaskReport(int taskReportId, DateTime dateOfReport, int Effort, DateTime timeCreatedOrEdited)
        {
            this.TaskReportId = taskReportId;
            this.DateOfReport = dateOfReport;
            this.Effort = Effort;
            this.TimeCreatedOrEdited = timeCreatedOrEdited;
        }
    }
}
