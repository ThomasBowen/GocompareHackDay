using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Services
{
    public class VehicleService
    {
        private readonly HttpClient _client = new HttpClient();

        public VehicleService()
        {
            var token = ((App)Xamarin.Forms.Application.Current).Token;
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<VehicleModel> GetVehicle(string reg)
        {
            var url = $"https://apis.dev-gocompare.com/vehicles/v1/{reg}";
            var response = await _client.GetAsync(url);

            var content = await response.Content.ReadAsStringAsync();

            var vehicleResponse = JsonConvert.DeserializeObject<VehicleResponse>(content);

            return vehicleResponse.data[0];
        }
    }
}
