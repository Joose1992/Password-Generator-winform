using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        int currentPasswordLength = 0;
        Random character = new Random();

        private void PasswordGenerator(int passwordLength)
        {
            string allCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*:',.";
            string randomPassword = "";

            for (int i=0; i < passwordLength; i++)
            {
                int randomNum = character.Next(0, allCharacters.Length);
                randomPassword += allCharacters[randomNum];
            }
            PasswordLabel.Text = randomPassword;
        }

        public Form1()
        {
            InitializeComponent();
            PasswordLengthSlider.Minimum = 5;
            PasswordLengthSlider.Maximum = 30;
            PasswordGenerator(5);
           
        }

        private void CopyPasswordBotton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PasswordLabel.Text);
        }

        private void PasswordLengthSlider_Scroll(object sender, EventArgs e)
        {
            PasswordLengthLabel.Text = "Password Length: " + PasswordLengthSlider.Value.ToString();
            currentPasswordLength = PasswordLengthSlider.Value;
            PasswordGenerator(currentPasswordLength);
        }
    }
}
