using Newtonsoft.Json;

namespace DeseSerialSample;

public class TestFunctionality
{
	public void Serialize<T>(T obj, string filename)
	{
		var projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
		var fullPath = Path.Combine(projectDirectory, filename);
		var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
		File.WriteAllText(fullPath, json);
	}

	public T Deserialize<T>(string filename)
	{
		var projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
		var fullPath = Path.Combine(projectDirectory, filename);

		var json = File.ReadAllText(filename);
		return JsonConvert.DeserializeObject<T>(json);
	}
}