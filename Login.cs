using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
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
        private void ScanFingerprint()
        {
            Bitmap scannedFingerprintImage = _fingerprintScanner.CaptureFingerprint();
            picFingerprint.Image = scannedFingerprintImage;
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

        // need to implement the AuthenticateUser method according to your specific requirements
        private bool AuthenticateUser(string userID, string pin, Bitmap scannedFingerprintImage)
        {
            // ...
        }

        private void btScanFingerprint_Click(object sender, EventArgs e)
        {
            ScanFingerprint();
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

        public Bitmap CaptureFingerprint()
        {
            int imageWidth, imageHeight;
            byte[] imageBuffer = null;

            // Get the image dimensions
            _fingerprintManager.GetImageSize(out imageWidth, out imageHeight);

            // Allocate memory for the image buffer
            imageBuffer = new byte[imageWidth * imageHeight];

            // Capture the fingerprint image
            int result = _fingerprintManager.GetImage(imageBuffer);
            if (result != (int)SGFPM_Error.ERROR_NONE)
            {
                // Handle the error (e.g., show an error message)
                return null;
            }
            // Create a Bitmap from the captured image buffer
            Bitmap fingerprintImage = new Bitmap(imageWidth, imageHeight, PixelFormat.Format8bppIndexed);

            // Set the grayscale color palette for the Bitmap
            ColorPalette palette = fingerprintImage.Palette;
            for (int i = 0; i < 256; i++)
            {
                palette.Entries[i] = Color.FromArgb(i, i, i);
            }
            fingerprintImage.Palette = palette;

            // Copy the image buffer to the Bitmap
            var rect = new Rectangle(0, 0, imageWidth, imageHeight);
            BitmapData bmpData = fingerprintImage.LockBits(rect, ImageLockMode.WriteOnly, fingerprintImage.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            int numBytes = bmpData.Stride * fingerprintImage.Height;
            Marshal.Copy(imageBuffer, 0, ptr, numBytes);
            fingerprintImage.UnlockBits(bmpData);

            return fingerprintImage;

        }
        // Add other fingerprint scanner functionality methods here
    }
}
