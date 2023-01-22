using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone_Number { get; set; }
        public DateTimeOffset HireDate { get; set; }
        public int JobId { get; set; }
        public int Salary { get; set; }
        public int CommissionPcT { get; set; }
        public int ManagerId { get; set; }
        public int DepartmentId { get; set; }

        public EmployeeDto() { }

        public EmployeeDto(int id, string firstName, string lastName, string email,
            DateTimeOffset hireDate, int jobId, int salary, int commissionPcT,
            int managerId, int departmentId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            HireDate = hireDate;
            JobId = jobId;
            Salary = salary;
            CommissionPcT = commissionPcT;
            ManagerId = managerId;
            DepartmentId = departmentId;
        }
    }
}
