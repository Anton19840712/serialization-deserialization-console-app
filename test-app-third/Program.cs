using Newtonsoft.Json;

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
	TypeNameHandling = TypeNameHandling.All
});

var deserializedCar = JsonConvert.DeserializeObject<Car>(serializedCar, new JsonSerializerSettings()
{
	TypeNameHandling = TypeNameHandling.Auto
});

Console.WriteLine(serializedCar);
Console.WriteLine("Type of WheelType " + deserializedCar.WheelType.GetType());

Console.WriteLine();
var chromeWheel = deserializedCar.WheelType as ChromeWheel;
Console.WriteLine("HasChromePlating " + chromeWheel?.HasChromePlating);
