using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using static WpfAppItstepKeyBoardHomework.ModifiedBorder;

namespace WpfAppItstepKeyBoardHomework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Dictionary<Key, ModifiedBorder> borderButtons = new Dictionary<Key, ModifiedBorder>
        {
            [Key.Oem3] = new ModifiedBorder(2, 0, 2, Brushes.HotPink, Brushes.DeepPink, "`", "~", 25),
            [Key.D1] = new ModifiedBorder(2, 2, 2, Brushes.HotPink, Brushes.DeepPink, "1", "!", 25),
            [Key.D2] = new ModifiedBorder(2, 4, 2, Brushes.HotPink, Brushes.DeepPink, "2", "@", 25),
            [Key.D3] = new ModifiedBorder(2, 6, 2, Brushes.Yellow, Brushes.YellowGreen, "3", "#", 25),
            [Key.D4] = new ModifiedBorder(2, 8, 2, Brushes.LightGreen, Brushes.Green, "4", "$", 25),
            [Key.D5] = new ModifiedBorder(2, 10, 2, Brushes.LightSkyBlue, Brushes.Blue, "5", "%", 25),
            [Key.D6] = new ModifiedBorder(2, 12, 2, Brushes.LightSkyBlue, Brushes.Blue, "6", "^", 25),
            [Key.D7] = new ModifiedBorder(2, 14, 2, Brushes.MediumPurple, Brushes.Purple, "7", "&", 25),
            [Key.D8] = new ModifiedBorder(2, 16, 2, Brushes.MediumPurple, Brushes.Purple, "8", "*", 25),
            [Key.D9] = new ModifiedBorder(2, 18, 2, Brushes.HotPink, Brushes.DeepPink, "9", "(", 25),
            [Key.D0] = new ModifiedBorder(2, 20, 2, Brushes.Yellow, Brushes.YellowGreen, "0", ")", 25),
            [Key.OemMinus] = new ModifiedBorder(2, 22, 2, Brushes.LightGreen, Brushes.Green, "-", "_", 25),
            [Key.OemPlus] = new ModifiedBorder(2, 24, 2, Brushes.LightGreen, Brushes.Green, "=", "+", 25),
            [Key.Back] = new ModifiedBorder(2, 26, 5, Brushes.Gray, Brushes.DarkGray, "Backspace", "Backspace", 18),

            [Key.Tab] = new ModifiedBorder(3, 0, 3, Brushes.Gray, Brushes.DarkGray, "Tab", "Tab", 18),
            [Key.Q] = new ModifiedBorder(3, 3, 2, Brushes.HotPink, Brushes.DeepPink, "q", "Q", 25),
            [Key.W] = new ModifiedBorder(3, 5, 2, Brushes.Yellow, Brushes.YellowGreen, "w", "W", 18),
            [Key.E] = new ModifiedBorder(3, 7, 2, Brushes.LightGreen, Brushes.Green, "e", "E", 25),
            [Key.R] = new ModifiedBorder(3, 9, 2, Brushes.LightSkyBlue, Brushes.Blue, "r", "R", 25),
            [Key.T] = new ModifiedBorder(3, 11, 2, Brushes.LightSkyBlue, Brushes.Blue, "t", "T", 25),
            [Key.Y] = new ModifiedBorder(3, 13, 2, Brushes.MediumPurple, Brushes.Purple, "y", "Y", 25),
            [Key.U] = new ModifiedBorder(3, 15, 2, Brushes.MediumPurple, Brushes.Purple, "u", "U", 25),
            [Key.I] = new ModifiedBorder(3, 17, 2, Brushes.HotPink, Brushes.DeepPink, "i", "I", 25),
            [Key.O] = new ModifiedBorder(3, 19, 2, Brushes.Yellow, Brushes.YellowGreen, "o", "O", 25),
            [Key.P] = new ModifiedBorder(3, 21, 2, Brushes.LightGreen, Brushes.Green, "p", "P", 25),
            [Key.OemOpenBrackets] = new ModifiedBorder(3, 23, 2, Brushes.LightGreen, Brushes.Green, "[", "{", 25),
            [Key.Oem6] = new ModifiedBorder(3, 25, 2, Brushes.LightGreen, Brushes.Green, "]", "}", 25),
            [Key.Oem5] = new ModifiedBorder(3, 27, 4, Brushes.LightGreen, Brushes.Green, "\\", "|", 25),

            [Key.Capital] = new ModifiedBorder(4, 0, 4, Brushes.Gray, Brushes.DarkGray, "Caps Lock", "Caps Lock", 18),
            [Key.A] = new ModifiedBorder(4, 4, 2, Brushes.HotPink, Brushes.DeepPink, "a", "A", 25),
            [Key.S] = new ModifiedBorder(4, 6, 2, Brushes.Yellow, Brushes.YellowGreen, "s", "S", 25),
            [Key.D] = new ModifiedBorder(4, 8, 2, Brushes.LightGreen, Brushes.Green, "d", "D", 25),
            [Key.F] = new ModifiedBorder(4, 10, 2, Brushes.LightSkyBlue, Brushes.Blue, "f", "F", 25),
            [Key.G] = new ModifiedBorder(4, 12, 2, Brushes.LightSkyBlue, Brushes.Blue, "g", "G", 25),
            [Key.H] = new ModifiedBorder(4, 14, 2, Brushes.MediumPurple, Brushes.Purple, "h", "H", 25),
            [Key.J] = new ModifiedBorder(4, 16, 2, Brushes.MediumPurple, Brushes.Purple, "j", "J", 25),
            [Key.K] = new ModifiedBorder(4, 18, 2, Brushes.HotPink, Brushes.DeepPink, "k", "K", 25),
            [Key.L] = new ModifiedBorder(4, 20, 2, Brushes.Yellow, Brushes.YellowGreen, "l", "L", 25),
            [Key.Oem1] = new ModifiedBorder(4, 22, 2, Brushes.LightGreen, Brushes.Green, ";", ":", 25),
            [Key.OemQuotes] = new ModifiedBorder(4, 24, 2, Brushes.LightGreen, Brushes.Green, "\'", "\"", 25),
            [Key.Return] = new ModifiedBorder(4, 26, 5, Brushes.Gray, Brushes.DarkGray, "Enter", "Enter", 18),

            [Key.LeftShift] = new ModifiedBorder(5, 0, 5, Brushes.Gray, Brushes.DarkGray, "Shift", "Shift", 18),
            [Key.Z] = new ModifiedBorder(5, 5, 2, Brushes.HotPink, Brushes.DeepPink, "z", "Z", 25),
            [Key.X] = new ModifiedBorder(5, 7, 2, Brushes.Yellow, Brushes.YellowGreen, "x", "X", 25),
            [Key.C] = new ModifiedBorder(5, 9, 2, Brushes.LightGreen, Brushes.Green, "c", "C", 25),
            [Key.V] = new ModifiedBorder(5, 11, 2, Brushes.LightSkyBlue, Brushes.Blue, "v", "V", 25),
            [Key.B] = new ModifiedBorder(5, 13, 2, Brushes.LightSkyBlue, Brushes.Blue, "b", "B", 25),
            [Key.N] = new ModifiedBorder(5, 15, 2, Brushes.MediumPurple, Brushes.Purple, "n", "N", 25),
            [Key.M] = new ModifiedBorder(5, 17, 2, Brushes.MediumPurple, Brushes.Purple, "m", "M", 25),
            [Key.OemComma] = new ModifiedBorder(5, 19, 2, Brushes.HotPink, Brushes.DeepPink, ",", "<", 25),
            [Key.OemPeriod] = new ModifiedBorder(5, 21, 2, Brushes.Yellow, Brushes.YellowGreen, ".", ">", 25),
            [Key.OemQuestion] = new ModifiedBorder(5, 23, 2, Brushes.LightGreen, Brushes.Green, "/", "?", 25),
            [Key.RightShift] = new ModifiedBorder(5, 25, 6, Brushes.Gray, Brushes.DarkGray, "Shift", "Shift", 18),

            [Key.LeftCtrl] = new ModifiedBorder(6, 0, 3, Brushes.Gray, Brushes.DarkGray, "Ctrl", "Ctrl", 18),
            [Key.LWin] = new ModifiedBorder(6, 3, 3, Brushes.Gray, Brushes.DarkGray, "Win", "Win", 18),
            [Key.LeftAlt] = new ModifiedBorder(6, 6, 3, Brushes.Gray, Brushes.DarkGray, "Alt", "Alt", 18),
            [Key.Space] = new ModifiedBorder(6, 9, 12, Brushes.SandyBrown, Brushes.Brown, "Space", "Space", 18),
            [Key.RightAlt] = new ModifiedBorder(6, 21, 3, Brushes.Gray, Brushes.DarkGray, "Alt", "Alt", 18),
            [Key.RWin] = new ModifiedBorder(6, 24, 3, Brushes.Gray, Brushes.DarkGray, "Win", "Win", 18),
            [Key.RightCtrl] = new ModifiedBorder(6, 27, 4, Brushes.Gray, Brushes.DarkGray, "Ctrl", "Ctrl", 18),
        };

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in borderButtons)
            {
                MainWindowGrid.Children.Add(item.Value);
                item.Value.UpperCaseOnOff(upperCase);
            }
         }
    }
}
