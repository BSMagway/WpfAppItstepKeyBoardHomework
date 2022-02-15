using System;
using System.Windows;

namespace WpfAppItstepKeyBoardHomework
{

    public partial class MainWindow : Window
    {
        private bool upperCase = Console.CapsLock;
        private void UpperCaseOnOff()
        {
            foreach (var item in borderButtons)
            {
                item.Value.UpperCaseOnOff(upperCase);
            }
        }
    }
}
