using TestApp.Services;
using Xamarin.Forms;

namespace TestApp
{
    public partial class App : Application
    {
        public string Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6ImphcmdKNlBfUTd3VjlIMGlWcUdzemxhM2dWRzFQMWhqNG9Sd2N6eTgwbXMifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLmRldi1nb2NvbXBhcmUuY29tLzBjMTM2Y2VlLWM4NzktNDAyYy1iMDQ0LWQwOWQzZTE1N2IzYi92Mi4wLyIsImV4cCI6MTY1MjM2NDE5OCwibmJmIjoxNjUyMzYwNTk4LCJhdWQiOiJiN2MzOWYyYS05YTc1LTRiMzAtOWZiMi1lMzg1Zjc5ZmMyZmIiLCJlbWFpbCI6InRob21hcy5ib3dlbjg5QGdtYWlsLmNvbSIsInN1YiI6IjhkNzk0Yjc2LTNjMDYtNDIxMi1iNjYyLWFiNjVlMTQxY2NmZiIsImVuY3J5cHRlZEN1c3RvbWVySWQiOiJWZW1OSWZvUWgwMEpuR3c4VXlWSTZnPT0iLCJuYW1lIjoidW5rbm93biIsImlzRm9yZ290UGFzc3dvcmQiOmZhbHNlLCJub25jZSI6IjE1N2UwYTgwLTI0YjAtNDIwZS04ZDdmLThjMzk4MjBiMDFmMyIsInNjcCI6IkN1c3RvbWVycy5SZWFkIERlbWFuZHNBbmROZWVkcy5SZWFkIERlbWFuZHNBbmROZWVkcy5TYXZlIEV4Y2Vzc1Byb3RlY3Rpb24uQ3JlYXRlIEV4Y2Vzc1Byb3RlY3Rpb24uUmVhZCBPcHRpb25hbEV4dHJhcy5SZWFkIFF1b3Rlcy5Qcm9jZXNzIFF1b3Rlcy5SZWFkIFJlZmVyZW5jZXMuUmVhZCBSZXN1bHRzLkRlZXBMaW5rRGF0YS5SZWFkIFJlc3VsdHMuTW9yZUluZm9Mb2cuQ3JlYXRlIFJlc3VsdHMuUmVhZCBWZWhpY2xlcy5NYWtlcy5SZWFkIFZlaGljbGVzLlJlYWQiLCJhenAiOiI2MTg1MTI5MS0zNzQ0LTRiOGEtOWFhYS02ZDlmZWM1NmQ1YzYiLCJ2ZXIiOiIxLjAiLCJpYXQiOjE2NTIzNjA1OTh9.bXIL24QrKf5yRW3wIOgU0igOuvsl-Kc-P-m1nAWgHqS6JWLnFO5YkoFfGslalOhVMtPTnfCeQXO2Q5f7dJT2qXwbJmuC40liWrBxlU4dd1WcmxwaxdEDezyQ1KymfgxjdTX2Ub0siroM1cZhkNtDFEsNa3OpJwnMJoxL11Fe_wGyY6ia-NYMfLUKHjKHJ3OuZH1V3IoyQ7-pTBgIzboVp470an-KbvOWdQbhpqPVNnUeyYJeD-q0Q2MpLnhfRHRxGtrIh40T5trwHFEDhrS315pvlMf0_S_zklelQlVVXJGk8HRkz6lwGPxvAe4c_YGsOSyMRHdftWQcg-OUY73QMg";

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
