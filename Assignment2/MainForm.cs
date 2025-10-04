using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class MainForm : Form
    {
        public enum CarColor
        {
            Red,
            Blue,
            White,
            Silver
        }

        private CarColor selectedColor;

        public MainForm()
        {
            InitializeComponent();
            btnPurchase.Click += BtnPurchase_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblPurchaseSummary.ForeColor = Color.Black;
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            lblPurchaseSummary.ForeColor = Color.Black;

            if (lstMakeModel.SelectedItem == null)
            {
                lblPurchaseSummary.Text = "Pick a make and model.";
                lblPurchaseSummary.ForeColor = Color.Red;
                return;
            }

            string makeModel = lstMakeModel.SelectedItem.ToString();

            if (string.IsNullOrEmpty(txtYear.Text))
            {
                lblPurchaseSummary.Text = "Enter a valid year.";
                lblPurchaseSummary.ForeColor = Color.Red;
                return;
            }

            int year;
            try
            {
                year = int.Parse(txtYear.Text);
            }
            catch (FormatException)
            {
                lblPurchaseSummary.Text = "Enter a valid year.";
                lblPurchaseSummary.ForeColor = Color.Red;
                return;
            }

            if (radRed.Checked)
            {
                selectedColor = CarColor.Red;
            }
            else if (radBlue.Checked)
            {
                selectedColor = CarColor.Blue;
            }
            else if (radWhite.Checked)
            {
                selectedColor = CarColor.White;
            }
            else if (radSilver.Checked)
            {
                selectedColor = CarColor.Silver;
            }
            else
            {
                lblPurchaseSummary.Text = "Pick a color.";
                lblPurchaseSummary.ForeColor = Color.Red;
                return;
            }

            string colorWord = selectedColor.ToString().ToLowerInvariant();

            string features = "";
            if (chkHeatedSeats.Checked)
            {
                features += chkHeatedSeats.Text + ", ";
            }
            if (chkPerformancePackage.Checked)
            {
                features += chkPerformancePackage.Text + ", ";
            }
            if (chkAdaptiveCruise.Checked)
            {
                features += chkAdaptiveCruise.Text + ", ";
            }
            if (chkSatelliteRadio.Checked)
            {
                features += chkSatelliteRadio.Text + ", ";
            }
            string featuresText = features.Length > 2 ? features.Substring(0, features.Length - 2) : "None";

            lblPurchaseSummary.Text = $"Congrats! You have purchased a {colorWord} {year} {makeModel} with the following features: {featuresText}.";
        }

        private void btnPurchase_Click_1(object sender, EventArgs e)
        {

        }
    }
}
