using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecuGen.FDxSDKPro.Windows;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private FingerprintScanner _fingerprintScanner;

        public Login()
        {
            InitializeComponent();
            _fingerprintScanner = new FingerprintScanner();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            _fingerprintScanner.InitializeScanner();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            _fingerprintScanner.CloseScanner();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            // Validate the user's credentials (User ID, PIN, and fingerprint)
            bool isValid = AuthenticateUser(txtUserID.Text, txtPIN.Text, /* scannedFingerprintImage */);

            if (isValid)
            {
                // Create an instance of the new form
                Home homeForm = new Home();

                // Show the new form
                homeForm.Show();

                // Close the login form (optional)
                this.Close();
            }
            else
            {
                // Show an error message or prompt the user to try again
                MessageBox.Show("Invalid credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // You will need to implement the AuthenticateUser method according to your specific requirements
        private bool AuthenticateUser(string userID, string pin, Bitmap scannedFingerprintImage)
        {
            // ...
        }
    }

    public class FingerprintScanner
    {
        private SGFingerPrintManager _fingerprintManager;

        public FingerprintScanner()
        {
            _fingerprintManager = new SGFingerPrintManager();
        }

        public void InitializeScanner()
        {
            _fingerprintManager.InitEx(0, 0, 0);
            _fingerprintManager.OpenDevice(0);
        }

        public void CloseScanner()
        {
            _fingerprintManager.CloseDevice();
            _fingerprintManager.Dispose();
        }

        // Add other fingerprint scanner functionality methods here
    }
}
