using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptoNote
{
    public partial class Encrypt : Form
    {
        static Random random = new Random();
        public Encrypt()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = GeneratePassword(16);
        }

        static string GeneratePassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordstrengthProgressBar.Value = CalculatePasswordStrength(passwordTextBox.Text);
        }

        private int CalculatePasswordStrength(string password)
        {
            int strength = 0;
            int length = password.Length;

            if (password.Any(char.IsLower))
                strength+=15;

            if (password.Any(char.IsUpper))
                strength+=15;

            if (password.Any(char.IsDigit))
                strength+=15;

            if (password.Any(char.IsSymbol) || password.Any(char.IsPunctuation))
                strength+=15;

            if (length >= 8 && length <= 12)
                strength+=15;
            else if (length > 12)
                strength += 40;

            return strength;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
