namespace DeseSerialSample
{
	class Address
	{
		public string Street { get; set; }
		public string City { get; set; }
	}

	class Human
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}

	class Person : Human
	{
		public Address Address { get; set; }
	}

	class Employee : Person
	{
		public string EmployeeId { get; set; }
	}

	class Company
	{
		public string Name { get; set; }
		public List<Employee> Employees { get; set; }
	}

	class Scope
	{
		private Person _person;

		public Person Person
		{
			get => _person;
			set
			{
				if (value is Employee)
				{
					_person = value;
				}
				else
				{
					throw new ArgumentException("Person must be of type Employee");
				}
			}
		}

		public Company Company { get; set; }
	}
}
