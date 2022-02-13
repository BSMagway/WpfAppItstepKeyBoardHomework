using System.Windows;

namespace WpfAppItstepKeyBoardHomework
{

    public partial class MainWindow : Window
    {
        private void ShowFails() => FailsTextBlock.Text = $"Fails: {countFails}";

        private void ShowQuantityChar() => QuantityTextBlock.Text = $"Quantity: {countEntered} / {TaskArea.Text.Length}";

        private void ShowSpeed()
        {
            double speed = ((double)countEntered / ((double)stopwatch.ElapsedMilliseconds / 1000)) * 60;
            SpeedTextBlock.Text = $"Speed: {string.Format("{0:f}", speed)} chars/min";
        }
    }
}
