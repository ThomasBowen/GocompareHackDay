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
            GetQuoteCommand = new Command(async () => ScanButtonText = await GetQuote());
        }

        public ICommand OpenWebCommand { get; }

        public ICommand GetQuoteCommand { get; }

        private async Task<string> Scan()
        {
            return "";
        }

        private async Task<string> GetQuote()
        {
            var reg = "BV67EOZ";

            var vehicleService = new VehicleService();

            var vehicle = await vehicleService.GetVehicle(reg);

            var quoteService = new QuoteService();

            var quote = await quoteService.GetQuote();

            var quoteRequest = new ProcessQuoteRequest(quote);

            quoteRequest.quoteRequest.sessionId = Guid.NewGuid().ToString();

            MapVehicle(quoteRequest, vehicle);

            var quoteRequestID = await quoteService.SubmitQuote(quoteRequest);

            var results = await quoteService.GetResults(quoteRequestID);

            return results;
        }

        private void MapVehicle(ProcessQuoteRequest quoteRequest, VehicleModel vehicle)
        {
            quoteRequest.vehicle.abiCode = vehicle.abiCode;
            //quoteRequest.vehicle.numberOfDoors = vehicle.numberOfDoors;
            quoteRequest.vehicle.noOfSeats = vehicle.numberOfSeats;
            //quoteRequest.vehicle.transmissionId = vehicle.transmissionType == "Manual" ? 333 : 334;
            quoteRequest.vehicle.transmissionId = vehicle.transmissionId;
            quoteRequest.vehicle.yearOfManufacture = vehicle.yearOfManufacture;
            quoteRequest.vehicle.vehicleValue = vehicle.auctionSale;
            //quoteRequest.vehicle.grossWeight = double.Parse(vehicle.grossWeight.ToString());
            quoteRequest.vehicle.payload = vehicle.payload;
            quoteRequest.vehicle.modelDescription = vehicle.description;
            quoteRequest.vehicle.manufacturedFrom = vehicle.manufacturedFrom;
            quoteRequest.vehicle.manufacturedTo = vehicle.manufacturedTo;
            quoteRequest.vehicle.makeDescription = vehicle.makeDescription;
            quoteRequest.vehicle.modelDescription = vehicle.modelDescription;
            quoteRequest.vehicle.engineCc = vehicle.engineCc;
            //quoteRequest.vehicle.fuelType = vehicle.fuelType;
            //quoteRequest.vehicle.vehicleType = vehicle.vehicleType;
            //quoteRequest.vehicle.securityId = vehicle.securityId;
            //quoteRequest.vehicle.alarmImmobiliserCode = vehicle.alarmImmobiliserCode;
        }
    }
}