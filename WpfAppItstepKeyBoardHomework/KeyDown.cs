using System;
using System.Windows;
using System.Windows.Input;

namespace WpfAppItstepKeyBoardHomework
{
    public partial class MainWindow : Window
    {
        private void KeyClick(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.LeftShift || e.Key == Key.RightShift) && e.IsDown)
            {
                upperCase = Console.CapsLock ? false : true;
                UpperCaseOnOff();
            }
            else if ((e.Key == Key.LeftShift || e.Key == Key.RightShift) && e.IsUp)
            {
                upperCase = Console.CapsLock;
                UpperCaseOnOff();
            }
            else if (e.Key == Key.Capital && e.IsDown)
            {
                upperCase = Console.CapsLock;
                UpperCaseOnOff();
            }
            
            if (e.IsDown)
            {
                LightOnOff(e.Key, true);
            }
            else if(e.IsUp)
            {
                LightOnOff(e.Key, false);
            }
        }
    }
}
