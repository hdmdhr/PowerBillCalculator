﻿using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBillCalculator
{
    public partial class frmUpdate : Form
    {
        // Form-Level Properties
        private string customerName;
        private int accountNum;
        private double chargeAmount;

        public char CustomerType { get; set; }
        public string CustomerName { get=> customerName; set {
                customerName = value;
                txtCustName.Text = value;
            }
        }
        public int AccountNum
        {
            get => accountNum; set
            {
                accountNum = value;
                txtAcctNum.Text = value.ToString();
            }
        }
        public double ChargeAmount
        {
            get => chargeAmount; set
            {
                chargeAmount = value;
                txtCurrentCharge.Text = value.ToString("c");
            }
        }



        public frmUpdate()
        {
            InitializeComponent();
        }

        // constructor
        public frmUpdate(Customer c)
        {
            InitializeComponent();
            CustomerName = c.CustomerName;
            AccountNum = c.AccountNo;
            ChargeAmount = c.ChargeAmount;
            if (c.CustomerType == 'R')
                cmbCustType.SelectedIndex = 0;
            else if (c.CustomerType == 'C')
                cmbCustType.SelectedIndex = 1;
            else
                cmbCustType.SelectedIndex = 2;
        }

        // Add Btn Clicked: add new amount to current amount
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validator.TBHasNonNegativeDouble(txtAmt, "New Amount"))
            {
                ChargeAmount += Convert.ToDouble(txtAmt.Text);
                // setter of ChargeAmount will do the output
                txtAmt.Clear();
            }
        }

        // Deduct Btn Clicked: deduct new amount from current amount
        private void btnDeduct_Click(object sender, EventArgs e)
        {
            if (Validator.TBHasNonNegativeDouble(txtAmt, "New Amount"))
            {
                if (ChargeAmount < Convert.ToDouble(txtAmt.Text))
                    ChargeAmount = 0;
                else
                    ChargeAmount -= Convert.ToDouble(txtAmt.Text);

                txtAmt.Clear();
            }
        }

        // Update Btn Clicked: do validation, if pass, update property values, save the changed customer info into tag, set dialog result OK
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Validator.TBIsEmpty(txtCustName,"Customer Name")&&
                Validator.TBHasNonNegativeInt(txtAcctNum,"Account Number"))
            {
                CustomerName = txtCustName.Text;
                AccountNum = Convert.ToInt32(txtAcctNum.Text);

                this.Tag = new Customer(AccountNum, CustomerName, CustomerType, ChargeAmount);
                this.DialogResult = DialogResult.OK;
            }
        }

        // Cancel Btn Clicked: dismiss dialog, go back
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Combo Box Changed: change customer type
        private void cmbCustType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCustType.SelectedItem.ToString())
            {
                case "Residential":
                    CustomerType = 'R';
                    break;
                case "Commercial":
                    CustomerType = 'C';
                    break;
                case "Industrial":
                    CustomerType = 'I';
                    break;
                default:
                    break;
            }
        }
    }
}
