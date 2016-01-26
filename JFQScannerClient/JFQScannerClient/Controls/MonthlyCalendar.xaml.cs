using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JFQScannerClient.Controls
{
    /// <summary>
    /// MonthlyCalendar.xaml 的交互逻辑
    /// </summary>
    public partial class MonthlyCalendar : UserControl
    {
        public MonthlyCalendar()
        {
            InitializeComponent();

           
        }

        public DateTime CurrentTime { get; set; } = DateTime.Now;



        public static readonly DependencyProperty YearProperty =
            DependencyProperty.Register("Year", typeof(int), typeof(MonthlyCalendar), new PropertyMetadata(2016));
        public int Year
        {
            get { return (int)GetValue(YearProperty); }
            set { SetValue(YearProperty, value); }
        }

        public static readonly DependencyProperty MonthProperty =
            DependencyProperty.Register("Month", typeof(int), typeof(MonthlyCalendar), new PropertyMetadata(1));
        public int Month
        {
            get { return (int)GetValue(MonthProperty); }
            set { SetValue(MonthProperty, value); }
        }

        private void MonthButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton t = (RadioButton)sender;

            //Get the represented month and refresh current time
            int month = Convert.ToInt32(t.Content);
            CurrentTime = new DateTime(CurrentTime.Year, month, 1);
        }
    }

    public class MonthCalendarYearConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var target = (int)value;
            var source = System.Convert.ToInt32(parameter);

            return target == source;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value;
        }
    }
    public class MonthCalendarMonthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var target = (int)value;
            var source = System.Convert.ToInt32(parameter);

            return target == source;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToInt32(parameter);
        }
    }
}
