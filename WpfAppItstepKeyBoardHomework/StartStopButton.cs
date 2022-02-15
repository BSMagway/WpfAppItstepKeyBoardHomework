using System.Diagnostics;
using System.Windows;

namespace WpfAppItstepKeyBoardHomework
{

    public partial class MainWindow : Window
    {
        private string charTask = null;
        private bool taskStarted = false;
        Stopwatch stopwatch = new Stopwatch();

        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            StopButton.IsEnabled = true;
            StartButton.IsEnabled = false;
            CheckBoxSensitive.IsEnabled = false;
            SliderDifficulti.IsEnabled = false;
            taskStarted = true;

            countEntered = 0;
            countFails = 0;
            ShowFails();


            charTask = GenerateTask();
            TaskText.Text = charTask;

            EnteredText.Text = "";
            EnterArea.Text = "";

            SpeedTextBlock.Text = "Speed: 0 chars / min";

            stopwatch.Start();
        }

        private void Button_Stop_Click(object sender, RoutedEventArgs e)
        {
            StartButton.IsEnabled = true;
            StopButton.IsEnabled = false;
            CheckBoxSensitive.IsEnabled = true;
            SliderDifficulti.IsEnabled = true;
            taskStarted = false;

            stopwatch.Stop();
            ShowSpeed();
            stopwatch.Reset();
        }
    }
}
