using System.Windows;

namespace WpfAppItstepKeyBoardHomework
{

    public partial class MainWindow : Window
    {
        private int difficult = 1;

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            difficult = (int)e.NewValue;
            DifficultTextBlock.Text = "Difficult: " + difficult;
        }

    }
}
