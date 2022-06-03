using System;
namespace ClassLibrary
{
	public class Employee
	{
		public Employee()
		{
		}
		private string _name;
       		private string _surname;
        	private int _salary;

		public int Salary
        {
            get
            {
				return _salary;
            }
            set
            {
                if (value >= 250)
                {
                    _salary = value;
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                bool digitCheck = true;
                bool caseCheck = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]) == true)
                    {
                        digitCheck = false;
                        break;
                    }
                }

                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsUpper(value[i]) == true)
                    {
                        caseCheck = false;
                        break;
                    }
                }
                if (caseCheck == false && digitCheck == false && !string.IsNullOrWhiteSpace(value))
                {
                    _surname = value;
                }
            }
        }


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                bool digitCheck = true;
                bool caseCheck = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]) == true)
                    {
                        digitCheck = false;
                        break;
                    }
                }

                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsUpper(value[i]) == true)
                    {
                        caseCheck = false;
                        break;
                    }
                }
                if (caseCheck == false && digitCheck == false && !string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
            }
        }
    }
}

