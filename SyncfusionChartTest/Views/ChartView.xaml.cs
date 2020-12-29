using Syncfusion.SfChart.XForms;
using SyncfusionChartTest.ViewModels;
using Xamarin.Forms;

namespace SyncfusionChartTest.Views
{
    public partial class ChartView : ContentPage
    {
        public ChartView()
        {
            InitializeComponent();

            BindingContext = new ChartViewModel();

            if (Device.RuntimePlatform == Device.macOS || Device.RuntimePlatform == Device.UWP || Device.RuntimePlatform == Device.WPF)
            {
                Chart.Legend.OverflowMode = ChartLegendOverflowMode.Scroll;
            }
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if ((Device.RuntimePlatform == Device.Android || Device.RuntimePlatform == Device.iOS))
            {
                if (height > 0 && width > 0)
                {
                    if (height > width)
                    {
                        Chart.Legend.DockPosition = LegendPlacement.Bottom;
                    }
                    else
                    {
                        Chart.Legend.DockPosition = LegendPlacement.Right;
                    }
                }
            }
        }
    }
}
