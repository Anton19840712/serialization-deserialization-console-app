using Newtonsoft.Json;

namespace DeseSerialSample
{
	public class Address
	{
		public string Street { get; set; }
		public string City { get; set; }
	}

	public class Human
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}

	public class Person : Human
	{
		public Address Address { get; set; }
	}

	public class Employee : Person
	{
		public string EmployeeId { get; set; }
	}

	public class Company
	{
		public string Name { get; set; }
		public List<Employee> Employees { get; set; }
	}

	public class Scope
	{
		[JsonConverter(typeof(EmployeeConverter))]
		public Person Person { get; set; }
		public Company Company { get; set; }
	}
}
