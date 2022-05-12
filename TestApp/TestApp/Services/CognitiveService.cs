using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Threading.Tasks;
using TestApp.Interfaces;
using Xamarin.Forms;

namespace TestApp.Services
{
    public static class CognitiveService
    {
            // Add your Computer Vision subscription key and endpoint
            static string subscriptionKey = "970e5ef343f74b4aa662b751069eff4f";
            static string endpoint = "https://gocompar.cognitiveservices.azure.com/";

            private const string AccessKey = "DefaultEndpointsProtocol=https;AccountName=sagocompar;AccountKey=I4oQcYQ0lq6LL2pi3O7MTJejw8ny+4cfocnyUpbdMtjGpDuT3EMw1azZinH0afuVpPKAaFoWISsUUIbt+W31mw==;EndpointSuffix=core.windows.net";

            public static async Task<string> GetRegFromImage()
            {
                ComputerVisionClient client = Authenticate(endpoint, subscriptionKey);

                // Extract text (OCR) from a URL image using the Read API
                return await ReadFileUrl(client);
            }

            public static ComputerVisionClient Authenticate(string endpoint, string key)
            {
                ComputerVisionClient client =
                  new ComputerVisionClient(new ApiKeyServiceClientCredentials(key))
                  { Endpoint = endpoint };
                return client;
            }

            public static async Task<string> ReadFileUrl(ComputerVisionClient client)
            {
                var cloudStorageAccount = CloudStorageAccount.Parse(AccessKey);
                var cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
                var cloudBlobContainer = cloudBlobClient.GetContainerReference("images");
                var fileName = GenerateFileName();

                await cloudBlobContainer.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });

                CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(fileName);
                cloudBlockBlob.Properties.ContentType = "image/jpeg";

                var stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();

                await cloudBlockBlob.UploadFromStreamAsync(stream);
                var imageUri = cloudBlockBlob.Uri.AbsoluteUri;

                var textHeaders = await client.ReadAsync(imageUri);
                string operationLocation = textHeaders.OperationLocation;

                const int numberOfCharsInOperationId = 36;
                string operationId = operationLocation.Substring(operationLocation.Length - numberOfCharsInOperationId);

                ReadOperationResult results;
                do
                {
                    results = await client.GetReadResultAsync(Guid.Parse(operationId));
                }
                while ((results.Status == OperationStatusCodes.Running ||
                    results.Status == OperationStatusCodes.NotStarted));

                var textUrlFileResults = results.AnalyzeResult.ReadResults;
                var regNumber = textUrlFileResults[0].Lines[0].Text;

                return regNumber;
            }

            private static string GenerateFileName()
            {
                return DateTime
                    .Now
                    .ToUniversalTime()
                    .ToString("yyyy-MM-dd") + "/" + DateTime.Now.ToUniversalTime().ToString("yyyyMMdd\\THHmmssfff") + ".jpeg";
            }
        }
}
