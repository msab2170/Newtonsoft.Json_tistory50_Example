using Newtonsoft.Json;

Example example = new()
{
    Str = "문자열",
    Number = 10,
    NumberDefault0 = 0,
    IsOk = true,
    NullableStr = null,
    NullableInteger = null
};

var exampleJson0 = JsonConvert.SerializeObject(example);
var exampleJson1 = JsonConvert.SerializeObject(example, Formatting.None);
var exampleJson2 = JsonConvert.SerializeObject(example, Formatting.Indented);
var exampleJson3 = JsonConvert.SerializeObject(example, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
var exampleJson4 = JsonConvert.SerializeObject(example, Formatting.None, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
var exampleJson5 = JsonConvert.SerializeObject(example, Formatting.Indented, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
var exampleJson6 = JsonConvert.SerializeObject(example, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

Console.WriteLine($"exampleJson0: {exampleJson0}");
Console.WriteLine($"exampleJson1: {exampleJson1}");
Console.WriteLine($"exampleJson2: {exampleJson2}");
Console.WriteLine($"exampleJson3: {exampleJson3}");
Console.WriteLine($"exampleJson4: {exampleJson4}");
Console.WriteLine($"exampleJson5: {exampleJson5}");
Console.WriteLine($"exampleJson5: {exampleJson6}");

Console.WriteLine($"example: {example}");
Console.WriteLine($"example.ToStringJson(): {example.ToStringJson()}");
Console.WriteLine($"example.ToString2(): {example.ToString2()}");
var ex0 = JsonConvert.DeserializeObject(exampleJson0);

Console.WriteLine($"example: {ex0}");
//Console.WriteLine($"example.ToStringJson(): {ex0.ToStringJson()}");
//Console.WriteLine($"example.ToString2(): {ex0.ToString2()}");

var ex1 = JsonConvert.DeserializeObject<Example>(exampleJson0);
Console.WriteLine($"example: {ex1}");
Console.WriteLine($"example.ToStringJson(): {ex1.ToStringJson()}");
Console.WriteLine($"example.ToString2(): {ex.ToString2()}");
class Example
{
    public List<Fruit> Fruits;
    public string Str;
    public int Number = 0;
    public int NumberDefault0 = 0;
    public bool IsOk;
    public string? NullableStr;
    public int? NullableInteger;

    public override string? ToString() => JsonConvert.SerializeObject(this);
    public string? ToStringJson() => JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore});
    public string? ToString2() =>
        "Fruits=" + (Fruits == null ? "null" : Fruits.ToString()) +
        "\n&Number=" + Number +
        "\n&NumberDefault0=" + NumberDefault0 +
        "\n&IsOk=" + IsOk +
        "\n&NullableStr=" + (NullableStr == null ? "null" : NullableStr.ToString()) +
        "\n&NullableInteger=" + (NullableInteger == null ? "null" : NullableInteger.ToString());
}

class Fruit
{
    public string Name;
    public int price;
}





