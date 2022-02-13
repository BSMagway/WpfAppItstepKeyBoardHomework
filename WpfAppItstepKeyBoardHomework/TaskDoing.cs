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
                    countEntered++;
                    ShowSpeed();
                    ShowQuantityChar();
                }
                else if (e.Key == Key.Space)
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
                    countEntered++;
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
        private void EnterArea_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (countEntered == charTask.Length)
            {
                StopButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
        }


    }
}
