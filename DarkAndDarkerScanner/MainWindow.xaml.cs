using System.Windows;
using System.Windows.Input;

namespace DarkAndDarkerScanner
{
    public partial class MainWindow : Window
    {
        private bool isMaximized = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                ToggleMaximize();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleMaximize();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ToggleMaximize()
        {
            
            if (isMaximized)
            {
                WindowState = WindowState.Normal;
                Width = 920;
                Height = 600;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }

            isMaximized = !isMaximized;
        }
    }
}
