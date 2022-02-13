using System;
using System.Windows;

namespace WpfAppItstepKeyBoardHomework
{

    public partial class MainWindow : Window
    {
        private bool upperCase = Console.CapsLock;
        private void UpperCaseOnOff()
        {
            if (upperCase)
            {
                Char_Oem3_Text.Text = "~";
                Char_D1_Text.Text = "!";
                Char_D2_Text.Text = "@";
                Char_D3_Text.Text = "#";
                Char_D4_Text.Text = "$";
                Char_D5_Text.Text = "%";
                Char_D6_Text.Text = "^";
                Char_D7_Text.Text = "&";
                Char_D8_Text.Text = "*";
                Char_D9_Text.Text = "(";
                Char_D0_Text.Text = ")";
                Char_OemMinus_Text.Text = "_";
                Char_OemPlus_Text.Text = "+";

                Char_q_Text.Text = "Q";
                Char_w_Text.Text = "W";
                Char_e_Text.Text = "E";
                Char_r_Text.Text = "R";
                Char_t_Text.Text = "T";
                Char_y_Text.Text = "Y";
                Char_u_Text.Text = "U";
                Char_i_Text.Text = "I";
                Char_o_Text.Text = "O";
                Char_p_Text.Text = "P";
                Char_OemOpenBrackets_Text.Text = "{";
                Char_Oem6_Text.Text = "}";
                Char_Oem5_Text.Text = "|";

                Char_a_Text.Text = "A";
                Char_s_Text.Text = "S";
                Char_d_Text.Text = "D";
                Char_f_Text.Text = "F";
                Char_g_Text.Text = "G";
                Char_h_Text.Text = "H";
                Char_j_Text.Text = "J";
                Char_k_Text.Text = "K";
                Char_l_Text.Text = "L";
                Char_Oem1_Text.Text = ":";
                Char_OemQuotes_Text.Text = "\"";

                Char_z_Text.Text = "Z";
                Char_x_Text.Text = "X";
                Char_c_Text.Text = "C";
                Char_v_Text.Text = "V";
                Char_b_Text.Text = "B";
                Char_n_Text.Text = "N";
                Char_m_Text.Text = "M";
                Char_OemComma_Text.Text = "<";
                Char_OemPeriod_Text.Text = ">";
                Char_OemQuestion_Text.Text = "?";
            }
            else
            {
                Char_Oem3_Text.Text = "`";
                Char_D1_Text.Text = "1";
                Char_D2_Text.Text = "2";
                Char_D3_Text.Text = "3";
                Char_D4_Text.Text = "4";
                Char_D5_Text.Text = "5";
                Char_D6_Text.Text = "6";
                Char_D7_Text.Text = "7";
                Char_D8_Text.Text = "8";
                Char_D9_Text.Text = "9";
                Char_D0_Text.Text = "0";
                Char_OemMinus_Text.Text = "-";
                Char_OemPlus_Text.Text = "=";

                Char_q_Text.Text = "q";
                Char_w_Text.Text = "w";
                Char_e_Text.Text = "e";
                Char_r_Text.Text = "r";
                Char_t_Text.Text = "t";
                Char_y_Text.Text = "y";
                Char_u_Text.Text = "u";
                Char_i_Text.Text = "i";
                Char_o_Text.Text = "o";
                Char_p_Text.Text = "p";
                Char_OemOpenBrackets_Text.Text = "[";
                Char_Oem6_Text.Text = "]";
                Char_Oem5_Text.Text = "\\";

                Char_a_Text.Text = "a";
                Char_s_Text.Text = "s";
                Char_d_Text.Text = "d";
                Char_f_Text.Text = "f";
                Char_g_Text.Text = "g";
                Char_h_Text.Text = "h";
                Char_j_Text.Text = "j";
                Char_k_Text.Text = "k";
                Char_l_Text.Text = "l";
                Char_Oem1_Text.Text = ";";
                Char_OemQuotes_Text.Text = "'";

                Char_z_Text.Text = "z";
                Char_x_Text.Text = "x";
                Char_c_Text.Text = "c";
                Char_v_Text.Text = "v";
                Char_b_Text.Text = "b";
                Char_n_Text.Text = "n";
                Char_m_Text.Text = "m";
                Char_OemComma_Text.Text = ",";
                Char_OemPeriod_Text.Text = ".";
                Char_OemQuestion_Text.Text = "/";
            }
        }
    }
}
