namespace FinalProject_292
{
    partial class AddBill
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
            this.lblBillName = new System.Windows.Forms.Label();
            this.txtBillName = new System.Windows.Forms.TextBox();
            this.txtBalncInput = new System.Windows.Forms.TextBox();
            this.lblBalOwed = new System.Windows.Forms.Label();
            this.statusStripAddBill = new System.Windows.Forms.StatusStrip();
            this.statusLblUserMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLblUserAddBill = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.grpActSummary = new System.Windows.Forms.GroupBox();
            this.lstBillsAdded = new System.Windows.Forms.ListBox();
            this.statusStripAddBill.SuspendLayout();
            this.grpActSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting.Font = new System.Drawing.Font("Calibri Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGreeting.Location = new System.Drawing.Point(0, 0);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(143, 37);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "Add Bills...";
            // 
            // lblBillName
            // 
            this.lblBillName.AutoSize = true;
            this.lblBillName.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillName.Location = new System.Drawing.Point(43, 66);
            this.lblBillName.Name = "lblBillName";
            this.lblBillName.Size = new System.Drawing.Size(158, 17);
            this.lblBillName.TabIndex = 2;
            this.lblBillName.Text = "Enter the name of the bill: ";
            // 
            // txtBillName
            // 
            this.txtBillName.Location = new System.Drawing.Point(66, 87);
            this.txtBillName.Name = "txtBillName";
            this.txtBillName.Size = new System.Drawing.Size(149, 20);
            this.txtBillName.TabIndex = 3;
            // 
            // txtBalncInput
            // 
            this.txtBalncInput.Location = new System.Drawing.Point(66, 179);
            this.txtBalncInput.Name = "txtBalncInput";
            this.txtBalncInput.Size = new System.Drawing.Size(149, 20);
            this.txtBalncInput.TabIndex = 5;
            // 
            // lblBalOwed
            // 
            this.lblBalOwed.AutoSize = true;
            this.lblBalOwed.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalOwed.Location = new System.Drawing.Point(43, 158);
            this.lblBalOwed.Name = "lblBalOwed";
            this.lblBalOwed.Size = new System.Drawing.Size(159, 17);
            this.lblBalOwed.TabIndex = 4;
            this.lblBalOwed.Text = "What is the balance owed?";
            // 
            // statusStripAddBill
            // 
            this.statusStripAddBill.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLblUserMain,
            this.statusLblUserAddBill});
            this.statusStripAddBill.Location = new System.Drawing.Point(0, 266);
            this.statusStripAddBill.Name = "statusStripAddBill";
            this.statusStripAddBill.Size = new System.Drawing.Size(522, 22);
            this.statusStripAddBill.TabIndex = 22;
            // 
            // statusLblUserMain
            // 
            this.statusLblUserMain.Name = "statusLblUserMain";
            this.statusLblUserMain.Size = new System.Drawing.Size(0, 17);
            // 
            // statusLblUserAddBill
            // 
            this.statusLblUserAddBill.Name = "statusLblUserAddBill";
            this.statusLblUserAddBill.Size = new System.Drawing.Size(0, 17);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(103, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Add Bill";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAdd.Location = new System.Drawing.Point(255, 231);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAdd.TabIndex = 24;
            this.btnConfirmAdd.Text = "Confirm";
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.Location = new System.Drawing.Point(404, 231);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAdd.TabIndex = 25;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            // 
            // grpActSummary
            // 
            this.grpActSummary.Controls.Add(this.lstBillsAdded);
            this.grpActSummary.Font = new System.Drawing.Font("Calibri Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActSummary.Location = new System.Drawing.Point(255, 66);
            this.grpActSummary.Name = "grpActSummary";
            this.grpActSummary.Size = new System.Drawing.Size(224, 133);
            this.grpActSummary.TabIndex = 26;
            this.grpActSummary.TabStop = false;
            this.grpActSummary.Text = "Activity Summary";
            // 
            // lstBillsAdded
            // 
            this.lstBillsAdded.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBillsAdded.FormattingEnabled = true;
            this.lstBillsAdded.ItemHeight = 19;
            this.lstBillsAdded.Location = new System.Drawing.Point(6, 21);
            this.lstBillsAdded.Name = "lstBillsAdded";
            this.lstBillsAdded.Size = new System.Drawing.Size(212, 99);
            this.lstBillsAdded.TabIndex = 7;
            // 
            // AddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 288);
            this.Controls.Add(this.grpActSummary);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.btnConfirmAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStripAddBill);
            this.Controls.Add(this.txtBalncInput);
            this.Controls.Add(this.lblBalOwed);
            this.Controls.Add(this.txtBillName);
            this.Controls.Add(this.lblBillName);
            this.Controls.Add(this.lblGreeting);
            this.Name = "AddBill";
            this.Text = "AddBill";
            this.statusStripAddBill.ResumeLayout(false);
            this.statusStripAddBill.PerformLayout();
            this.grpActSummary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblBillName;
        private System.Windows.Forms.TextBox txtBillName;
        private System.Windows.Forms.TextBox txtBalncInput;
        private System.Windows.Forms.Label lblBalOwed;
        private System.Windows.Forms.StatusStrip statusStripAddBill;
        private System.Windows.Forms.ToolStripStatusLabel statusLblUserMain;
        private System.Windows.Forms.ToolStripStatusLabel statusLblUserAddBill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConfirmAdd;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.GroupBox grpActSummary;
        private System.Windows.Forms.ListBox lstBillsAdded;
    }
}