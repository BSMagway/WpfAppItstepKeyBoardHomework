using System.Windows;

namespace WpfAppItstepKeyBoardHomework
{
    public partial class MainWindow : Window
    {
        private bool caseSensivite = false;

        private void CheckBox_Checked(object sender, RoutedEventArgs e) => caseSensivite = true;

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e) => caseSensivite = false;
    }
}
