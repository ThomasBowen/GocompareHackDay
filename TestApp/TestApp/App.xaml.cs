using TestApp.Services;
using Xamarin.Forms;

namespace TestApp
{
    public partial class App : Application
    {
        public string Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6ImphcmdKNlBfUTd3VjlIMGlWcUdzemxhM2dWRzFQMWhqNG9Sd2N6eTgwbXMifQ.eyJpc3MiOiJodHRwczovL2xvZ2luLmRldi1nb2NvbXBhcmUuY29tLzBjMTM2Y2VlLWM4NzktNDAyYy1iMDQ0LWQwOWQzZTE1N2IzYi92Mi4wLyIsImV4cCI6MTY1MjM2MDQ0MiwibmJmIjoxNjUyMzU2ODQyLCJhdWQiOiJiN2MzOWYyYS05YTc1LTRiMzAtOWZiMi1lMzg1Zjc5ZmMyZmIiLCJlbWFpbCI6InRob21hcy5ib3dlbjg5QGdtYWlsLmNvbSIsInN1YiI6IjhkNzk0Yjc2LTNjMDYtNDIxMi1iNjYyLWFiNjVlMTQxY2NmZiIsImVuY3J5cHRlZEN1c3RvbWVySWQiOiJWZW1OSWZvUWgwMEpuR3c4VXlWSTZnPT0iLCJuYW1lIjoidW5rbm93biIsImlzRm9yZ290UGFzc3dvcmQiOmZhbHNlLCJub25jZSI6IjE1N2UwYTgwLTI0YjAtNDIwZS04ZDdmLThjMzk4MjBiMDFmMyIsInNjcCI6IkN1c3RvbWVycy5SZWFkIERlbWFuZHNBbmROZWVkcy5SZWFkIERlbWFuZHNBbmROZWVkcy5TYXZlIEV4Y2Vzc1Byb3RlY3Rpb24uQ3JlYXRlIEV4Y2Vzc1Byb3RlY3Rpb24uUmVhZCBPcHRpb25hbEV4dHJhcy5SZWFkIFF1b3Rlcy5Qcm9jZXNzIFF1b3Rlcy5SZWFkIFJlZmVyZW5jZXMuUmVhZCBSZXN1bHRzLkRlZXBMaW5rRGF0YS5SZWFkIFJlc3VsdHMuTW9yZUluZm9Mb2cuQ3JlYXRlIFJlc3VsdHMuUmVhZCBWZWhpY2xlcy5NYWtlcy5SZWFkIFZlaGljbGVzLlJlYWQiLCJhenAiOiI2MTg1MTI5MS0zNzQ0LTRiOGEtOWFhYS02ZDlmZWM1NmQ1YzYiLCJ2ZXIiOiIxLjAiLCJpYXQiOjE2NTIzNTY4NDJ9.7VeP12ZQcRTFvSbF_kHrjBcFNTF6HO_FvWh21jZ4LE1C4jL6YqFJvN0-IvqVhfp_1j8FS_o-B0j05JhY37HQEqEszQE6mwY_9AWWZO1VWK0XZkah4XW4ltivDk8sYM4cmsrV833ugLLN-sZbTjh3EJ7jniY81ujz_6UogCnageLThyF1nk2HtqPxYVV0xyVOgnO8ygGw1U0CfHh4_uKU5EK0RRkXGrOHqKGnQn0figpcEvV6stNHYTTwtvR32ewo6jl9sQbcIo-7LTojgQL8Mkjd_ujdgvGQTnTyOslIpGA7sV8aqIfz5_oWxoxo4BQ0sFcu3ZdliNvM--5rDzVH6w";

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
