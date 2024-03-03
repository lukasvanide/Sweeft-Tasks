using System.Text.Json;
using System.Text.Json.Serialization;

//var httpClient = new HttpClient();

//httpClient.BaseAddress = new Uri("https://restcountries.com");

//var result = await httpClient.GetAsync("/v3.1/all");

//var str = await result.Content.ReadAsStringAsync();
//var response = JsonSerializer.Deserialize<CountrysResponse[]>(str);

//Directory.CreateDirectory("C:/Files");

//foreach (var item in response)
//{
//    using (var writer = File.CreateText($"C:/Files/{item.Name.Common}.txt"))
//    {
//        await writer.WriteLineAsync($"{item.Region},{item.Subregion},{item.Latlng[0]} {item.Latlng[1]},{item.Area},{item.Population}");
//    }

//}



//Console.ReadLine();


public class CountrysResponse
{
    [JsonPropertyName("population")]
    public long Population { get; set; }
    [JsonPropertyName("region")]
    public string Region { get; set; }
    [JsonPropertyName("subregion")]
    public string Subregion { get; set; }
    [JsonPropertyName("area")]
    public double Area { get; set; }
    [JsonPropertyName("latlng")]
    public double[] Latlng { get; set; }
    [JsonPropertyName("name")]
    public CountryName Name { get; set; }
}
public class CountryName
{
    [JsonPropertyName("common")]
    public string Common { get; set; }
}