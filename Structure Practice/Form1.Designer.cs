namespace Structure_Practice
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAddNewAccount = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEditAcc = new System.Windows.Forms.Button();
            this.txtEditAcc = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(77, 108);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(53, 31);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAddNewAccount
            // 
            this.btnAddNewAccount.Location = new System.Drawing.Point(38, 46);
            this.btnAddNewAccount.Name = "btnAddNewAccount";
            this.btnAddNewAccount.Size = new System.Drawing.Size(169, 37);
            this.btnAddNewAccount.TabIndex = 1;
            this.btnAddNewAccount.Text = "Add New Account";
            this.btnAddNewAccount.UseVisualStyleBackColor = true;
            this.btnAddNewAccount.Click += new System.EventHandler(this.btnAddNewAccount_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(336, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(928, 500);
            this.listBox1.TabIndex = 2;
            // 
            // btnEditAcc
            // 
            this.btnEditAcc.Location = new System.Drawing.Point(77, 164);
            this.btnEditAcc.Name = "btnEditAcc";
            this.btnEditAcc.Size = new System.Drawing.Size(53, 31);
            this.btnEditAcc.TabIndex = 3;
            this.btnEditAcc.Text = "edit";
            this.btnEditAcc.UseVisualStyleBackColor = true;
            this.btnEditAcc.Click += new System.EventHandler(this.btnEditAcc_Click);
            // 
            // txtEditAcc
            // 
            this.txtEditAcc.Location = new System.Drawing.Point(136, 168);
            this.txtEditAcc.Name = "txtEditAcc";
            this.txtEditAcc.Size = new System.Drawing.Size(23, 22);
            this.txtEditAcc.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(38, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 37);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 617);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtEditAcc);
            this.Controls.Add(this.btnEditAcc);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAddNewAccount);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAddNewAccount;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEditAcc;
        private System.Windows.Forms.TextBox txtEditAcc;
        private System.Windows.Forms.Button btnClear;
    }
}

