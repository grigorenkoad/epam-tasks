﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    class UserProject
    {
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public UserProject(int userId, int projectId)
        {
            this.UserId = userId;
            this.ProjectId = projectId;
        }
    }
}
