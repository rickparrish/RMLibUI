/*
  RMLibUI: Visual support classes/components used by multiple R&M Software programs
  Copyright (C) 2008-2014  Rick Parrish, R&M Software

  This file is part of RMLibUI.

  RMLibUI is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  any later version.

  RMLibUI is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with RMLibUI.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Windows.Forms;

namespace RandM.RMLibUI
{
    public class NumericInputBox : Form
    {
        #region Windows Contols and Constructor

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.TextBox txtInput;
        private Button cmdButton3;
        private Button cmdButton2;
        private Button cmdButton1;
        private Button cmdButton6;
        private Button cmdButton5;
        private Button cmdButton4;
        private Button cmdButton9;
        private Button cmdButton8;
        private Button cmdButton7;
        private Button cmdButton0;
        private Button cmdClear;

        /// <summary>
        /// Required designer variable.
        ///</summary>
        private System.ComponentModel.Container components = null;

        #endregion

        #region Dispose

        /// <summary>
        /// Clean up any resources being used.
        ///</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        ///</summary>
        private void InitializeComponent()
        {
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdButton3 = new System.Windows.Forms.Button();
            this.cmdButton2 = new System.Windows.Forms.Button();
            this.cmdButton1 = new System.Windows.Forms.Button();
            this.cmdButton6 = new System.Windows.Forms.Button();
            this.cmdButton5 = new System.Windows.Forms.Button();
            this.cmdButton4 = new System.Windows.Forms.Button();
            this.cmdButton9 = new System.Windows.Forms.Button();
            this.cmdButton8 = new System.Windows.Forms.Button();
            this.cmdButton7 = new System.Windows.Forms.Button();
            this.cmdButton0 = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrompt.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(12, 9);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(152, 76);
            this.lblPrompt.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(8, 95);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(237, 21);
            this.txtInput.TabIndex = 0;
            // 
            // cmdOK
            // 
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(170, 9);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 25);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(170, 40);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 25);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdButton3
            // 
            this.cmdButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdButton3.Location = new System.Drawing.Point(170, 283);
            this.cmdButton3.Name = "cmdButton3";
            this.cmdButton3.Size = new System.Drawing.Size(75, 75);
            this.cmdButton3.TabIndex = 17;
            this.cmdButton3.Text = "3";
            this.cmdButton3.UseVisualStyleBackColor = true;
            // 
            // cmdButton2
            // 
            this.cmdButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdButton2.Location = new System.Drawing.Point(89, 283);
            this.cmdButton2.Name = "cmdButton2";
            this.cmdButton2.Size = new System.Drawing.Size(75, 75);
            this.cmdButton2.TabIndex = 16;
            this.cmdButton2.Text = "2";
            this.cmdButton2.UseVisualStyleBackColor = true;
            // 
            // cmdButton1
            // 
            this.cmdButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdButton1.Location = new System.Drawing.Point(8, 283);
            this.cmdButton1.Name = "cmdButton1";
            this.cmdButton1.Size = new System.Drawing.Size(75, 75);
            this.cmdButton1.TabIndex = 15;
            this.cmdButton1.Text = "1";
            this.cmdButton1.UseVisualStyleBackColor = true;
            // 
            // cmdButton6
            // 
            this.cmdButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdButton6.Location = new System.Drawing.Point(170, 202);
            this.cmdButton6.Name = "cmdButton6";
            this.cmdButton6.Size = new System.Drawing.Size(75, 75);
            this.cmdButton6.TabIndex = 14;
            this.cmdButton6.Text = "6";
            this.cmdButton6.UseVisualStyleBackColor = true;
            // 
            // cmdButton5
            // 
            this.cmdButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdButton5.Location = new System.Drawing.Point(89, 202);
            this.cmdButton5.Name = "cmdButton5";
            this.cmdButton5.Size = new System.Drawing.Size(75, 75);
            this.cmdButton5.TabIndex = 13;
            this.cmdButton5.Text = "5";
            this.cmdButton5.UseVisualStyleBackColor = true;
            // 
            // cmdButton4
            // 
            this.cmdButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdButton4.Location = new System.Drawing.Point(8, 202);
            this.cmdButton4.Name = "cmdButton4";
            this.cmdButton4.Size = new System.Drawing.Size(75, 75);
            this.cmdButton4.TabIndex = 12;
            this.cmdButton4.Text = "4";
            this.cmdButton4.UseVisualStyleBackColor = true;
            // 
            // cmdButton9
            // 
            this.cmdButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdButton9.Location = new System.Drawing.Point(170, 121);
            this.cmdButton9.Name = "cmdButton9";
            this.cmdButton9.Size = new System.Drawing.Size(75, 75);
            this.cmdButton9.TabIndex = 11;
            this.cmdButton9.Text = "9";
            this.cmdButton9.UseVisualStyleBackColor = true;
            // 
            // cmdButton8
            // 
            this.cmdButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdButton8.Location = new System.Drawing.Point(89, 121);
            this.cmdButton8.Name = "cmdButton8";
            this.cmdButton8.Size = new System.Drawing.Size(75, 75);
            this.cmdButton8.TabIndex = 10;
            this.cmdButton8.Text = "8";
            this.cmdButton8.UseVisualStyleBackColor = true;
            // 
            // cmdButton7
            // 
            this.cmdButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdButton7.Location = new System.Drawing.Point(8, 121);
            this.cmdButton7.Name = "cmdButton7";
            this.cmdButton7.Size = new System.Drawing.Size(75, 75);
            this.cmdButton7.TabIndex = 9;
            this.cmdButton7.Text = "7";
            this.cmdButton7.UseVisualStyleBackColor = true;
            // 
            // cmdButton0
            // 
            this.cmdButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdButton0.Location = new System.Drawing.Point(8, 364);
            this.cmdButton0.Name = "cmdButton0";
            this.cmdButton0.Size = new System.Drawing.Size(75, 75);
            this.cmdButton0.TabIndex = 18;
            this.cmdButton0.Text = "0";
            this.cmdButton0.UseVisualStyleBackColor = true;
            // 
            // cmdClear
            // 
            this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.Location = new System.Drawing.Point(89, 364);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(156, 75);
            this.cmdClear.TabIndex = 19;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            // 
            // NumericInputBox
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(253, 451);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdButton0);
            this.Controls.Add(this.cmdButton3);
            this.Controls.Add(this.cmdButton2);
            this.Controls.Add(this.cmdButton1);
            this.Controls.Add(this.cmdButton6);
            this.Controls.Add(this.cmdButton5);
            this.Controls.Add(this.cmdButton4);
            this.Controls.Add(this.cmdButton9);
            this.Controls.Add(this.cmdButton8);
            this.Controls.Add(this.cmdButton7);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblPrompt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NumericInputBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "R&M Numeric Input Box";
            this.Load += new System.EventHandler(this.NumericInputBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button cmdCancel;
        #endregion

        public NumericInputBox(string prompt, string caption, string defaultText)
        {
            InitializeComponent();

            // Initialize dialog
            lblPrompt.Text = prompt;
            this.Text = caption;
            txtInput.Text = defaultText;

            // Set default return value
            _InputText = defaultText;

            // Initialize number buttons
            cmdButton0.Click += NumberButtonClick;
            cmdButton1.Click += NumberButtonClick;
            cmdButton2.Click += NumberButtonClick;
            cmdButton3.Click += NumberButtonClick;
            cmdButton4.Click += NumberButtonClick;
            cmdButton5.Click += NumberButtonClick;
            cmdButton6.Click += NumberButtonClick;
            cmdButton7.Click += NumberButtonClick;
            cmdButton8.Click += NumberButtonClick;
            cmdButton9.Click += NumberButtonClick;
            cmdClear.Click += cmdClear_Click;
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            // Save new return value
            _InputText = txtInput.Text;
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            txtInput.Text += ((Button)sender).Text;
        }

        private void NumericInputBox_Load(object sender, System.EventArgs e)
        {
            // Focus text box with all text highlighted
            txtInput.SelectAll();
            txtInput.Focus();
        }

        public string InputText
        {
            get { return _InputText; }
        }
        private string _InputText = "";
    }
}
