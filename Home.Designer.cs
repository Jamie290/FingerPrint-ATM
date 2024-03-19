
namespace WindowsFormsApp1
{
    partial class Home
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
            this.btBalance = new System.Windows.Forms.Button();
            this.btWithdrawal = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.btTransact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBalance
            // 
            this.btBalance.Location = new System.Drawing.Point(399, 212);
            this.btBalance.Name = "btBalance";
            this.btBalance.Size = new System.Drawing.Size(238, 72);
            this.btBalance.TabIndex = 0;
            this.btBalance.Text = "Balance";
            this.btBalance.UseVisualStyleBackColor = true;
            // 
            // btWithdrawal
            // 
            this.btWithdrawal.Location = new System.Drawing.Point(783, 212);
            this.btWithdrawal.Name = "btWithdrawal";
            this.btWithdrawal.Size = new System.Drawing.Size(238, 72);
            this.btWithdrawal.TabIndex = 1;
            this.btWithdrawal.Text = "Withdrawal";
            this.btWithdrawal.UseVisualStyleBackColor = true;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(783, 362);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(238, 72);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Send Money";
            this.btSend.UseVisualStyleBackColor = true;
            // 
            // btTransact
            // 
            this.btTransact.Location = new System.Drawing.Point(399, 362);
            this.btTransact.Name = "btTransact";
            this.btTransact.Size = new System.Drawing.Size(238, 72);
            this.btTransact.TabIndex = 3;
            this.btTransact.Text = "Transaction";
            this.btTransact.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 761);
            this.Controls.Add(this.btTransact);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.btWithdrawal);
            this.Controls.Add(this.btBalance);
            this.Name = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBalance;
        private System.Windows.Forms.Button btWithdrawal;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btTransact;
    }
}