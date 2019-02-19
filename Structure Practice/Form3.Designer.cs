namespace Structure_Practice
{
    partial class Form3
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtOverdraft = new System.Windows.Forms.TextBox();
            this.lblOverdraft = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAccntNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(435, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(333, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtOverdraft
            // 
            this.txtOverdraft.Location = new System.Drawing.Point(384, 271);
            this.txtOverdraft.Name = "txtOverdraft";
            this.txtOverdraft.Size = new System.Drawing.Size(100, 22);
            this.txtOverdraft.TabIndex = 21;
            // 
            // lblOverdraft
            // 
            this.lblOverdraft.AutoSize = true;
            this.lblOverdraft.Location = new System.Drawing.Point(307, 276);
            this.lblOverdraft.Name = "lblOverdraft";
            this.lblOverdraft.Size = new System.Drawing.Size(68, 17);
            this.lblOverdraft.TabIndex = 20;
            this.lblOverdraft.Text = "Overdraft";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(384, 222);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 22);
            this.txtBalance.TabIndex = 19;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(316, 222);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(59, 17);
            this.lblBalance.TabIndex = 18;
            this.lblBalance.Text = "Balance";
            // 
            // lblAccntNumber
            // 
            this.lblAccntNumber.AutoSize = true;
            this.lblAccntNumber.Location = new System.Drawing.Point(262, 176);
            this.lblAccntNumber.Name = "lblAccntNumber";
            this.lblAccntNumber.Size = new System.Drawing.Size(113, 17);
            this.lblAccntNumber.TabIndex = 17;
            this.lblAccntNumber.Text = "Account Number";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(384, 173);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 22);
            this.txtAccountNumber.TabIndex = 16;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(384, 122);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(100, 22);
            this.txtAdress.TabIndex = 15;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(315, 127);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(60, 17);
            this.lblAdress.TabIndex = 14;
            this.lblAdress.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(384, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(330, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtOverdraft);
            this.Controls.Add(this.lblOverdraft);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAccntNumber);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtOverdraft;
        private System.Windows.Forms.Label lblOverdraft;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAccntNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}