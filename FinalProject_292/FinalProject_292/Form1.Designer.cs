namespace FinalProject_292
{
    partial class Form1
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lstBills = new System.Windows.Forms.ListBox();
            this.lblBills = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.btnRecEarn = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting.Font = new System.Drawing.Font("Calibri Light", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGreeting.Location = new System.Drawing.Point(-13, -7);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(195, 72);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello...";
            // 
            // lstBills
            // 
            this.lstBills.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lstBills.FormattingEnabled = true;
            this.lstBills.Location = new System.Drawing.Point(29, 93);
            this.lstBills.Name = "lstBills";
            this.lstBills.Size = new System.Drawing.Size(329, 95);
            this.lstBills.TabIndex = 1;
            // 
            // lblBills
            // 
            this.lblBills.AutoSize = true;
            this.lblBills.BackColor = System.Drawing.Color.Transparent;
            this.lblBills.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBills.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBills.Location = new System.Drawing.Point(17, 76);
            this.lblBills.Name = "lblBills";
            this.lblBills.Size = new System.Drawing.Size(69, 14);
            this.lblBills.TabIndex = 2;
            this.lblBills.Text = "Current Bills:";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.BackColor = System.Drawing.Color.Transparent;
            this.lblOptions.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(54, 238);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(103, 27);
            this.lblOptions.TabIndex = 3;
            this.lblOptions.Text = "I want to...";
            // 
            // btnRecEarn
            // 
            this.btnRecEarn.BackColor = System.Drawing.Color.Transparent;
            this.btnRecEarn.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecEarn.Location = new System.Drawing.Point(113, 268);
            this.btnRecEarn.Name = "btnRecEarn";
            this.btnRecEarn.Size = new System.Drawing.Size(142, 34);
            this.btnRecEarn.TabIndex = 4;
            this.btnRecEarn.Text = "Record Earnings";
            this.btnRecEarn.UseVisualStyleBackColor = false;
            // 
            // btnAddBill
            // 
            this.btnAddBill.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.Location = new System.Drawing.Point(339, 268);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(142, 34);
            this.btnAddBill.TabIndex = 5;
            this.btnAddBill.Text = "Add Bills";
            this.btnAddBill.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(565, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "Make Adjustments";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::FinalProject_292.Properties.Resources.Screen_Shot_2017_11_13_at_10_50_04_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 309);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.btnRecEarn);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblBills);
            this.Controls.Add(this.lstBills);
            this.Controls.Add(this.lblGreeting);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "//billTender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.ListBox lstBills;
        private System.Windows.Forms.Label lblBills;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button btnRecEarn;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button button3;
    }
}

