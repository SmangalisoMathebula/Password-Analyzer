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
    public partial class ReportForm : Form
    {
        public ReportForm(PasswordManager manager)
        {
            InitializeComponent();
            FillReport(manager);
        }

        private void FillReport(PasswordManager manager)
        {
            lblTotal.Text = "Total Passwords Analysed: " + manager.GetTotalAnalysed();
            lblAverage.Text = "Average Score: " + manager.GetAverageScore().ToString("F1");
            lblHighest.Text = "Highest Score: " + manager.GetHighestScore();
            lblLowest.Text = "Lowest Score: " + manager.GetLowestScore();

            lblWeak.Text = "Weak: " + manager.CountWeak();
            lblModerate.Text = "Moderate: " + manager.CountModerate();
            lblStrong.Text = "Strong: " + manager.CountStrong();
            lblVeryStrong.Text = "Very Strong: " + manager.CountVeryStrong();
        }


    }
}
