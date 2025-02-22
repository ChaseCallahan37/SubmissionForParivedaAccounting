﻿namespace AccountingProgram
{
    partial class yearsOfServiceTextBox
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.creationPanel = new System.Windows.Forms.Panel();
            this.yearsServiceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hourlyRadio = new System.Windows.Forms.RadioButton();
            this.salaryRadio = new System.Windows.Forms.RadioButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deptComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.payRateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.creationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.creationPanel);
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainPanel.Location = new System.Drawing.Point(824, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(463, 692);
            this.mainPanel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 57);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Creation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // creationPanel
            // 
            this.creationPanel.Controls.Add(this.yearsServiceTextBox);
            this.creationPanel.Controls.Add(this.label6);
            this.creationPanel.Controls.Add(this.hourlyRadio);
            this.creationPanel.Controls.Add(this.salaryRadio);
            this.creationPanel.Controls.Add(this.cancelButton);
            this.creationPanel.Controls.Add(this.saveButton);
            this.creationPanel.Controls.Add(this.deptComboBox);
            this.creationPanel.Controls.Add(this.label4);
            this.creationPanel.Controls.Add(this.payRateTextBox);
            this.creationPanel.Controls.Add(this.label3);
            this.creationPanel.Controls.Add(this.label5);
            this.creationPanel.Controls.Add(this.nameTextBox);
            this.creationPanel.Controls.Add(this.label1);
            this.creationPanel.Location = new System.Drawing.Point(17, 150);
            this.creationPanel.Name = "creationPanel";
            this.creationPanel.Size = new System.Drawing.Size(423, 408);
            this.creationPanel.TabIndex = 0;
            // 
            // yearsServiceTextBox
            // 
            this.yearsServiceTextBox.Location = new System.Drawing.Point(161, 78);
            this.yearsServiceTextBox.Name = "yearsServiceTextBox";
            this.yearsServiceTextBox.Size = new System.Drawing.Size(239, 26);
            this.yearsServiceTextBox.TabIndex = 22;
            this.yearsServiceTextBox.TextChanged += new System.EventHandler(this.yearsServiceTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Years of Service";
            // 
            // hourlyRadio
            // 
            this.hourlyRadio.AutoSize = true;
            this.hourlyRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hourlyRadio.Location = new System.Drawing.Point(161, 271);
            this.hourlyRadio.Name = "hourlyRadio";
            this.hourlyRadio.Size = new System.Drawing.Size(79, 24);
            this.hourlyRadio.TabIndex = 20;
            this.hourlyRadio.TabStop = true;
            this.hourlyRadio.Text = "Hourly";
            this.hourlyRadio.UseVisualStyleBackColor = true;
            // 
            // salaryRadio
            // 
            this.salaryRadio.AutoSize = true;
            this.salaryRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salaryRadio.Location = new System.Drawing.Point(161, 227);
            this.salaryRadio.Name = "salaryRadio";
            this.salaryRadio.Size = new System.Drawing.Size(78, 24);
            this.salaryRadio.TabIndex = 19;
            this.salaryRadio.TabStop = true;
            this.salaryRadio.Text = "Salary";
            this.salaryRadio.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Location = new System.Drawing.Point(134, 336);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 34);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Location = new System.Drawing.Point(297, 336);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(76, 34);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deptComboBox
            // 
            this.deptComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deptComboBox.FormattingEnabled = true;
            this.deptComboBox.Items.AddRange(new object[] {
            "customer service",
            "accounting",
            "human resource",
            "management",
            "manufactoring"});
            this.deptComboBox.Location = new System.Drawing.Point(161, 126);
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(239, 28);
            this.deptComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 40);
            this.label4.TabIndex = 16;
            this.label4.Text = "Compensation\r\nMethod";
            // 
            // payRateTextBox
            // 
            this.payRateTextBox.Location = new System.Drawing.Point(161, 175);
            this.payRateTextBox.Name = "payRateTextBox";
            this.payRateTextBox.Size = new System.Drawing.Size(239, 26);
            this.payRateTextBox.TabIndex = 15;
            this.payRateTextBox.TextChanged += new System.EventHandler(this.payRateTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pay Rate";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Department";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(161, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(239, 26);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1811, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Return";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yearsOfServiceTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yearsOfServiceTextBox";
            this.Text = "CreateEmployeeScreen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateEmployeeScreen_Load);
            this.mainPanel.ResumeLayout(false);
            this.creationPanel.ResumeLayout(false);
            this.creationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel creationPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox deptComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox payRateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton hourlyRadio;
        private System.Windows.Forms.RadioButton salaryRadio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yearsServiceTextBox;
        private System.Windows.Forms.Button button1;
    }
}