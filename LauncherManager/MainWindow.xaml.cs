using System.Windows;

namespace LauncherManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_CLick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}