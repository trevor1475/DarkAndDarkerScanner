using System;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace DarkAndDarkerScanner.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class ScanCompareView : UserControl
    {
        public ScanCompareView()
        {
            InitializeComponent();
        }

        private void UpdateMetricColoring(object sender, DataTransferEventArgs e)
        {
            UpdateTextBox((TextBlock)sender);
        }

        private void UpdateTextBox(TextBlock tb)
        {
            if (tb != null)
            {
                double metric = 0;
                Double.TryParse(tb.Text, out metric);

                if (metric == 0)
                {
                    tb.Text = $"-";
                    tb.Foreground = Brushes.Gray;
                }
                else
                {
                    double colorScaling = 256/25;
                    var percent = (metric - 1) * 100;
                    byte red = (byte)(int)Math.Round(Math.Max(Math.Min((percent > 0) ? 255 - percent * colorScaling : 255, 255), 0));
                    byte green = (byte)(int)Math.Round(Math.Max(Math.Min((percent > 0) ? 255 : 255 - percent * colorScaling * -1, 255), 0));

                    //TODO Rings
                    tb.Text = $"{Math.Round(percent, 2)}%";
                    tb.Foreground = new SolidColorBrush(Color.FromRgb(red, green, 0));
                }
            }
        }
    }
}
