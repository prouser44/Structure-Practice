namespace Structure_Practice
{
    partial class Form2
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccntNumber = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblOverdraft = new System.Windows.Forms.Label();
            this.txtOverdraft = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(186, 139);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(240, 139);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(171, 186);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(60, 17);
            this.lblAdress.TabIndex = 2;
            this.lblAdress.Text = "Address";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(240, 181);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(100, 22);
            this.txtAdress.TabIndex = 3;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(240, 232);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 22);
            this.txtAccountNumber.TabIndex = 4;
            // 
            // lblAccntNumber
            // 
            this.lblAccntNumber.AutoSize = true;
            this.lblAccntNumber.Location = new System.Drawing.Point(118, 235);
            this.lblAccntNumber.Name = "lblAccntNumber";
            this.lblAccntNumber.Size = new System.Drawing.Size(113, 17);
            this.lblAccntNumber.TabIndex = 5;
            this.lblAccntNumber.Text = "Account Number";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(172, 281);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(59, 17);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(240, 281);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 22);
            this.txtBalance.TabIndex = 7;
            // 
            // lblOverdraft
            // 
            this.lblOverdraft.AutoSize = true;
            this.lblOverdraft.Location = new System.Drawing.Point(163, 335);
            this.lblOverdraft.Name = "lblOverdraft";
            this.lblOverdraft.Size = new System.Drawing.Size(68, 17);
            this.lblOverdraft.TabIndex = 8;
            this.lblOverdraft.Text = "Overdraft";
            // 
            // txtOverdraft
            // 
            this.txtOverdraft.Location = new System.Drawing.Point(240, 330);
            this.txtOverdraft.Name = "txtOverdraft";
            this.txtOverdraft.Size = new System.Drawing.Size(100, 22);
            this.txtOverdraft.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(175, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(319, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 475);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblAccntNumber;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblOverdraft;
        private System.Windows.Forms.TextBox txtOverdraft;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}