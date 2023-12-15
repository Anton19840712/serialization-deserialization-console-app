using JsonSubTypes;
using Newtonsoft.Json;
using test_sample_second;

var json = "[{\"Department\":\"Department1\",\"JobTitle\":\"JobTitle1\",\"FirstName\":\"FirstName1\",\"LastName\":\"LastName1\"}," +
		   "{\"Department\":\"Department1\",\"JobTitle\":\"JobTitle1\",\"FirstName\":\"FirstName2\",\"LastName\":\"LastName2\"}," +
		   "{\"Skill\":\"Painter\",\"FirstName\":\"FirstName3\",\"LastName\":\"LastName3\"}]";

var settings = new JsonSerializerSettings();
settings.Converters.Add(JsonSubtypesWithPropertyConverterBuilder
	.Of(typeof(Person))
	.RegisterSubtypeWithProperty(typeof(Employee), "JobTitle")
	.RegisterSubtypeWithProperty(typeof(Artist), "Skill")
	.Build());

var persons = JsonConvert.DeserializeObject<IReadOnlyCollection<Person>>(json);

foreach (var person in persons)
{
	Console.WriteLine(person.FirstName);
}



