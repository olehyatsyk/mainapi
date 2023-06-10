using mainapi.models;
using Newtonsoft.Json;

namespace mainapi.Clients
{
    public class Client
    {
        private HttpClient _httpClient;
        private static string _address;
        private static string _apikey;
        public Client()
        {
            _address = Constants.address;
            _apikey = Constants.apikey;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_address);
        }

        public async Task<CityTime> GetTimeByCityAsync(string CityName)
        {
            var responce = await _httpClient.GetAsync($"/timezone?apiKey={_apikey}&location={CityName}");
            responce.EnsureSuccessStatusCode();
            var content = responce.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<CityTime>(content);
            return result;

        }
    }
}
