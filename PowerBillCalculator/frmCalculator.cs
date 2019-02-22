using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBillCalculator
{
    /*
     * Author: DongMing Hu
     * Date: Feb. 20, 2019
     * Purpose: Calculate power bill for 3 types of users
     * 
     */
    public partial class frmCalculator : Form
    {
        const double RATE_RESIDENTIAL = 0.052;  // rate for residentital user
        const double RATE_COMMERCIAL = 0.045;  // rate for commercial user
        const double PH_INDUSTRIAL = 0.065;  // peak hour rate for industrial user
        const double OP_INDUSTRIAL = 0.028; // off peak rate for industrial user
        double totalAmt;  // variable to save the total charge for a user
        public frmCalculator()
        {
            InitializeComponent();
        }

        // exit button clicked: close app 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // reset button clicked: erase all text boxes
        private void btnReset_Click(object sender, EventArgs e)
        {
            // grab all rad and txt, iterate through them, clear all contents
            foreach (Control c in Controls)
            {
                foreach (Control childc in c.Controls)
                {
                    if (childc is TextBox)
                    {
                        ((TextBox)childc).Text = "";
                    }
                }
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

        // calculate button clicked: do calculation, show result(s)
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            grpForIndusAmt.Visible = false;  // hide outputs boxes only designed for industrial users

            double usage = 0;

            // if not industrial user, extract total usage from text box, do validation to make sure it's a non-negative integer
            if (!radIndustrial.Checked)
            {
                if (Validator.TBHasNonNegativeInt(txtUsage,"Usage"))
                    usage = Convert.ToDouble(txtUsage.Text);
            }

            // if residential user, use residential calculation method
            if (radResidential.Checked)
                totalAmt = CalculateResidential(usage);
            // if commercial user, use commercial calculation method
            else if (radCommercial.Checked)
                totalAmt = CalculateCommercial(usage);
            // if industrial user, extract peak hour usage and off peak usage from text box, do validation, do calculation
            else
            {
                // todo: validation
                double peakUsage = Convert.ToDouble(txtPeakUsage.Text);
                double opUsage = Convert.ToDouble(txtOPUsage.Text);
                double peakAmt = 0, opAmt = 0;
                totalAmt = CalculateIndustrial(peakUsage,opUsage,out peakAmt,out opAmt);  // use industrial method
                // output peak & op charges separately
                grpForIndusAmt.Visible = true;
                txtOPCharge.Text = opAmt.ToString("c");
                txtPeakCharge.Text = peakAmt.ToString("c");
            }
            txtTotal.Text = totalAmt.ToString("c");
        }

        //--------------Methods Area--------------------//
        private double CalculateResidential(double usage)
        {
            return 6 + usage * RATE_RESIDENTIAL;
        }

        private double CalculateCommercial(double usage)
        {
            if (usage <= 1000)
                totalAmt = 60;
            else
                totalAmt = 60 + (usage - 1000) * RATE_COMMERCIAL;
            return totalAmt;
        }

        private double CalculateIndustrial(double peakUse, double opUse, out double pAmt, out double opAmt)
        {
            if (peakUse <= 1000)
                pAmt = 76;
            else
                pAmt = 76 + (peakUse - 1000) * PH_INDUSTRIAL;

            if (opUse <= 1000)
                opAmt = 40;
            else
                opAmt = 40 + (opUse - 1000) * OP_INDUSTRIAL;

            return pAmt + opAmt;
        }

        public static bool IsInteger(string input)
        {
            int myNum;
            if (Int32.TryParse(input, out myNum))
                return true;
            else
                return false;
        }

        //------------------------------------------------//

        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            // hide and show corresponding groupbox
            RadioButton rad = (RadioButton)sender;
            if (rad.Checked)
            {
                grpForIndustrial.Visible = true;
                grpForUsage.Visible = false;
                txtPeakUsage.Focus();
            } else
            {
                grpForIndustrial.Visible = false;
                grpForUsage.Visible = true;
            }
        }

        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            txtUsage.Focus();
            btnReset_Click(sender, e);
        }

        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            txtUsage.Focus();
            btnReset_Click(sender, e);
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            txtUsage.Focus();
        }
    }
}
