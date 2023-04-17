
namespace WindowsFormsApp1
{
    partial class Login
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
            this.txtUserID = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.picFingerprint = new System.Windows.Forms.PictureBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.atmLogin = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerprint)).BeginInit();
            this.atmLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserID
            // 
            this.txtUserID.AutoSize = true;
            this.txtUserID.Location = new System.Drawing.Point(134, 54);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(83, 25);
            this.txtUserID.TabIndex = 0;
            this.txtUserID.Text = "User ID";
            // 
            // txtPIN
            // 
            this.txtPIN.AutoSize = true;
            this.txtPIN.Location = new System.Drawing.Point(171, 122);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(46, 25);
            this.txtPIN.TabIndex = 1;
            this.txtPIN.Text = "PIN";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(248, 51);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(229, 31);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(248, 119);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.PasswordChar = '*';
            this.textBoxPIN.Size = new System.Drawing.Size(229, 31);
            this.textBoxPIN.TabIndex = 3;
            // 
            // picFingerprint
            // 
            this.picFingerprint.Location = new System.Drawing.Point(250, 193);
            this.picFingerprint.Name = "picFingerprint";
            this.picFingerprint.Size = new System.Drawing.Size(227, 143);
            this.picFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFingerprint.TabIndex = 4;
            this.picFingerprint.TabStop = false;
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(194, 412);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(136, 47);
            this.btRegister.TabIndex = 5;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(377, 412);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(136, 47);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // atmLogin
            // 
            this.atmLogin.Controls.Add(this.btLogin);
            this.atmLogin.Controls.Add(this.btRegister);
            this.atmLogin.Controls.Add(this.picFingerprint);
            this.atmLogin.Controls.Add(this.textBoxPIN);
            this.atmLogin.Controls.Add(this.textBoxID);
            this.atmLogin.Controls.Add(this.txtPIN);
            this.atmLogin.Controls.Add(this.txtUserID);
            this.atmLogin.Location = new System.Drawing.Point(352, 94);
            this.atmLogin.Name = "atmLogin";
            this.atmLogin.Size = new System.Drawing.Size(710, 535);
            this.atmLogin.TabIndex = 7;
            this.atmLogin.TabStop = false;
            this.atmLogin.Text = "AtmLogin";
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(1294, 713);
            this.Controls.Add(this.atmLogin);
            this.Name = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picFingerprint)).EndInit();
            this.atmLogin.ResumeLayout(false);
            this.atmLogin.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

       
       
        
        
        private System.Windows.Forms.Label txtUserID;
        private System.Windows.Forms.Label txtPIN;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.PictureBox picFingerprint;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.GroupBox atmLogin;
    }
}

