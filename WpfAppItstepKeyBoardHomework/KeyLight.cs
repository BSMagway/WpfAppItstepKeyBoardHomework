using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfAppItstepKeyBoardHomework
{

    public partial class MainWindow : Window
    {
        private void LightOnOff(Key key, bool lightOn)
        {
            try
            {
                borderButtons[key].LightOnOff(lightOn);
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Button not found");
            }
        }
    }
}
