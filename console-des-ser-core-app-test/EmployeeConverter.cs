using DeseSerialSample;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class EmployeeConverter : JsonConverter<Employee>
{
	public override Employee ReadJson(JsonReader reader, Type objectType, Employee existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		var jObject = JObject.Load(reader);
		if (jObject["EmployeeId"] != null)
		{
			return jObject.ToObject<Employee>();
		}
		else
		{
			// Handle the case where the object is of type Person
			// You can throw an exception, return null, or handle it in another way
			throw new InvalidOperationException("Invalid JSON data. Expected Employee but found Person.");
		}
	}

	public override void WriteJson(JsonWriter writer, Employee value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}