using Newtonsoft.Json.Serialization;

namespace test_sample_third_safe;

public class MySerializationBinder : ISerializationBinder
{
	private readonly IList<Type> _knownTypes;
	public MySerializationBinder(IList<Type> knowTypes)
	{
		_knownTypes = knowTypes;
	}
	public void BindToName(Type serializedType, out string assemblyName, out string typeName)
	{
		assemblyName = serializedType.Assembly.FullName;
		typeName = serializedType.FullName;
	}
	public Type BindToType(string assemblyName, string typeName)
	{
		return _knownTypes?.SingleOrDefault(t => t.Name == typeName || t.FullName == typeName)!;
	}
}