using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructre.Services
{
    public class EmployeeService
    {
        private readonly DataContext _context;
        public EmployeeService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<EmployeeDto>> Get()
        {
            var employee = _context.Employees.Select(x => new EmployeeDto
            {
                Id = x.Id,
                FirstName= x.FirstName,
                LastName= x.LastName,
                Email= x.Email,
                HireDate= x.HireDate,
                JobId= x.JobId,
                Salary= x.Salary,
                CommissionPcT = x.CommissionPcT,
                ManagerId= x.ManagerId,
                DepartmentId= x.DepartmentId,

        }).ToList();
            return  employee;
        }
        public  async Task<EmployeeDto> Add(EmployeeDto employeeDto)
        {
            try
            {
                var location = new Employee(employeeDto.Id, employeeDto.FirstName, employeeDto.LastName,
              employeeDto.Email, employeeDto.HireDate, employeeDto.JobId, employeeDto.Salary,
              employeeDto.CommissionPcT, employeeDto.ManagerId, employeeDto.DepartmentId);
                _context.Add(location);
                _context.Employees.Add(location);
                var x = await _context.SaveChangesAsync();
                if (x == 0) return null;
                return employeeDto; 

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<EmployeeDto> Update(EmployeeDto employeeDto)
        {
            try
            {
                var region = _context.Employees.Find(employeeDto.Id);
                if (region == null) return null;
                region.Id = employeeDto.Id;
                region.FirstName = employeeDto.FirstName;
                region.LastName = employeeDto.LastName;
                region.Email = employeeDto.Email;
                region.HireDate = employeeDto.HireDate;
                region.JobId = employeeDto.JobId;
                region.Salary = employeeDto.Salary;
                region.CommissionPcT = employeeDto.CommissionPcT;
                region.ManagerId = employeeDto.ManagerId;
                region.DepartmentId = employeeDto.DepartmentId;
                _context.SaveChangesAsync();
                return employeeDto;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                throw;
            }
          
        }
        public bool Delete(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null) return false;
            _context.Employees.Remove(employee);
            _context.SaveChangesAsync();
            return true;
        }
    }
}
