using DeseSerialSample;

var action = new TestFunctionality();

// Data sample:
var address = new Address { Street = "123 Main St", City = "City" };
var employee = new Employee { Name = "John Doe", Age = 30, Address = address, EmployeeId = "EMP001" };
var company = new Company { Name = "Tech Co", Employees = new List<Employee> { employee } };

var modelExample = new Scope { Person = employee, Company = company };


// Serialization:
action.Serialize(modelExample, "serialized_model.json");
Console.WriteLine("Model serialized into a file 'serialized_model.json'");

// Deserialization:
var loadedModel = action.Deserialize<Scope>("serialized_model.json");
Console.WriteLine("Model loaded from a file successfully");

// Output:
Console.WriteLine("\nLoaded model output:");
Console.WriteLine($"Person Name: {loadedModel.Person.Name}");
Console.WriteLine($"Employee ID: {((Employee)loadedModel.Person).EmployeeId}");
Console.WriteLine($"Company Name: {loadedModel.Company.Name}");
Console.WriteLine($"Employee Count in Company: {loadedModel.Company.Employees.Count}");

