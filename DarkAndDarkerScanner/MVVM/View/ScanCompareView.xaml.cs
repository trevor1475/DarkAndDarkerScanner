using System;
using System.Windows.Controls;
using System.Windows.Media;
using static DarkAndDarkerScanner.MVVM.Model.GearType;

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
            cbGearSlot.ItemsSource = Enum.GetValues(typeof(Slot));
            cbGearSlot.SelectedIndex = 0;
        }

        private void cbChanged_RecalculateAll(object sender, SelectionChangedEventArgs e)
        {
            UpdateTextBox(tb_ResultDmg);
            UpdateTextBox(tb_ResultActionSpeed);
            UpdateTextBox(tb_ResultCastSpeed);
            UpdateTextBox(tb_ResultMoveSpeed);
            UpdateTextBox(tb_ResultDps);
        }

        private void tbChanged_RecalculateDmg(object sender, TextChangedEventArgs e)
        {
            UpdateTextBox(tb_ResultDmg);
            UpdateTextBox(tb_ResultDps);
        }

        private void tbChanged_RecalculateActionSpeed(object sender, TextChangedEventArgs e)
        {
            UpdateTextBox(tb_ResultActionSpeed);
            UpdateTextBox(tb_ResultDps);
        }

        private void tbChanged_RecalculateCastSpeed(object sender, TextChangedEventArgs e)
        {
            UpdateTextBox(tb_ResultCastSpeed);
            UpdateTextBox(tb_ResultDps);
        }

        private void tbChanged_RecalculateMoveSpeed(object sender, TextChangedEventArgs e)
        {
            UpdateTextBox(tb_ResultMoveSpeed);
        }

        private void tbChanged_RecalculateSpeeds(object sender, TextChangedEventArgs e)
        {
            UpdateTextBox(tb_ResultActionSpeed);
            UpdateTextBox(tb_ResultCastSpeed);
            UpdateTextBox(tb_ResultMoveSpeed);
            UpdateTextBox(tb_ResultDps);
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
