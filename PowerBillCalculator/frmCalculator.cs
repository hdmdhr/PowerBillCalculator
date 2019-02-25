﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
        // -------------- Form-Level Declaration Area -------------------------//

        private const double RATE_RESIDENTIAL = 0.052;  // rate for residentital user
        private const double RATE_COMMERCIAL = 0.045;  // rate for commercial user
        private const double PH_INDUSTRIAL = 0.065;  // peak hour rate for industrial user
        private const double OP_INDUSTRIAL = 0.028; // off peak rate for industrial user

        private const double BASE_RESIDENTIAL = 6.00;  // basic charge for residential user
        private const double BASE_COMMERCIAL = 60.00;  // basic charge for commercial user
        private const double PH_BASE_INDUSTRIAL = 76.00;  // basic charge for industrial peak hour use
        private const double OP_BASE_INDUSTRIAL = 40.00;  // basic charge for industrial off peak use

        private const double BASE_USAGE_KWH = 1000;  // usage amount that basic charge covers

        private double totalAmt = 0;  // variable to save the total charge for a user

        //------------------------ END -------------------------------------//

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
            // iterate through all text boxes, clear all contents
            foreach (Control c in Controls)
            {
                foreach (Control childc in c.Controls)
                {
                    if (childc is TextBox)
                    {
                        ((TextBox)childc).Clear();
                    }
                }
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        // calculate button clicked: do validation, do calculation based on user type, show result(s)
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // if not industrial user (residential or commercial), after validation, extract input, do calculation, show result
            if (!radIndustrial.Checked)
            {
                if (Validator.TBHasNonNegativeInt(txtUsage, "Usage"))
                {
                    double usage = Convert.ToDouble(txtUsage.Text);
                    // if residential user, do calculation use residential method
                    if (radResidential.Checked)
                        totalAmt = CalculateResidential(usage);

                    // if commercial user, do calculation use commercial method
                    else if (radCommercial.Checked)
                        totalAmt = CalculateCommercial(usage);

                    txtTotal.Text = totalAmt.ToString("c");
                    txtUsage.SelectAll();  // select all text in usage textbox for entering next user
                }
            }
            // if industrial user, after validation, extract inputs, do calculation, show results
            else
            {
                if (Validator.TBHasNonNegativeInt(txtPeakUsage, "Peak Hour Usage") && Validator.TBHasNonNegativeInt(txtOPUsage, "Off Peak Usage"))
                {
                    double peakUsage = Convert.ToDouble(txtPeakUsage.Text);
                    double opUsage = Convert.ToDouble(txtOPUsage.Text);

                    totalAmt = CalculateIndustrial(peakUsage, opUsage, out double peakAmt, out double opAmt);  // use industrial method

                    // output peak & op & total amount separately
                    grpForIndusAmt.Visible = true;
                    txtPeakCharge.Text = peakAmt.ToString("c");
                    txtOPCharge.Text = opAmt.ToString("c");
                    txtTotal.Text = totalAmt.ToString("c");

                    // select all text in peak hour usage textbox for entering next user
                    txtPeakUsage.Focus();
                    txtPeakUsage.SelectAll();
                }
            }
        }

        //-------------- Calculation Methods Area --------------------//

        //  method for residential user
        private double CalculateResidential(double usage)
        {
            return BASE_RESIDENTIAL + usage * RATE_RESIDENTIAL;
        }

        //  method for commercial user
        private double CalculateCommercial(double usage)
        {
            if (usage <= BASE_USAGE_KWH)
                totalAmt = BASE_COMMERCIAL;
            else
                totalAmt = BASE_COMMERCIAL + (usage - BASE_USAGE_KWH) * RATE_COMMERCIAL;

            return totalAmt;
        }

        // method for industrial user
        private double CalculateIndustrial(double peakUse, double opUse, out double peakAmt, out double opAmt)
        {
            if (peakUse <= BASE_USAGE_KWH)
                peakAmt = PH_BASE_INDUSTRIAL;
            else
                peakAmt = PH_BASE_INDUSTRIAL + (peakUse - BASE_USAGE_KWH) * PH_INDUSTRIAL;

            if (opUse <= BASE_USAGE_KWH)
                opAmt = OP_BASE_INDUSTRIAL;
            else
                opAmt = OP_BASE_INDUSTRIAL + (opUse - BASE_USAGE_KWH) * OP_INDUSTRIAL;

            return peakAmt + opAmt;
        }

        //------------------------ END -------------------------//

        //  industrial radio button checked or unchecked: hide and show corresponding groupbox
        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                grpForIndustrial.Visible = true;
                grpForUsage.Visible = false;
                txtPeakUsage.Focus();
            }
            else
            {
                grpForIndustrial.Visible = false;
                grpForIndusAmt.Visible = false;
                grpForUsage.Visible = true;
                txtUsage.Focus();
            }
        }

        //  commercial radio button checked or unchecked: focus usage textbox, reset all textboxes
        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            txtUsage.Focus();
            btnReset_Click(sender, e);
        }

        //  residential radio button checked or unchecked: focus usage textbox, reset all textboxes
        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            txtUsage.Focus();
            btnReset_Click(sender, e);
        }

        // form loaded: focus on usage textbox
        private void frmCalculator_Load(object sender, EventArgs e)
        {
            ActiveControl = txtUsage;  // focus on a textbox when form loaded
        }
    }
}
