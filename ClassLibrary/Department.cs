using System;
namespace ClassLibrary
{
	public class Department
	{
		public Department()
		{
		}
		protected internal string Name;

		protected internal int EmployeeLimit;

		protected internal int SalaryLimit;

		protected internal Employee[] employees = new Employee[0];


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

