using Newtonsoft.Json;

namespace DeseSerialSample;

public class TestFunctionality
{
	public void Serialize<T>(T obj, string filename)
	{
		var fullPath = Path.Combine(Directory.GetCurrentDirectory(), filename);
		var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
		File.WriteAllText(fullPath, json);
	}

	public T Deserialize<T>(string filename)
	{
		var json = File.ReadAllText(filename);
		return JsonConvert.DeserializeObject<T>(json);
	}
}