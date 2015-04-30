using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TaskId { get; set; }

        //public virtual Task Task { get; set; }
        public Project(int projectId, string name, string description, DateTime startDate, DateTime endDate, int taskId)
        {
            this.ProjectId = projectId;
            this.Name = name;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TaskId = taskId;
        }
    }
}
