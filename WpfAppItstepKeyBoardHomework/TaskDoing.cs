using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfAppItstepKeyBoardHomework
{

    public partial class MainWindow : Window
    {
        private int countEntered = 0;
        private int countFails = 0;

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            LightOnOff(e.Key, true);

            if (taskStarted)
            {
                if (e.Key == Key.Space && char.IsWhiteSpace(charTask[countEntered]))
                {
                    EnterArea.Text += " ";
                    countEntered++;

                    EnteredText.Text += " ";

                    TaskText.Text = countEntered < charTask.Length ? charTask.Substring(countEntered) : TaskText.Text = "";

                    ShowSpeed();
                    ShowQuantityChar();
                }
                else if (e.Key == Key.Space || e.Key == Key.Back)
                {
                    countFails++;
                    ShowFails();
                    e.Handled = true;
                }


            }
        }
        private void Window_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (taskStarted)
            {
                if (charTask[countEntered] == Convert.ToChar(e.Text))
                {
                    EnterArea.Text += Convert.ToChar(e.Text);
                    countEntered++;
                    
                    EnteredText.Text += Convert.ToChar(e.Text);

                    TaskText.Text = countEntered < charTask.Length ? charTask.Substring(countEntered) : TaskText.Text = "";

                    ShowSpeed();
                    ShowQuantityChar();
                }
                else
                {
                    countFails++;
                    ShowFails();
                    e.Handled = true;
                }
            }
        }
        private void Window_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (countEntered == charTask.Length && taskStarted)
            {
                StopButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
        }
    }
}
