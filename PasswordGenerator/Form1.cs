using PasswordGenerator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasswordGenerator
{
    public partial class FrmPasswordGenerator : Form
    {

        public string[] digits = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public string[] lowercaseLetters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public string[] uppercaseLetters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public string[] specialSymbols = new string[] { "#", "!", "$", ";", "_", "&", "^", "%", "&", "*", "(", ")", "{", "}", "[", "]" };

        public const int USE_DIGITS = 1;
        public const int USE_LOWERCASE_LETTERS = 2;
        public const int USE_UPPERCASE_LETTERS = 3;
        public const int USE_SPECIAL_SYMBOLS = 4;

        public FrmPasswordGenerator()
        {
            InitializeComponent();
        }
        private void CheckPasswordStrength()
        {
            bool isLengthGreaterThan7Symbols = trackBarPasswordLenght.Value >= 8;
            bool isUsedAllSymbols = CheckBoxDigits.Checked && CheckBoxSpecialSymbols.Checked && CheckBoxLowercaseLetters.Checked && CheckBoxUppercaseLetters.Checked;
            bool isStrongPassword = isLengthGreaterThan7Symbols && isUsedAllSymbols;
        }
        private void EnableDisableGeneratePasswordButton()
        {
            ButtonGeneratePassword.Enabled = CheckBoxDigits.Checked || CheckBoxLowercaseLetters.Checked || CheckBoxUppercaseLetters.Checked || CheckBoxSpecialSymbols.Checked;
            CheckPasswordStrength();
        }
        private void FrmPasswordGenerator_Load(object sender, EventArgs e)
        {

        }

        private void CheckBoxSpecialSymbols_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGeneratePasswordButton();
        }

        private void CheckBoxDigits_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGeneratePasswordButton();
        }

        private void CheckBoxLowercaseLetters_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGeneratePasswordButton();
        }

        private void CheckBoxUppercaseLetters_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableGeneratePasswordButton();
        }
        private bool IsNeedToSkip(int arrayNumber)
        {
            if (arrayNumber == USE_DIGITS && !CheckBoxDigits.Checked)
            {
                return true;
            }
            else if (arrayNumber == USE_LOWERCASE_LETTERS && !CheckBoxLowercaseLetters.Checked)
            {
                return true;
            }
            else if (arrayNumber == USE_UPPERCASE_LETTERS && !CheckBoxUppercaseLetters.Checked)
            {
                return true;
            }
            else if (arrayNumber == USE_SPECIAL_SYMBOLS && !CheckBoxSpecialSymbols.Checked)
            {
                return true;
            }
            return false;
        }
        private string GetGeneratedPassword(int passwordLength)
        {
            StringBuilder sbPassword = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < passwordLength; i++)
            {
                int randomArrayNumber;
                do
                {
                    randomArrayNumber = random.Next(1, 5);
                } while (IsNeedToSkip(randomArrayNumber));

                switch (randomArrayNumber)
                {
                    case USE_DIGITS:
                        int randomDigitIndex = random.Next(0, digits.Length);
                        sbPassword.Append(digits[randomDigitIndex]);
                        break;
                    case USE_LOWERCASE_LETTERS:
                        int randomLowercaseLetterIndex = random.Next(0, lowercaseLetters.Length);
                        sbPassword.Append(lowercaseLetters[randomLowercaseLetterIndex]);
                        break;
                    case USE_UPPERCASE_LETTERS:
                        int randomUppercaseLetterIndex = random.Next(0, uppercaseLetters.Length);
                        sbPassword.Append(uppercaseLetters[randomUppercaseLetterIndex]);
                        break;
                    case USE_SPECIAL_SYMBOLS:
                        int randomSpecialSymbolIndex = random.Next(0, specialSymbols.Length);
                        sbPassword.Append(specialSymbols[randomSpecialSymbolIndex]);
                        break;
                }
            }
            return sbPassword.ToString();
        }

        private void ButtonClearPassword_Click(object sender, EventArgs e)
        {
            textBoxGenerationPassword.Text = "";
        }

        private void ButtonGeneratePassword_Click(object sender, EventArgs e)
        {
            

            int passwordLength = trackBarPasswordLenght.Value;
            textBoxGenerationPassword.Text = GetGeneratedPassword(passwordLength);
            Clipboard.SetText(textBoxGenerationPassword.Text);

            
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            LabelPasswordCopiedToClipboard.Hide();
            TimerShowLabelCopy.Stop();
            if (textBoxGenerationPassword.SelectionLength > 0)
                textBoxGenerationPassword.Copy();
            LabelPasswordCopiedToClipboard.Show();
            TimerShowLabelCopy.Start();

        }

       

        private void TimerShowLabelCopy_Tick_1(object sender, EventArgs e)
        {
            LabelPasswordCopiedToClipboard.Hide();
            TimerShowLabelCopy.Stop();
        }
    }
}
