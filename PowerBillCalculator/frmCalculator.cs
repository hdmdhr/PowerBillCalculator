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
        const double OF_INDUSTRIAL = 0.028;
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
            // todo: google how to grab all rad and txt, iterate through them, clear all contents
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (radResidential.Checked)
            {
                // use residential formula
                totalAmt = 6 + Convert.ToDouble(txtUsage.Text) * RATE_RESIDENTIAL;
                txtTotal.Text = totalAmt.ToString("c");
            } else if (radCommercial.Checked)
            {
                // use commercial formula
            } else
            {
                // use industrial formula
            }
        }

        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)sender;
            if (rad.Checked)
            {
                grpForIndustrial.Visible = true;
            } else
            {
                grpForIndustrial.Visible = false;
            }
        }
    }
}
