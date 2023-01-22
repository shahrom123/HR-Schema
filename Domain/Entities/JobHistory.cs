﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobHistory
    {
        public int EmployeeId { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public int JobId { get; set; }
        public Job Jobs { get; set; }
        public Deparment Deparment { get; set; }
        public int DepatmentId { get; set; }
        public JobHistory() { }

        public JobHistory(int employeeId, DateTimeOffset startDate, DateTimeOffset endDate, int jobId, int depatmentId)
        {
            EmployeeId = employeeId;
            StartDate = startDate;
            EndDate = endDate;
            JobId = jobId;
            DepatmentId = depatmentId;
        }
    }
}
