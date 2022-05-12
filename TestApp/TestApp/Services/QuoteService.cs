using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Services
{
    public class QuoteService
    {
        private readonly HttpClient _client = new HttpClient();

        public QuoteService()
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ((App)Xamarin.Forms.Application.Current).Token);
        }

        public async Task<Quote> GetQuote()
        {
            var response = await _client.GetAsync("https://apis.dev-gocompare.com/quotes/v1/quotes/car/-UOzMjJUi7KIhoQCxgiXNw==");

            var content = await response.Content.ReadAsStringAsync();

            var quoteResponse = JsonConvert.DeserializeObject<QuoteResponse>(content);

            return quoteResponse.data;
        }

        public async Task<string> SubmitQuote(Quote quote)
        {
            var request = JsonConvert.SerializeObject(quote);
            var content = new StringContent(request);
            var response = await _client.PostAsync("https://apis.dev-gocompare.com/quotes/v1/quotes", content);

            var responseString = await response.Content.ReadAsStringAsync();

            var quoteResponse = JsonConvert.DeserializeObject<ProcessQuoteResponse>(responseString);

            return quoteResponse.data;
        }

        public async Task<string> GetResults(string quoteRequestID)
        {
            var url = $"https://apis.dev-gocompare.com/results/v1/results/car/{quoteRequestID}";
            var response = await _client.GetAsync(url);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
