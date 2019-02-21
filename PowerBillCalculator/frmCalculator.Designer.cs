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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.grpForUsage.SuspendLayout();
            this.grpForIndustrial.SuspendLayout();
            this.grpForIndusAmt.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Power Bill Calculator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radIndustrial);
            this.groupBox1.Controls.Add(this.radCommercial);
            this.groupBox1.Controls.Add(this.radResidential);
            this.groupBox1.Location = new System.Drawing.Point(62, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Type";
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIndustrial.Location = new System.Drawing.Point(598, 33);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(116, 32);
            this.radIndustrial.TabIndex = 0;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCommercial.Location = new System.Drawing.Point(294, 33);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(144, 32);
            this.radCommercial.TabIndex = 0;
            this.radCommercial.Text = "Commercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Checked = true;
            this.radResidential.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radResidential.Location = new System.Drawing.Point(0, 33);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(132, 32);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Location = new System.Drawing.Point(506, 641);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 38);
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
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(785, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 38);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(229, 641);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 38);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpForUsage
            // 
            this.grpForUsage.AutoSize = true;
            this.grpForUsage.Controls.Add(this.txtUsage);
            this.grpForUsage.Controls.Add(this.label2);
            this.grpForUsage.Location = new System.Drawing.Point(62, 137);
            this.grpForUsage.Margin = new System.Windows.Forms.Padding(0);
            this.grpForUsage.Name = "grpForUsage";
            this.grpForUsage.Size = new System.Drawing.Size(724, 112);
            this.grpForUsage.TabIndex = 3;
            this.grpForUsage.TabStop = false;
            // 
            // txtUsage
            // 
            this.txtUsage.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsage.Location = new System.Drawing.Point(509, 44);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(125, 35);
            this.txtUsage.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please enter power usage (kWh)";
            // 
            // grpForIndustrial
            // 
            this.grpForIndustrial.AutoSize = true;
            this.grpForIndustrial.Controls.Add(this.txtOPUsage);
            this.grpForIndustrial.Controls.Add(this.txtPeakUsage);
            this.grpForIndustrial.Controls.Add(this.label4);
            this.grpForIndustrial.Controls.Add(this.label3);
            this.grpForIndustrial.Location = new System.Drawing.Point(62, 252);
            this.grpForIndustrial.Name = "grpForIndustrial";
            this.grpForIndustrial.Size = new System.Drawing.Size(724, 154);
            this.grpForIndustrial.TabIndex = 3;
            this.grpForIndustrial.TabStop = false;
            this.grpForIndustrial.Visible = false;
            // 
            // txtOPUsage
            // 
            this.txtOPUsage.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPUsage.Location = new System.Drawing.Point(509, 86);
            this.txtOPUsage.Name = "txtOPUsage";
            this.txtOPUsage.Size = new System.Drawing.Size(125, 35);
            this.txtOPUsage.TabIndex = 2;
            // 
            // txtPeakUsage
            // 
            this.txtPeakUsage.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakUsage.Location = new System.Drawing.Point(509, 27);
            this.txtPeakUsage.Name = "txtPeakUsage";
            this.txtPeakUsage.Size = new System.Drawing.Size(125, 35);
            this.txtPeakUsage.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Off peak hour power usage (kWh)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Peak hour power usage (kWh)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 586);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Amount (CAD)";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(571, 586);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(125, 35);
            this.txtTotal.TabIndex = 1;
            // 
            // grpForIndusAmt
            // 
            this.grpForIndusAmt.Controls.Add(this.txtOPCharge);
            this.grpForIndusAmt.Controls.Add(this.txtPeakCharge);
            this.grpForIndusAmt.Controls.Add(this.label7);
            this.grpForIndusAmt.Controls.Add(this.label6);
            this.grpForIndusAmt.Location = new System.Drawing.Point(62, 412);
            this.grpForIndusAmt.Name = "grpForIndusAmt";
            this.grpForIndusAmt.Size = new System.Drawing.Size(724, 150);
            this.grpForIndusAmt.TabIndex = 5;
            this.grpForIndusAmt.TabStop = false;
            this.grpForIndusAmt.Visible = false;
            // 
            // txtOPCharge
            // 
            this.txtOPCharge.Enabled = false;
            this.txtOPCharge.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPCharge.Location = new System.Drawing.Point(507, 91);
            this.txtOPCharge.Name = "txtOPCharge";
            this.txtOPCharge.Size = new System.Drawing.Size(125, 35);
            this.txtOPCharge.TabIndex = 1;
            // 
            // txtPeakCharge
            // 
            this.txtPeakCharge.Enabled = false;
            this.txtPeakCharge.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakCharge.Location = new System.Drawing.Point(507, 32);
            this.txtPeakCharge.Name = "txtPeakCharge";
            this.txtPeakCharge.Size = new System.Drawing.Size(125, 35);
            this.txtPeakCharge.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Off peak hour charge (CAD)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Peak hour charge (CAD)";
            // 
            // frmCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(856, 691);
            this.Controls.Add(this.grpForIndusAmt);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.grpForIndustrial);
            this.Controls.Add(this.grpForUsage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmCalculator";
            this.Text = "Power Bill Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpForUsage.ResumeLayout(false);
            this.grpForUsage.PerformLayout();
            this.grpForIndustrial.ResumeLayout(false);
            this.grpForIndustrial.PerformLayout();
            this.grpForIndusAmt.ResumeLayout(false);
            this.grpForIndusAmt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

