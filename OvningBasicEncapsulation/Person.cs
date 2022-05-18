using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningBasicEncapsulation
{
	internal class Person
	{
		private string firstName;

		public string FirstName
		{
			get { return firstName; }
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
		}

		private int age;

		public int Age
		{
			get { return age; }
		}

		private decimal salary;

		public decimal Salary
		{
			get { return salary; }
		}


		public override string ToString()
		{
			//return $"{FirstName} {LastName} is {Age} years old.";
			return $"{FirstName} {LastName} recieves {Salary} years dollars.";
		}

		public Person(string firstName, string lastName, int age, decimal salary)
		{
			if (firstName.Length <= 3)
				throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
			if (lastName.Length <= 3)
				throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
			if (age <= 0)
				throw new ArgumentException("Age cannot be zero or a negative integer!");
			if (salary < 460)
				throw new ArgumentException("Salary cannot be less than 460 dollar!");

			this.firstName = firstName;
			this.lastName = lastName;
			this.age = age;
			this.salary = salary;
		}

		public void IncreaseSalary(decimal bonus)
		{
			if (age < 30)
				salary += bonus*salary/2.0m;
			else
				salary += bonus*salary;
		}
	}
}
