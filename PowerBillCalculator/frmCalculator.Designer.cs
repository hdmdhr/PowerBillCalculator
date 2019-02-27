namespace PowerBillCalculator
{
    partial class frmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grpCustType = new System.Windows.Forms.GroupBox();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpForUsage = new System.Windows.Forms.GroupBox();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpForIndustrial = new System.Windows.Forms.GroupBox();
            this.txtOPUsage = new System.Windows.Forms.TextBox();
            this.txtPeakUsage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grpForIndusAmt = new System.Windows.Forms.GroupBox();
            this.txtOPCharge = new System.Windows.Forms.TextBox();
            this.txtPeakCharge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAcctNum = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalCharges = new System.Windows.Forms.TextBox();
            this.grpCustType.SuspendLayout();
            this.grpForUsage.SuspendLayout();
            this.grpForIndustrial.SuspendLayout();
            this.grpForIndusAmt.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Power Bill Calculator";
            // 
            // grpCustType
            // 
            this.grpCustType.BackColor = System.Drawing.Color.Transparent;
            this.grpCustType.Controls.Add(this.radIndustrial);
            this.grpCustType.Controls.Add(this.radCommercial);
            this.grpCustType.Controls.Add(this.radResidential);
            this.grpCustType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpCustType.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustType.Location = new System.Drawing.Point(62, 64);
            this.grpCustType.Name = "grpCustType";
            this.grpCustType.Size = new System.Drawing.Size(771, 67);
            this.grpCustType.TabIndex = 1;
            this.grpCustType.TabStop = false;
            this.grpCustType.Text = "Customer Type";
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIndustrial.Location = new System.Drawing.Point(634, 33);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(116, 32);
            this.radIndustrial.TabIndex = 0;
            this.radIndustrial.Tag = "I";
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCommercial.Location = new System.Drawing.Point(322, 33);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(144, 32);
            this.radCommercial.TabIndex = 0;
            this.radCommercial.Tag = "C";
            this.radCommercial.Text = "Commercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Checked = true;
            this.radResidential.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radResidential.Location = new System.Drawing.Point(22, 33);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(132, 32);
            this.radResidential.TabIndex = 0;
            this.radResidential.Tag = "R";
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(355, 633);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 35);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(773, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 51);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(162, 633);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(71, 35);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpForUsage
            // 
            this.grpForUsage.BackColor = System.Drawing.Color.Transparent;
            this.grpForUsage.Controls.Add(this.txtUsage);
            this.grpForUsage.Controls.Add(this.label2);
            this.grpForUsage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpForUsage.Location = new System.Drawing.Point(62, 137);
            this.grpForUsage.Margin = new System.Windows.Forms.Padding(0);
            this.grpForUsage.Name = "grpForUsage";
            this.grpForUsage.Padding = new System.Windows.Forms.Padding(0);
            this.grpForUsage.Size = new System.Drawing.Size(425, 100);
            this.grpForUsage.TabIndex = 0;
            this.grpForUsage.TabStop = false;
            // 
            // txtUsage
            // 
            this.txtUsage.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsage.Location = new System.Drawing.Point(294, 34);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(105, 32);
            this.txtUsage.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Power usage (kWh)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpForIndustrial
            // 
            this.grpForIndustrial.BackColor = System.Drawing.Color.Transparent;
            this.grpForIndustrial.Controls.Add(this.txtOPUsage);
            this.grpForIndustrial.Controls.Add(this.txtPeakUsage);
            this.grpForIndustrial.Controls.Add(this.label4);
            this.grpForIndustrial.Controls.Add(this.label3);
            this.grpForIndustrial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpForIndustrial.Location = new System.Drawing.Point(62, 254);
            this.grpForIndustrial.Name = "grpForIndustrial";
            this.grpForIndustrial.Padding = new System.Windows.Forms.Padding(0);
            this.grpForIndustrial.Size = new System.Drawing.Size(425, 140);
            this.grpForIndustrial.TabIndex = 1;
            this.grpForIndustrial.TabStop = false;
            this.grpForIndustrial.Visible = false;
            // 
            // txtOPUsage
            // 
            this.txtOPUsage.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPUsage.Location = new System.Drawing.Point(294, 88);
            this.txtOPUsage.Name = "txtOPUsage";
            this.txtOPUsage.Size = new System.Drawing.Size(105, 32);
            this.txtOPUsage.TabIndex = 2;
            // 
            // txtPeakUsage
            // 
            this.txtPeakUsage.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakUsage.Location = new System.Drawing.Point(294, 30);
            this.txtPeakUsage.Name = "txtPeakUsage";
            this.txtPeakUsage.Size = new System.Drawing.Size(105, 32);
            this.txtPeakUsage.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Off peak hour usage (kWh)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Peak hour usage (kWh)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Amount (CAD)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(356, 575);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(105, 32);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpForIndusAmt
            // 
            this.grpForIndusAmt.BackColor = System.Drawing.Color.Transparent;
            this.grpForIndusAmt.Controls.Add(this.txtOPCharge);
            this.grpForIndusAmt.Controls.Add(this.txtPeakCharge);
            this.grpForIndusAmt.Controls.Add(this.label7);
            this.grpForIndusAmt.Controls.Add(this.label6);
            this.grpForIndusAmt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpForIndusAmt.Location = new System.Drawing.Point(62, 411);
            this.grpForIndusAmt.Name = "grpForIndusAmt";
            this.grpForIndusAmt.Padding = new System.Windows.Forms.Padding(0);
            this.grpForIndusAmt.Size = new System.Drawing.Size(425, 140);
            this.grpForIndusAmt.TabIndex = 5;
            this.grpForIndusAmt.TabStop = false;
            this.grpForIndusAmt.Visible = false;
            // 
            // txtOPCharge
            // 
            this.txtOPCharge.Enabled = false;
            this.txtOPCharge.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPCharge.Location = new System.Drawing.Point(294, 84);
            this.txtOPCharge.Name = "txtOPCharge";
            this.txtOPCharge.Size = new System.Drawing.Size(105, 32);
            this.txtOPCharge.TabIndex = 1;
            this.txtOPCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPeakCharge
            // 
            this.txtPeakCharge.Enabled = false;
            this.txtPeakCharge.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakCharge.Location = new System.Drawing.Point(294, 39);
            this.txtPeakCharge.Name = "txtPeakCharge";
            this.txtPeakCharge.Size = new System.Drawing.Size(105, 32);
            this.txtPeakCharge.TabIndex = 1;
            this.txtPeakCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Off peak hour charge (CAD)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Peak hour charge (CAD)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtAcctNum);
            this.groupBox2.Controls.Add(this.txtCustName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnAddCust);
            this.groupBox2.Location = new System.Drawing.Point(519, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(314, 141);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtAcctNum
            // 
            this.txtAcctNum.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctNum.Location = new System.Drawing.Point(189, 69);
            this.txtAcctNum.Margin = new System.Windows.Forms.Padding(0);
            this.txtAcctNum.Name = "txtAcctNum";
            this.txtAcctNum.Size = new System.Drawing.Size(105, 32);
            this.txtAcctNum.TabIndex = 4;
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(189, 27);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(0);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(105, 32);
            this.txtCustName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Account Number";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddCust
            // 
            this.btnAddCust.AutoSize = true;
            this.btnAddCust.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.Location = new System.Drawing.Point(124, 103);
            this.btnAddCust.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(51, 31);
            this.btnAddCust.TabIndex = 5;
            this.btnAddCust.Text = "&Add";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // lstCustomer
            // 
            this.lstCustomer.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lstCustomer.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 19;
            this.lstCustomer.Location = new System.Drawing.Point(519, 284);
            this.lstCustomer.MultiColumn = true;
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstCustomer.Size = new System.Drawing.Size(314, 308);
            this.lstCustomer.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(545, 616);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total Customers";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustNumber
            // 
            this.txtCustNumber.Enabled = false;
            this.txtCustNumber.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustNumber.Location = new System.Drawing.Point(708, 612);
            this.txtCustNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtCustNumber.Name = "txtCustNumber";
            this.txtCustNumber.Size = new System.Drawing.Size(105, 32);
            this.txtCustNumber.TabIndex = 0;
            this.txtCustNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(564, 658);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total Charges";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalCharges
            // 
            this.txtTotalCharges.Enabled = false;
            this.txtTotalCharges.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCharges.Location = new System.Drawing.Point(708, 654);
            this.txtTotalCharges.Margin = new System.Windows.Forms.Padding(0);
            this.txtTotalCharges.Name = "txtTotalCharges";
            this.txtTotalCharges.Size = new System.Drawing.Size(105, 32);
            this.txtTotalCharges.TabIndex = 0;
            this.txtTotalCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PowerBillCalculator.Properties.Resources.yellow_lightening;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(862, 691);
            this.Controls.Add(this.lstCustomer);
            this.Controls.Add(this.txtTotalCharges);
            this.Controls.Add(this.txtCustNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpForIndusAmt);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.grpForIndustrial);
            this.Controls.Add(this.grpForUsage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpCustType);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmCalculator";
            this.Text = "Power Bill Calculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.grpCustType.ResumeLayout(false);
            this.grpCustType.PerformLayout();
            this.grpForUsage.ResumeLayout(false);
            this.grpForUsage.PerformLayout();
            this.grpForIndustrial.ResumeLayout(false);
            this.grpForIndustrial.PerformLayout();
            this.grpForIndusAmt.ResumeLayout(false);
            this.grpForIndusAmt.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCustType;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpForUsage;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpForIndustrial;
        private System.Windows.Forms.TextBox txtOPUsage;
        private System.Windows.Forms.TextBox txtPeakUsage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox grpForIndusAmt;
        private System.Windows.Forms.TextBox txtOPCharge;
        private System.Windows.Forms.TextBox txtPeakCharge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAcctNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCustNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalCharges;
    }
}

