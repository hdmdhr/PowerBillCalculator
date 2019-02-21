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
    public partial class frmCalculator : Form
    {
        const double RATE_RESIDENTIAL = 0.052;
        const double RATE_COMMERCIAL = 0.045;
        const double PH_INDUSTRIAL = 0.065;
        const double OP_INDUSTRIAL = 0.028;
        double totalAmt;
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            grpForIndusAmt.Visible = false;  // hide group for indust

            // extract usage from textbox, todo: validation
            double usage = 0;
            if (!radIndustrial.Checked)
            {
                if (IsInteger(txtUsage.Text))
                    usage = Convert.ToDouble(txtUsage.Text);
                else
                    MessageBox.Show("Hours needs to be whole number");
            }
            // todo: validate to make sure radio is checked
            if (radResidential.Checked)
                totalAmt = calcResi(usage);  // use residential method   
            else if (radCommercial.Checked)
                totalAmt = calcComm(usage); // use commercial method
            else
            {
                // todo: validation
                double peakUsage = Convert.ToDouble(txtPeakUsage.Text);
                double opUsage = Convert.ToDouble(txtOPUsage.Text);
                double peakAmt = 0, opAmt = 0;
                totalAmt = calcIndus(peakUsage,opUsage,out peakAmt,out opAmt);  // use industrial method
                // output separate use charges
                grpForIndusAmt.Visible = true;
                txtOPCharge.Text = opAmt.ToString("c");
                txtPeakCharge.Text = peakAmt.ToString("c");
            }
            txtTotal.Text = totalAmt.ToString("c");
        }

        //--------------Methods Area--------------------//
        private double calcResi(double usage)
        {
            return 6 + usage * RATE_RESIDENTIAL;
        }

        private double calcComm(double usage)
        {
            if (usage <= 1000)
                totalAmt = 60;
            else
                totalAmt = 60 + (usage - 1000) * RATE_COMMERCIAL;
            return totalAmt;
        }

        private double calcIndus(double peakUse, double opUse, out double pAmt, out double opAmt)
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
            } else
            {
                grpForIndustrial.Visible = false;
                grpForUsage.Visible = true;
            }
        }

        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
        }

        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
        }
    }
}
