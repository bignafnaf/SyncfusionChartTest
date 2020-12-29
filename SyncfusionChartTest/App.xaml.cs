using SyncfusionChartTest.Views;
using Xamarin.Forms;

namespace SyncfusionChartTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ChartView();
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
