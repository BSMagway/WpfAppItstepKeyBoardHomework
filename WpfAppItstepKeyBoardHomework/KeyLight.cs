using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfAppItstepKeyBoardHomework
{

    public partial class MainWindow : Window
    {
        private void LightOnOff(Key key, bool lightOn)
        {            
            switch (key) 
            {
                case Key.Oem3:
                    Char_Oem3.Background = lightOn ? Brushes.DeepPink : Brushes.HotPink;
                    break;
                case Key.D1:
                    Char_D1.Background = lightOn ? Brushes.DeepPink : Brushes.HotPink;
                    break;
                case Key.D2:
                    Char_D2.Background = lightOn ? Brushes.DeepPink : Brushes.HotPink;
                    break;
                case Key.D3:
                    Char_D3.Background = lightOn ? Brushes.YellowGreen : Brushes.Yellow;
                    break;
                case Key.D4:
                    Char_D4.Background = lightOn ? Brushes.Green : Brushes.LightGreen;
                    break;
                case Key.D5:
                    Char_D5.Background = lightOn ? Brushes.Blue : Brushes.LightSkyBlue;
                    break;
                case Key.D6:
                    Char_D6.Background = lightOn ? Brushes.Blue : Brushes.LightSkyBlue;
                    break;
                case Key.D7:
                    Char_D7.Background = lightOn ? Brushes.Purple : Brushes.MediumPurple;
                    break;
                case Key.D8:
                    Char_D8.Background = lightOn ? Brushes.Purple : Brushes.MediumPurple;
                    break;
                case Key.D9:
                    Char_D9.Background = lightOn ? Brushes.DeepPink : Brushes.HotPink;
                    break;
                case Key.D0:
                    Char_D0.Background = lightOn ? Brushes.YellowGreen : Brushes.Yellow;
                    break;
                case Key.OemMinus:
                    Char_OemMinus.Background = lightOn ? Brushes.Green : Brushes.LightGreen;
                    break;
                case Key.OemPlus:
                    Char_OemPlus.Background = lightOn ? Brushes.Green : Brushes.LightGreen;
                    break;
                case Key.Back:
                    Back.Background = lightOn ? Brushes.DarkGray : Brushes.Gray;
                    break;

                case Key.Tab:
                    Tab.Background = lightOn ? Brushes.DarkGray : Brushes.Gray;
                    break;
                case Key.Q:
                    Char_q.Background = lightOn ? Brushes.DeepPink : Brushes.HotPink;
                    break;
                case Key.W:
                    Char_w.Background = lightOn ? Brushes.YellowGreen : Brushes.Yellow;
                    break;
                case Key.E:
                    Char_e.Background = lightOn ? Brushes.Green : Brushes.LightGreen;
                    break;
                case Key.R:
                    Char_r.Background = lightOn ? Brushes.Blue : Brushes.LightSkyBlue;
                    break;
                case Key.T:
                    Char_t.Background = lightOn ? Brushes.Blue : Brushes.LightSkyBlue;
                    break;
                case Key.Y:
                    Char_y.Background = lightOn ? Brushes.Purple : Brushes.MediumPurple;
                    break;
                case Key.U:
                    Char_u.Background = lightOn ? Brushes.Purple : Brushes.MediumPurple;
                    break;
                case Key.I:
                    Char_i.Background = lightOn ? Brushes.DeepPink : Brushes.HotPink;
                    break;
                case Key.O:
                    Char_o.Background = lightOn ? Brushes.YellowGreen : Brushes.Yellow;
                    break;
                case Key.P:
                    Char_p.Background = lightOn ? Brushes.Green : Brushes.LightGreen;
                    break;
                case Key.OemOpenBrackets:
                    Char_OemOpenBrackets.Background = lightOn ? Brushes.Green : Brushes.LightGreen;
                    break;
                case Key.Oem6:
                    Char_Oem6.Background = lightOn ? Brushes.Green : Brushes.LightGreen;
                    break;
                case Key.Oem5:
                    Char_Oem5.Background = lightOn ? Brushes.Green : Brushes.LightGreen;
                    break;

                case Key.Capital:
                    Capital.Background = lightOn ? Brushes.DarkGray : Brushes.Gray;
                    break;
                case Key.A:
                    Char_a.Background = lightOn ? Brushes.DeepPink : Brushes.HotPink;
                    break;
                case Key.S:
                    Char_s.Background = lightOn ? Brushes.YellowGreen : Brushes.Yellow;
                    break;
                case Key.D:
                    Char_d.Background = lightOn ? Brushes.Green : Brushes.LightGreen;
                    break;
                case Key.F:
                    Char_f.Background = lightOn ? Brushes.Blue : Brushes.LightSkyBlue;
                    break;
                case Key.G:
                    Char_g.Background = lightOn ? Brushes.Blue : Brushes.LightSkyBlue;
                    break;
                case Key.H:
                    Char_h.Background = lightOn ? Brushes.Purple : Brushes.MediumPurple;
                    break;
                case Key.J:
                    Char_j.Background = lightOn ? Brushes.Purple : Brushes.MediumPurple;
                    break;
                case Key.K:
                    Char_k.Background = lightOn ? Brushes.DeepPink : Brushes.HotPink;
                    break;
                case Key.L:
                    Char_l.Background = lightOn ? Brushes.YellowGreen : Brushes.Yellow;
                    break;
                case Key.Oem1:
                    Char_Oem1.Background = lightOn ? Brushes.Green : Brushes.LightGreen;
                    break;
                case Key.OemQuotes:
                    Char_OemQuotes.Background = lightOn ? Brushes.Green : Brushes.LightGreen;
                    break;
                case Key.Return:
                    Return.Background = lightOn ? Brushes.DarkGray : Brushes.Gray;
                    break;

                case Key.LeftShift:
                    LeftShift.Background = lightOn ? Brushes.DarkGray : Brushes.Gray;
                    break;
                case Key.Z:
                    Char_z.Background = lightOn ? Brushes.DeepPink : Brushes.HotPink;
                    break;
                case Key.X:
                    Char_x.Background = lightOn ? Brushes.YellowGreen : Brushes.Yellow;
                    break;
                case Key.C:
                    Char_c.Background = lightOn ? Brushes.Green : Brushes.LightGreen;
                    break;
                case Key.V:
                    Char_v.Background = lightOn ? Brushes.Blue : Brushes.LightSkyBlue;
                    break;
                case Key.B:
                    Char_b.Background = lightOn ? Brushes.Blue : Brushes.LightSkyBlue;
                    break;
                case Key.N:
                    Char_n.Background = lightOn ? Brushes.Purple : Brushes.MediumPurple;
                    break;
                case Key.M:
                    Char_m.Background = lightOn ? Brushes.Purple : Brushes.MediumPurple;
                    break;
                case Key.OemComma:
                    Char_OemComma.Background = lightOn ? Brushes.YellowGreen : Brushes.Yellow;
                    break;
                case Key.OemPeriod:
                    Char_OemPeriod.Background = lightOn ? Brushes.DeepPink : Brushes.HotPink;
                    break;
                case Key.OemQuestion:
                    Char_OemQuestion.Background = lightOn ? Brushes.Green : Brushes.LightGreen;
                    break;
                case Key.RightShift:
                    RightShift.Background = lightOn ? Brushes.DarkGray : Brushes.Gray;
                    break;

                case Key.LeftCtrl:
                    LeftCtrl.Background = lightOn ? Brushes.DarkGray : Brushes.Gray;
                    break;
                case Key.LWin:
                    LWin.Background = lightOn ? Brushes.DarkGray : Brushes.Gray;
                    break;
                case Key.System:
                    System_Left.Background = lightOn ? Brushes.DarkGray : Brushes.Gray;
                    System_Right.Background = lightOn ? Brushes.DarkGray : Brushes.Gray;
                    break;
                case Key.Space:
                    Space.Background = lightOn ? Brushes.Brown : Brushes.SandyBrown;
                    break;
                case Key.RWin:
                    RWin.Background = lightOn ? Brushes.DarkGray : Brushes.Gray;
                    break;
                case Key.RightCtrl:
                    RightCtrl.Background = lightOn ? Brushes.DarkGray : Brushes.Gray;
                    break;
                default:
                    break;      
            }                 
        }
    }
}
