using ITECAO_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITECAO_project
{
    public partial class MainForm : Form
    {

        private PasswordManager passwordManager = new PasswordManager(); public MainForm()
        {
            InitializeComponent();
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtPassword.Text;

            if (enteredPassword == "")
            {
                MessageBox.Show("Please enter a password to analyse.");
                return;
            }

            string selectedType = cmbPasswordType.Text;

            Password password;

            if (selectedType == "Business")
            {
                password = new BusinessPassword(enteredPassword);
            }
            else if (selectedType == "Administrator")
            {
                password = new AdministratorPassword(enteredPassword);
            }
            else
            {
                password = new PersonalPassword(enteredPassword);
            }

            password.AnalysePassword();

            lblScore.Text = "Score: " + password.Score + " / 100";
            lblStrength.Text = "Strength: " + password.GetStrength();
            lblType.Text = "Type: " + selectedType;
            txtRecommendation.Text = password.GenerateRecommendation();

            passwordManager.AddPassword(password);

            string maskedPassword = "";
            for (int i = 0; i < enteredPassword.Length; i++)
            {
                maskedPassword = maskedPassword + "*";
            }

            lstPasswords.Items.Insert(0, "#" + passwordManager.GetTotalAnalysed() + "  [" + selectedType + "]  " + maskedPassword + "  Score: " + password.Score + "  Strength: " + password.GetStrength());

            txtPassword.Clear();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (passwordManager.GetTotalAnalysed() == 0)
            {
                MessageBox.Show("No passwords have been analysed yet.");
                return;
            }

            ReportForm reportForm = new ReportForm(passwordManager);
            reportForm.ShowDialog();
        }

        private void txtRecommendation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
