namespace test_sample_third_safe;

public class Car
{
	public Wheel WheelType;
	public string ModelNo;
	public string Company;
}
public class Wheel
{
	public string Material;
}
public class AlloyWheel : Wheel
{
	public string FrictionLevel;
}
public class ChromeWheel : Wheel
{
	public bool HasChromePlating;
}