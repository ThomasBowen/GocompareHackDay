using TestApp.Services;
using Xamarin.Forms;

namespace TestApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            //var quoteService = new QuoteService();

            //var quote = await quoteService.GetQuote();

            //var quoteRequestID = await quoteService.SubmitQuote(quote);

            //var results = await quoteService.GetResults(quoteRequestID);
        }
    }
}