using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    class Task
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string State { get; set; }
        public int TaskReportId { get; set; }

        public Task(int taskId, string name, string description, DateTime startDate, DateTime endDate, string state, int taskReportId)
        {
            this.TaskId = taskId;
            this.Name = name;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.State = state;
            this.TaskReportId = taskReportId;
        }
    }
}
