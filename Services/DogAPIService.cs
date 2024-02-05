using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class DogBreed
{
    public List<string> Breeds { get; set; }
}

public class DogApiService
{
    private readonly HttpClient _client;

    public DogApiService()
    {
        _client = new HttpClient();
    }

    public async Task<DogBreed> GetAllBreedsAsync()
    {
        var response = await _client.GetStringAsync("https://dog.ceo/api/breeds/list/all");
        var data = JsonConvert.DeserializeObject<DogBreed>(response);
        return data;
    }
}