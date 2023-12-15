using System.Collections.Immutable;

namespace test_sample_third_safe;

public class PayloadValidator
{
	public static ImmutableList<Type> GetAllowedPayloadTypes() =>
		typeof(Wheel)
			.Assembly
			.GetTypes()
			.Where(t => t.IsClass && t.Namespace ==
				"test_sample_third_safe").ToImmutableList();
}