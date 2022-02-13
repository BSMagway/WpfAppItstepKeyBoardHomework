using System;
using System.Text;
using System.Windows;

namespace WpfAppItstepKeyBoardHomework
{

    public partial class MainWindow : Window
    {
        private const int DIFFICULT_MULTIPLAER = 7;
        private const int SELECT_CHAR = 8;
        private const int SELECT_LETTER = 4;
        private const int SELECT_NUMBER = 6;
        private const int SELECT_CASE = 15;
        private const int UPPER_CASE = 5;
        private const int DIFFICULT_SYMBOL_ENABLE = 5;
        private const int SELECT_SYMBOL = 6;
        private const int ENABLE_SYMBOL = 2;
        private readonly char[] SYMBOL_UPPER_CASE = new char[] { '~', '!', '@', '#', '$', '%', '^', '&', '*',
                                         '(', ')', '_',  '+', '{', '}', ':', '\"', '|', '<', '>', '?'};
        private readonly char[] SYMBOL = new char[] { '`', '-', '=', '[', ']', ';', '\'', '\\', ',', '.', '/' };

        private Random random = new Random();

        private string GenerateNumber() => random.Next(9).ToString();
        
        private string randomStringGenerate()
        {
            string randomChar;
            int selectChar = random.Next(SELECT_CHAR);
            bool upperCaseRandom = random.Next(SELECT_CASE) <= UPPER_CASE;
            bool symbolRandom = random.Next(SELECT_SYMBOL) <= ENABLE_SYMBOL;

            if (selectChar <= SELECT_LETTER)
            {
                randomChar = ((char)random.Next('a', 'z')).ToString();

                if (caseSensivite && upperCaseRandom)
                {
                    randomChar = randomChar.ToUpper();
                }
            }
            else if (selectChar <= SELECT_NUMBER)
            {
                if (difficult < DIFFICULT_SYMBOL_ENABLE)
                {
                    randomChar = GenerateNumber();
                }
                else
                {
                    if (caseSensivite)
                    {
                        if (symbolRandom)
                        {
                            randomChar = SYMBOL_UPPER_CASE[random.Next(SYMBOL_UPPER_CASE.Length - 1)].ToString();
                        }
                        else
                        {
                            randomChar = GenerateNumber();
                        }
                    }
                    else
                    {
                        if (symbolRandom)
                        {
                            randomChar = SYMBOL[random.Next(SYMBOL.Length - 1)].ToString();
                        }
                        else
                        {
                            randomChar = GenerateNumber();
                        }
                    }

                }
            }
            else
            {
                randomChar = " ";
            }

            return randomChar;
        }
        private string GenerateTask()
        {
            StringBuilder task = new StringBuilder();

            for (int i = 1; i <= (difficult * DIFFICULT_MULTIPLAER); i++)
            {
                task.Append(randomStringGenerate());
            }

            return task.ToString();
        }

    }
}
