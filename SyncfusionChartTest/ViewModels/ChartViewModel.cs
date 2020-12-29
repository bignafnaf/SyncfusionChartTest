using System.Collections.ObjectModel;
using SyncfusionChartTest.Models;

namespace SyncfusionChartTest.ViewModels
{
    public class ChartViewModel
    {
        public ObservableCollection<ChartDataModel> LineData1 { get; set; }
        public ObservableCollection<ChartDataModel> LineData2 { get; set; }
        public ObservableCollection<ChartDataModel> LineData3 { get; set; }

        public ChartViewModel()
        {
            LineData1 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("2005", 21),
                new ChartDataModel("2006", 24),
                new ChartDataModel("2007", 36),
                new ChartDataModel("2008", 38),
                new ChartDataModel("2009", 54),
                new ChartDataModel("2010", 57),
                new ChartDataModel("2011", 70)
            };

            LineData2 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("2005", 28),
                new ChartDataModel("2006", 44),
                new ChartDataModel("2007", 48),
                new ChartDataModel("2008", 50),
                new ChartDataModel("2009", 66),
                new ChartDataModel("2010", 78),
                new ChartDataModel("2011", 84)
            };

            LineData3 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("2005", 31),
                new ChartDataModel("2006", 45),
                new ChartDataModel("2007", 50),
                new ChartDataModel("2008", 62),
                new ChartDataModel("2009", 79),
                new ChartDataModel("2010", 85),
                new ChartDataModel("2011", 89)
            };
        }


        //public List<ItemInfo> ItemsData { get; set; }

        //public ChartViewModel()
        //{
        //    ItemsData = new List<ItemInfo>
        //    {
        //        new ItemInfo { Year = "2014", Target = 500, Sale = 342},
        //        new ItemInfo { Year = "2015", Target = 520, Sale = 393},
        //        new ItemInfo { Year = "2016", Target = 560, Sale = 431},
        //        new ItemInfo { Year = "2017", Target = 600, Sale = 520},
        //        new ItemInfo { Year = "2018", Target = 600, Sale = 578},
        //    };
        //}
    }
}
