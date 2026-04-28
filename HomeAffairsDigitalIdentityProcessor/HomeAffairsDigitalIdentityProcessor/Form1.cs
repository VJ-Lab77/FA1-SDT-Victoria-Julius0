using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxCitizenship_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void buttonVaildate_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string idNumber = textID.Text.Trim();
            string citizenship = comboBoxCitizenship.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your full name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(idNumber))
            {
                MessageBox.Show("Please enter an ID number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(citizenship))
            {
                MessageBox.Show("Please indicate your citizenship status.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CitizenProfile profile = new CitizenProfile(name, idNumber, citizenship);
            string validationResult = profile.ValidateID();

            textResult.Text = $"=== VALIDATION RESULT ===\r\n";
            textResult.Text += $"Name: {name}\r\n";
            textResult.Text += $"ID: {idNumber}\r\n";
            textResult.Text += $"Calculated Age: {profile.Age} years\r\n";
            textResult.Text += $"Citizenship: {citizenship}\r\n";
            textResult.Text += $"\r\nResult: {validationResult}";
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string idNumber = textID.Text.Trim();
            string citizenship = comboBoxCitizenship.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your full name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(idNumber))
            {
                MessageBox.Show("Please enter an ID number.", "Invalid Input        ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(citizenship))
            {
                MessageBox.Show("Please indicate your citizenship status.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CitizenProfile profile = new CitizenProfile(name, idNumber, citizenship);
            string validationResult = profile.ValidateID();
            string profileSummary = profile.ProfileSummary(validationResult);

            textResult.Text = profileSummary;
        }

        private void labelCitizenship_Click(object sender, EventArgs e)
        {

        }
    }
}
