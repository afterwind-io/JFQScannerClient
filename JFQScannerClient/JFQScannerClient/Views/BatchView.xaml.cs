using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using JFQScannerClient.Controlers;
using JFQScannerClient.Models;

namespace JFQScannerClient.Views
{
    /// <summary>
    /// BatchView.xaml 的交互逻辑
    /// </summary>
    public partial class BatchView : UserControl
    {
        private BatchViewControler _c;

        public BatchView()
        {
            InitializeComponent();

            _c = new BatchViewControler();
            //--
            ObservableCollection<Photo> a = new ObservableCollection<Photo>();
            LBX_Invoice.ItemsSource = a;
            a.Add(new Photo() { ImagePath = @"D:\Projects\App\JFQScannerClient\JFQScannerClient\Assets\Images\doge.jpg" });
        }



        public static readonly DependencyProperty MinItemHeightProperty =
            DependencyProperty.Register("MinItemHeight", typeof(double), typeof(BatchView));
        public double MinItemHeight
        {
            get { return (double)GetValue(MinItemHeightProperty); }
            set { SetValue(MinItemHeightProperty, value); }
        }

        public static readonly DependencyProperty MinItemWidthProperty =
            DependencyProperty.Register("MinItemWidth", typeof(double), typeof(BatchView));
        public double MinItemWidth
        {
            get { return (double)GetValue(MinItemWidthProperty); }
            set { SetValue(MinItemWidthProperty, value); }
        }

    }

    public class BatchViewItemHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //int minheight = 120;
            //var height = (double)value;
            //var p = Math.Floor(height / minheight);
            var ratio = 0.618;

            //return height / p;
            return (double)value * ratio;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
    public class BatchViewItemWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int minwidth = 252;
            var width = (double)value;
            var p = Math.Floor(width / minwidth);

            return width / p;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
