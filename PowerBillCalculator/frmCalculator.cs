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

        // Form Loaded: focus on usage textbox, load customer list and display
        private void frmCalculator_Load(object sender, EventArgs e)
        {
            ActiveControl = txtUsage;  // focus on usage textbox

            // load customer list, display it
            customers = CustomerDB.LoadCustomers();
            DisplayListAndStats(customers);
        }

        // Exit Button Clicked: close app 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Reset Button Clicked: clear all text boxes has tag "clearable", check first radioBtn
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearCalculationTextboxes();
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
                {  // validation passed, extract input
                    int usage = Convert.ToInt32(txtUsage.Text);

                    // if residential user, use residential method
                    if (radResidential.Checked)
                        totalAmt = ResidentialCustomer.CalculateCharge(usage);
                    // if commercial user, use commercial method
                    else if (radCommercial.Checked)
                        totalAmt = CommercialCustomer.CalculateCharge(usage);

                    // do output
                    txtTotal.Text = totalAmt.ToString("c");
                    txtUsage.SelectAll();  // select all for easy next entry
                }
            }
            // if industrial user, after validation, extract inputs, do calculation, show results
            else
            {
                if (Validator.TBHasNonNegativeInt(txtPeakUsage, "Peak Hour Usage") && Validator.TBHasNonNegativeInt(txtOPUsage, "Off Peak Usage"))
                {  // validation passed, extract inputs
                    int peakUsage = Convert.ToInt32(txtPeakUsage.Text);
                    int opUsage = Convert.ToInt32(txtOPUsage.Text);

                    totalAmt = IndustrialCustomer.CalculateCharge(peakUsage, opUsage);  // calculate use industrial method

                    // output peak & offpeak & total amount separately
                    grpForIndusAmt.Visible = true;
                    txtPeakCharge.Text = IndustrialCustomer.peakAmt.ToString("c");
                    txtOPCharge.Text = IndustrialCustomer.opAmt.ToString("c");
                    txtTotal.Text = totalAmt.ToString("c");

                    // select all text for easy next entry
                    txtPeakUsage.Focus();
                    txtPeakUsage.SelectAll();
                }
            }
        }


        //  Commercial Radio Button Checked: focus usage textbox, clear textboxes, change custType
        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                txtUsage.Focus();
                ClearCalculationTextboxes();
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
                ClearCalculationTextboxes();
                // when residential radio checked, change custType to 'R'
                selectedCustType = Convert.ToChar(radio.Tag.ToString());
            }
        }

        //  Industrial Radio Button Checked (unchecked): show / hide corresponding groupbox, change custType
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
            else  // if unchecked, hide controls
            {
                grpForIndustrial.Visible = false;
                grpForIndusAmt.Visible = false;
                grpForUsage.Visible = true;
            }
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
                DisplayListAndStats(customers);

                // clear customer inputs, calculation fields, to be ready for next entry
                txtAcctNum.Clear();
                txtCustName.Clear();
                txtCustName.Focus();
                ClearCalculationTextboxes();
            }

        }

        // Delete Button Clicked: confirm, if yes, delete obj from list, display, save to .txt
        private void btnDelete_Click(object sender, EventArgs e)
        {            
            if (lsvCustomer.SelectedItems.Count == 0)
                // if nothing selected, show error message to user
                MessageBox.Show("No customer is selected.", "Please Select");
            else
            {
                // if there's a selected item, confirm with user
                var result = MessageBox.Show("Do you really want to delete the selected customer information?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // if yes, remove obj from customers list and display
                    var index = lsvCustomer.SelectedIndices[0];
                    customers.RemoveAt(index);
                    DisplayListAndStats(customers);
                    // save updated list to .txt
                    CustomerDB.SaveCustomers(customers);

                    // after deletion, select previous customer (if there's one)
                    var newIndex = index - 1 < 0 ? 0 : index - 1;
                    if (lsvCustomer.Items.Count > 0)
                        lsvCustomer.Items[newIndex].Selected = true;
                    else  // no item left in listview, hide edit btn
                        btnEdit.Visible = false;
                }
            }            
        }

        // Update Button Clicked: show dialog form, if dialog result OK, means there is a changed customer obj, replace the old one with new one, save, reload .txt and display
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lsvCustomer.SelectedItems.Count > 0)
            {  // if there's a selected customer
                // create a new form, pass in the selected customer obj
                var index = lsvCustomer.SelectedIndices[0];
                Form form = new frmUpdate(customers[index]);
                var result = form.ShowDialog();  // show dialog from
                if (result == DialogResult.OK)
                {
                    // get updated customer from dialog form tag
                    var updatedCustomer = (Customer)form.Tag;
                    // replace old customer, display new list, select same index
                    customers[index] = updatedCustomer;
                    DisplayListAndStats(customers);
                    lsvCustomer.Items[index].Selected = true;
                    // save updated list
                    CustomerDB.SaveCustomers(customers);
                }
            }
        }

        // Somewhere in Form Clicked: deselect user in customer listview
        private void frmCalculator_Click(object sender, EventArgs e)
        {
            lsvCustomer.SelectedItems.Clear();
        }


        // Listview Select Changed: show / hide edit customer info button
        private void lsvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCustomer.SelectedItems.Count > 0)
                btnEdit.Visible = true;
            else
                btnEdit.Visible = false;
        }

        // Click Blank Space inside Listview: deselect customer
        private void lsvCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            bool itemClicked = false;
            foreach (ListViewItem li in lsvCustomer.Items)
            {
                if (li.Bounds.Contains(e.X, e.Y))
                    itemClicked = true;
            }
            if (!itemClicked)
                lsvCustomer.SelectedItems.Clear();
        }


        //---------- Form-Level Methods -----------//

        // Display customer list, output statistics
        private void DisplayListAndStats(List<Customer> list)
        {
            // clear old items, add every customer in list into listview, calculate individual people and charges for each type
            //lstCustomer.Items.Clear();
            lsvCustomer.Items.Clear();
            double sumR = 0, sumC = 0, sumI = 0;  // R: residential, C: commercial, I: industrial
            int countR = 0, countC = 0, countI = 0;

            foreach (var c in list)
            {
                // add to listbox
                //lstCustomer.Items.Add(c);  
                // add customer to listview
                var lvi = new ListViewItem(new[] { c.AccountNo.ToString(), c.CustomerName, c.CustomerType.ToString(), c.ChargeAmount.ToString("c") });
                lsvCustomer.Items.Add(lvi);

                // calculate statistics separately based on customer type
                if (c.CustomerType == 'R')
                {
                    sumR += c.ChargeAmount;
                    countR++;
                }
                else if (c.CustomerType == 'C')
                {
                    sumC += c.ChargeAmount;
                    countC++;
                }
                else if (c.CustomerType == 'I')
                {
                    sumI += c.ChargeAmount;
                    countI++;
                }
            }
            // output statistics
            // ternary opearator: if customer number is 0, show nothing
            txtResiCount.Text = (countR == 0) ? "" : countR.ToString();
            txtCommCount.Text = (countC == 0) ? "" : countC.ToString();
            txtIndusCount.Text = (countI == 0) ? "" : countI.ToString();
            txtResiTotal.Text = (sumR == 0) ? "" : sumR.ToString("c");
            txtCommTotal.Text = (sumC == 0) ? "" : sumC.ToString("c");
            txtIndusTotal.Text = (sumI == 0) ? "" : sumI.ToString("c");

            txtCustNumber.Text = list.Count().ToString();
            txtTotalCharges.Text = (sumR + sumC + sumI).ToString("c");
        }

        // Iterate through all text boxes with tag "clearable", clear contents
        private void ClearCalculationTextboxes()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox && c.Tag != null &&
                    c.Tag.ToString() == "clearable")
                    ((TextBox)c).Clear();
                // for text boxes inside a group box
                foreach (Control childc in c.Controls)
                {
                    if (childc is TextBox && childc.Tag != null &&
                        childc.Tag.ToString() == "clearable")
                        ((TextBox)childc).Clear();
                }
            }
        }


        /*************** DEPRECATED *********************
         
                      -- Listbox --
                      -- Reson: swithed to listview for better GUI --

        // Click Blank Space inside Listbox: deselect customer in listbox
        private void lstCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstCustomer.IndexFromPoint(e.Location) < 0)
                lstCustomer.ClearSelected();
        }

        // Listbox Select Changed: show / hide edit customer info button
        private void lstCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomer.SelectedItem != null)
                btnEdit.Visible = true;
            else
                btnEdit.Visible = false;
        }

    ******************************************************/
    }
}
