using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfAppItstepKeyBoardHomework
{
    internal class ModifiedBorder : Border
    {
        public Brush DefaultColor { get; set; }
        public Brush ChangeColor { get; set; }

        public TextBlock TextBlock { get; set; } = new TextBlock();
        public string LowerCase { get; set; }
        public string UpperCase { get; set; }

        private ModifiedBorder() 
        {

        }

        public ModifiedBorder(int row, int col, int span, Brush defaultColor, Brush changeColor, String lowerCase, string upperCase, int fontSize)
        {
            Grid.SetRow(this, row);
            Grid.SetColumn(this, col);
            Grid.SetColumnSpan(this, span);

            DefaultColor = defaultColor;
            Background = defaultColor;
            ChangeColor = changeColor;

            LowerCase = lowerCase;
            UpperCase = upperCase;

            BorderBrush = Brushes.Black;
            Margin = new Thickness(2);
            BorderThickness = new Thickness(2);
            CornerRadius = new CornerRadius(8);


            TextBlock.FontSize = fontSize;
            TextBlock.HorizontalAlignment = HorizontalAlignment.Center; 
            TextBlock.VerticalAlignment = VerticalAlignment.Center;
            Child = TextBlock;
        }

        public void UpperCaseOnOff(bool upperCaseTrue) => TextBlock.Text = upperCaseTrue ? UpperCase : LowerCase;

        public void LightOnOff(bool lightOn) => this.Background = lightOn ? ChangeColor : DefaultColor;
    }
}
