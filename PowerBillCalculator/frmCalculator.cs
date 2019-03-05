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
using System.IO;

namespace PowerBillCalculator
{
    /*
     * Author: DongMing Hu
     * Date: Feb. 20, 2019
     * Purpose: Controller layer of MVC pattern. Talks to Model layer to do calculation and creates objects, decided what and when to be shown to user on View layer.
     * 
     */
    public partial class frmCalculator : Form
    {
        // -------- Form-Level Declarations --------//

        List<Customer> customers = new List<Customer>();
        private double totalAmt = 0;  // save total charge for a user
        private char selectedCustType = 'R';  // save current customer type

        public frmCalculator()
        {
            InitializeComponent();
        }

        // Exit Button Clicked: close app 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Reset Button Clicked: clear all text boxes has tag "clearable", check first radioBtn
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearCalculationField();
            // check the residential radio button
            radResidential.Checked = true;
        }

        // Calculate Button Clicked: do validation, do calculation based on user type, show result(s)
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
                        totalAmt = ResidentialCustomer.CalculateCharge(usage);
                    // if commercial user, do calculation use commercial method
                    else if (radCommercial.Checked)
                        totalAmt = CommercialCustomer.CalculateCharge(usage);

                    txtTotal.Text = totalAmt.ToString("c");
                    txtUsage.SelectAll();  // select all text in usage textbox for next entering
                }
            }
            // if industrial user, after validation, extract inputs, do calculation, show results
            else
            {
                if (Validator.TBHasNonNegativeInt(txtPeakUsage, "Peak Hour Usage") && Validator.TBHasNonNegativeInt(txtOPUsage, "Off Peak Usage"))
                {
                    int peakUsage = Convert.ToInt32(txtPeakUsage.Text);
                    int opUsage = Convert.ToInt32(txtOPUsage.Text);

                    totalAmt = IndustrialCustomer.CalculateCharge(peakUsage, opUsage);  // calculate amount use industrial method

                    // output peak & op & total amount separately
                    grpForIndusAmt.Visible = true;
                    txtPeakCharge.Text = IndustrialCustomer.peakAmt.ToString("c");
                    txtOPCharge.Text = IndustrialCustomer.opAmt.ToString("c");
                    txtTotal.Text = totalAmt.ToString("c");

                    // select all text in peak hour usage textbox for next entering
                    txtPeakUsage.Focus();
                    txtPeakUsage.SelectAll();
                }
            }
        }

        //  Industrial Radio Button Checked (unchecked): show corresponding groupbox, change custType
        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                grpForIndustrial.Visible = true;
                grpForUsage.Visible = false;
                txtPeakUsage.Focus();
                // when industrial radio checked, change custType to 'I'
                selectedCustType = Convert.ToChar(radio.Tag.ToString());
            }
            else
            {
                grpForIndustrial.Visible = false;
                grpForIndusAmt.Visible = false;
                grpForUsage.Visible = true;
                txtUsage.Focus();
            }
        }

        //  Commercial Radio Button Checked: focus usage textbox, reset textboxes, change custType
        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                txtUsage.Focus();
                ClearCalculationField();
                // when commercial radio checked, change custType to 'C'
                selectedCustType = Convert.ToChar(radio.Tag.ToString());
            }
        }

        //  Residential Radio Button Checked: focus usage textbox, reset textboxes, change custType
        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                txtUsage.Focus();
                ClearCalculationField();
                // when residential radio checked, change custType to 'R'
                selectedCustType = Convert.ToChar(radio.Tag.ToString());
            }
        }

        // Form Loaded: focus on usage textbox, load customer list and display
        private void frmCalculator_Load(object sender, EventArgs e)
        {
            ActiveControl = txtUsage;  // focus on usage textbox when form loaded

            // load customer list, display it
            customers = CustomerDB.LoadCustomers();
            DisplayCustomerList(customers);
        }

        // Add Button Clicked: create a new customer obj, add to list and display, write list to .txt file
        private void btnAddCust_Click(object sender, EventArgs e)
        {
            // validate txtAcctNum, txtCustName, txtTotal
            if (!Validator.TBIsEmpty(txtCustName, "Customer Name") &&
                Validator.TBHasNonNegativeInt(txtAcctNum, "Account Number") &&
                !Validator.TBIsEmpty(txtTotal, "Total Amount"))
            {
                // if pass validation, prepare (4)values to construct new customer obj
                int acctNum = Convert.ToInt32(txtAcctNum.Text);
                string custName = txtCustName.Text;
                // custType and totalAmt is saved on form-level

                // create customer obj, add to list
                var newCustomer = new Customer(acctNum, custName, selectedCustType, totalAmt);
                customers.Add(newCustomer);
               
                // save list to .txt file, display list
                CustomerDB.SaveCustomers(customers);
                DisplayCustomerList(customers);

                // clear customer inputs, calculation fields, to be ready for next entry
                txtAcctNum.Clear();
                txtCustName.Clear();
                txtCustName.Focus();
                ClearCalculationField();
            }

        }

        // Delete Button Clicked: confirm, if yes, delete obj from list, display, save to .txt
        private void btnDelete_Click(object sender, EventArgs e)
        {            
            if (lstCustomer.SelectedItem != null)
            {
                // if listbox has a selected item, confirm with user
                var result = MessageBox.Show("Do you really want to delete the selected customer information?", "Are You Sure", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // if yes, remove obj from customers list and display
                    var index = lstCustomer.SelectedIndex;
                    customers.RemoveAt(index);
                    DisplayCustomerList(customers);
                    // write updated list to .txt
                    CustomerDB.SaveCustomers(customers);
                    // select previous customer (if there's one) in the listbox after deletion
                    var newIndex = index - 1;
                    if (lstCustomer.Items.Count >= 1)
                        lstCustomer.SelectedIndex = newIndex < 0 ? 0 : newIndex;
                    else
                        lstCustomer.SelectedItem = null;
                }


            }
            else  // if nothing selected, show error message to user
                MessageBox.Show("No customer is selected.", "No Selection");
            
        }

        // Somewhere in Form Clicked: deselect user in customer listbox
        private void frmCalculator_Click(object sender, EventArgs e)
        {
            lstCustomer.SelectedItem = null;
        }

        //---------- Form-Level Methods -----------//

        // display customer list in listbox, output statistics
        private void DisplayCustomerList(List<Customer> list)
        {
            // add customers into listbox, calculate individual people and charges for each type
            lstCustomer.Items.Clear();
            double sum1 = 0, sum2 = 0, sum3 = 0;  // 1: residential, 2: commercial, 3: industrial
            int count1 = 0, count2 = 0, count3 = 0;
            foreach (var c in list)
            {
                lstCustomer.Items.Add(c);  // add to listbox

                // calculate statistics separately based on customer type
                if (c.CustomerType == 'R')
                {
                    sum1 += c.ChargeAmount;
                    count1++;
                }
                else if (c.CustomerType == 'C')
                {
                    sum2 += c.ChargeAmount;
                    count2++;
                }
                else if (c.CustomerType == 'I')
                {
                    sum3 += c.ChargeAmount;
                    count3++;
                }
            }
            // output statistics
            // ternary opearator: if customer number or total amount is 0, show nothing in output textbox
            txtResiCount.Text = (count1 == 0) ? "" : count1.ToString();
            txtResiTotal.Text = (sum1 == 0) ? "" : sum1.ToString("c");
            txtCommCount.Text = (count2 == 0) ? "" : count2.ToString();
            txtCommTotal.Text = (sum2 == 0) ? "" : sum2.ToString("c");
            txtIndusCount.Text = (count3 == 0) ? "" : count3.ToString();
            txtIndusTotal.Text = (sum3 == 0) ? "" : sum3.ToString("c");
            txtCustNumber.Text = list.Count().ToString();
            txtTotalCharges.Text = (sum1 + sum2 + sum3).ToString("c");
        }

        // iterate through all text boxes with tag "clearable", clear contents
        private void ClearCalculationField()
        {   // create a list to collect all textboxes need to be cleared
            var clearableBoxes = new List<TextBox>{ txtUsage, txtPeakUsage, txtOPUsage, txtPeakCharge, txtOPCharge, txtTotal};
            // iterate through list, clear all contents
            foreach (var tb in clearableBoxes)
            {
                tb.Clear();
            }
        }

    }
}
