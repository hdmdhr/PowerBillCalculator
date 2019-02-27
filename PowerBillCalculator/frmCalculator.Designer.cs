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
            this.radResidential.TabStop = true;
            this.radResidential.Tag = "R";
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(317, 579);
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
            this.btnReset.Location = new System.Drawing.Point(124, 579);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(71, 35);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpForUsage
            // 
            this.grpForUsage.AutoSize = true;
            this.grpForUsage.BackColor = System.Drawing.Color.Transparent;
            this.grpForUsage.Controls.Add(this.txtUsage);
            this.grpForUsage.Controls.Add(this.label2);
            this.grpForUsage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpForUsage.Location = new System.Drawing.Point(62, 137);
            this.grpForUsage.Margin = new System.Windows.Forms.Padding(0);
            this.grpForUsage.Name = "grpForUsage";
            this.grpForUsage.Padding = new System.Windows.Forms.Padding(0);
            this.grpForUsage.Size = new System.Drawing.Size(425, 87);
            this.grpForUsage.TabIndex = 3;
            this.grpForUsage.TabStop = false;
            // 
            // txtUsage
            // 
            this.txtUsage.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsage.Location = new System.Drawing.Point(294, 29);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(105, 28);
            this.txtUsage.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please enter power usage (kWh)";
            // 
            // grpForIndustrial
            // 
            this.grpForIndustrial.AutoSize = true;
            this.grpForIndustrial.BackColor = System.Drawing.Color.Transparent;
            this.grpForIndustrial.Controls.Add(this.txtOPUsage);
            this.grpForIndustrial.Controls.Add(this.txtPeakUsage);
            this.grpForIndustrial.Controls.Add(this.label4);
            this.grpForIndustrial.Controls.Add(this.label3);
            this.grpForIndustrial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpForIndustrial.Location = new System.Drawing.Point(62, 244);
            this.grpForIndustrial.Name = "grpForIndustrial";
            this.grpForIndustrial.Padding = new System.Windows.Forms.Padding(0);
            this.grpForIndustrial.Size = new System.Drawing.Size(425, 114);
            this.grpForIndustrial.TabIndex = 3;
            this.grpForIndustrial.TabStop = false;
            this.grpForIndustrial.Visible = false;
            // 
            // txtOPUsage
            // 
            this.txtOPUsage.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPUsage.Location = new System.Drawing.Point(294, 56);
            this.txtOPUsage.Name = "txtOPUsage";
            this.txtOPUsage.Size = new System.Drawing.Size(105, 28);
            this.txtOPUsage.TabIndex = 2;
            // 
            // txtPeakUsage
            // 
            this.txtPeakUsage.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakUsage.Location = new System.Drawing.Point(294, 21);
            this.txtPeakUsage.Name = "txtPeakUsage";
            this.txtPeakUsage.Size = new System.Drawing.Size(105, 28);
            this.txtPeakUsage.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Off peak hour power usage (kWh)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Peak hour power usage (kWh)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Amount (CAD)";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(356, 514);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(105, 28);
            this.txtTotal.TabIndex = 1;
            // 
            // grpForIndusAmt
            // 
            this.grpForIndusAmt.AutoSize = true;
            this.grpForIndusAmt.BackColor = System.Drawing.Color.Transparent;
            this.grpForIndusAmt.Controls.Add(this.txtOPCharge);
            this.grpForIndusAmt.Controls.Add(this.txtPeakCharge);
            this.grpForIndusAmt.Controls.Add(this.label7);
            this.grpForIndusAmt.Controls.Add(this.label6);
            this.grpForIndusAmt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpForIndusAmt.Location = new System.Drawing.Point(62, 378);
            this.grpForIndusAmt.Name = "grpForIndusAmt";
            this.grpForIndusAmt.Padding = new System.Windows.Forms.Padding(0);
            this.grpForIndusAmt.Size = new System.Drawing.Size(425, 119);
            this.grpForIndusAmt.TabIndex = 5;
            this.grpForIndusAmt.TabStop = false;
            this.grpForIndusAmt.Visible = false;
            // 
            // txtOPCharge
            // 
            this.txtOPCharge.Enabled = false;
            this.txtOPCharge.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPCharge.Location = new System.Drawing.Point(294, 61);
            this.txtOPCharge.Name = "txtOPCharge";
            this.txtOPCharge.Size = new System.Drawing.Size(105, 28);
            this.txtOPCharge.TabIndex = 1;
            // 
            // txtPeakCharge
            // 
            this.txtPeakCharge.Enabled = false;
            this.txtPeakCharge.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakCharge.Location = new System.Drawing.Point(294, 27);
            this.txtPeakCharge.Name = "txtPeakCharge";
            this.txtPeakCharge.Size = new System.Drawing.Size(105, 28);
            this.txtPeakCharge.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Off peak hour charge (CAD)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Peak hour charge (CAD)";
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
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // txtAcctNum
            // 
            this.txtAcctNum.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctNum.Location = new System.Drawing.Point(189, 69);
            this.txtAcctNum.Margin = new System.Windows.Forms.Padding(0);
            this.txtAcctNum.Name = "txtAcctNum";
            this.txtAcctNum.Size = new System.Drawing.Size(105, 28);
            this.txtAcctNum.TabIndex = 0;
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(189, 33);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(0);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(105, 28);
            this.txtCustName.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Account Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer Name";
            // 
            // btnAddCust
            // 
            this.btnAddCust.AutoSize = true;
            this.btnAddCust.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.Location = new System.Drawing.Point(216, 104);
            this.btnAddCust.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(51, 31);
            this.btnAddCust.TabIndex = 2;
            this.btnAddCust.Text = "&Add";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // lstCustomer
            // 
            this.lstCustomer.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lstCustomer.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 21;
            this.lstCustomer.Location = new System.Drawing.Point(519, 284);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(314, 340);
            this.lstCustomer.TabIndex = 7;
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
            this.Controls.Add(this.groupBox2);
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
    }
}

