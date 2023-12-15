using Newtonsoft.Json;
using test_sample_third_safe;

var car = new Car()
{
	Company = "Ford",
	ModelNo = "ABC123",
	WheelType = new ChromeWheel()
	{
		Material = "Rubber",
		HasChromePlating = false
	}
};

var serializedCar = JsonConvert.SerializeObject(car, new JsonSerializerSettings()
{
	TypeNameHandling = TypeNameHandling.All,
	SerializationBinder = new MySerializationBinder(PayloadValidator.GetAllowedPayloadTypes())
});
var deserializedCar = JsonConvert.DeserializeObject<Car>(serializedCar, new JsonSerializerSettings()
{
	TypeNameHandling = TypeNameHandling.Auto,
	SerializationBinder = new MySerializationBinder(PayloadValidator.GetAllowedPayloadTypes())
});

Console.WriteLine(serializedCar);
Console.WriteLine("Type of WheelType " + deserializedCar.WheelType.GetType());

Console.WriteLine();
var chromeWheel = deserializedCar.WheelType as ChromeWheel;
Console.WriteLine("HasChromePlating " + chromeWheel?.HasChromePlating);
