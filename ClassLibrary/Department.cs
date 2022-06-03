using System;
namespace ClassLibrary
{
	public class Department
	{
		public Department()
		{
		}
		public string Name;

		public int EmployeeLimit;

		public int SalaryLimit;

		public Employee[] employees = new Employee[0];


		public void AddEmployee(Employee employee)
        {
            if (employees.Length <= EmployeeLimit)
            {
				Array.Resize(ref employees, employees.Length + 1);
				employees[employees.Length - 1] = employee;
            }
        }
	

	}
}

