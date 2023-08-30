using System;
using System.Windows.Controls;
using static DarkAndDarkerScanner.MVVM.Model.GearType;

namespace DarkAndDarkerScanner.MVVM.View
{
    /// <summary>
    /// Interaction logic for GearView.xaml
    /// </summary>
    public partial class GearView : UserControl
    {
        public GearView()
        {
            InitializeComponent();

            this.DataContext = this;

            cbGearSlot.ItemsSource = Enum.GetValues(typeof(Slot));
            cbGearSlot.SelectedIndex = 0;
        }
    }
}
