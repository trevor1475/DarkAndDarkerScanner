using DarkAndDarkerScanner.MVVM.Model;
using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace DarkAndDarkerScannerBackend.MVVM.View
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

        private void cbChanged_RecalculateAll(object sender, SelectionChangedEventArgs e)
        {
            UpdateTextBox(tb_ResultDmg, new Random().NextDouble());
            UpdateTextBox(tb_ResultActionSpeed, new Random().NextDouble());
            UpdateTextBox(tb_ResultCastSpeed, new Random().NextDouble());
            UpdateTextBox(tb_ResultMoveSpeed, new Random().NextDouble());
            UpdateTextBox(tb_ResultDps, new Random().NextDouble());
        }

        private void tbChanged_RecalculateDmg(object sender, TextChangedEventArgs e)
        {
            UpdateTextBox(tb_ResultDmg, new Random().NextDouble());
            UpdateTextBox(tb_ResultDps, new Random().NextDouble());
        }

        private void tbChanged_RecalculateActionSpeed(object sender, TextChangedEventArgs e)
        {
            UpdateTextBox(tb_ResultActionSpeed, new Random().NextDouble());
            UpdateTextBox(tb_ResultDps, new Random().NextDouble());
        }

        private void tbChanged_RecalculateCastSpeed(object sender, TextChangedEventArgs e)
        {
            UpdateTextBox(tb_ResultCastSpeed, new Random().NextDouble());
            UpdateTextBox(tb_ResultDps, new Random().NextDouble());
        }

        private void tbChanged_RecalculateMoveSpeed(object sender, TextChangedEventArgs e)
        {
            UpdateTextBox(tb_ResultMoveSpeed, new Random().NextDouble());
        }

        private void tbChanged_RecalculateSpeeds(object sender, TextChangedEventArgs e)
        {
            UpdateTextBox(tb_ResultActionSpeed, new Random().NextDouble());
            UpdateTextBox(tb_ResultCastSpeed, new Random().NextDouble());
            UpdateTextBox(tb_ResultMoveSpeed, new Random().NextDouble());
            UpdateTextBox(tb_ResultDps, new Random().NextDouble());
        }

        private void UpdateTextBox(TextBlock tb, double metric)
        {
            if (tb != null)
            {
                if (metric == 0)
                {
                    tb.Text = $"-";
                    tb.Foreground = Brushes.Gray;
                }
                else
                {
                    double colorScaling = 256/10;
                    var percent = metric * 100 - 1;
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
