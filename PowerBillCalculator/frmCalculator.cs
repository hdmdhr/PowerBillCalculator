using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using CustomerData;
using CustomerClasses;
using System.IO;

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

        List<Customer> customers = new List<Customer>();
        private double totalAmt = 0;  // to save total charge for a user

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
                if (c is TextBox)
                    ((TextBox)c).Clear();
                // for text boxes inside group box
                foreach (Control childc in c.Controls)
                {
                    if (childc is TextBox)
                        ((TextBox)childc).Clear();
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
                    int usage = Convert.ToInt32(txtUsage.Text);
                    // if residential user, do calculation use residential method
                    if (radResidential.Checked)
                    {
                        var resCust = new ResidentialCustomer();  // create a dummy customer in order to use CalculateCharge method
                        totalAmt = resCust.CalculateCharge(usage);
                    }

                    // if commercial user, do calculation use commercial method
                    else if (radCommercial.Checked)
                    {
                        var comCust = new CommercialCustomer();
                        totalAmt = comCust.CalculateCharge(usage);
                    }

                    txtTotal.Text = totalAmt.ToString("c");
                    txtUsage.SelectAll();  // select all text in usage textbox for entering next user
                }
            }
            // if industrial user, after validation, extract inputs, do calculation, show results
            else
            {
                if (Validator.TBHasNonNegativeInt(txtPeakUsage, "Peak Hour Usage") && Validator.TBHasNonNegativeInt(txtOPUsage, "Off Peak Usage"))
                {
                    int peakUsage = Convert.ToInt32(txtPeakUsage.Text);
                    int opUsage = Convert.ToInt32(txtOPUsage.Text);

                    var indCust = new IndustrialCustomer();
                    totalAmt = indCust.CalculateCharge(peakUsage, opUsage);  // use industrial method

                    // output peak & op & total amount separately
                    grpForIndusAmt.Visible = true;
                    txtPeakCharge.Text = indCust.peakAmt.ToString("c");
                    txtOPCharge.Text = indCust.opAmt.ToString("c");
                    txtTotal.Text = totalAmt.ToString("c");

                    // select all text in peak hour usage textbox for entering next user
                    txtPeakUsage.Focus();
                    txtPeakUsage.SelectAll();
                }
            }
        }

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

        // add button clicked: add new customer to list, write list to file
        private void btnAddCust_Click(object sender, EventArgs e)
        {
            // validate txtAcctNum, txtCustName, txtTotal
            if (Validator.TBHasNonNegativeInt(txtAcctNum, "Account Number") &&
                !Validator.TBIsEmpty(txtCustName, "Customer Name") &&
                !Validator.TBIsEmpty(txtTotal, "Total Amount"))
            {
                int acctNum = Convert.ToInt32(txtAcctNum.Text);
                string custName = txtCustName.Text;
                // totalAmt is saved on form-level
                char custType = 'R';
                // check with radio button is checked, cast it's tag as customer type
                foreach (Control c in Controls)
                {
                    if (c is RadioButton)
                    {
                        var radio = (RadioButton)c;
                        if (radio.Checked)
                            custType = Convert.ToChar(radio.Tag.ToString());
                    }
                }
                // all property value ready, create customer object based on custType, add to list
                switch (custType)
                {
                    case 'R':
                        var newResidential = new ResidentialCustomer(acctNum, custName, custType, totalAmt);
                        customers.Add(newResidential);
                        break;
                    case 'C':
                        var newCommercial = new CommercialCustomer(acctNum, custName, custType, totalAmt);
                        customers.Add(newCommercial);
                        break;
                    case 'I':
                        var newIndustrial = new IndustrialCustomer(acctNum, custName, custType, totalAmt);
                        customers.Add(newIndustrial);
                        break;
                    default:
                        break;
                }

                // todo: save list to a .txt file, look at google drive
                string relativePath = "Customers.txt";
                var fs = new FileStream(relativePath, FileMode.Append, FileAccess.Write);
                var sw = new StreamWriter(fs);

                foreach (var c in customers)
                {

                }

            }

        }// button clicked
    }
}
