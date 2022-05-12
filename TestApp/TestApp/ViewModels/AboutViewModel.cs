using System;
using System.Threading.Tasks;
using System.Windows.Input;
using TestApp.Models;
using TestApp.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TestApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        string scanButtonText = string.Empty;
        public string ScanButtonText
        {
            get { return scanButtonText; }
            set { SetProperty(ref scanButtonText, value); }
        }

        public AboutViewModel()
        {
            Title = "GocompAR";
            OpenWebCommand = new Command(async () => ScanButtonText = await Scan());
        }

        public ICommand OpenWebCommand { get; }

        private async Task<string> Scan()
        {
            return "";
        }

        private async Task<string> GetQuote()
        {
            var quoteService = new QuoteService();

            var quote = await quoteService.GetQuote();

            var questRequest = new ProcessQuoteRequest(quote);

            questRequest.quoteRequest.sessionId = Guid.NewGuid().ToString();

            var quoteRequestID = await quoteService.SubmitQuote(questRequest);

            var results = await quoteService.GetResults(quoteRequestID);

            return results;
        }
    }
}