using System;
using System.Windows.Forms;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmCaiDat : Form
    {
        // Event to notify theme change
        public event EventHandler<string> ThemeChanged;

        public frmCaiDat()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnLightTheme_Click(object sender, EventArgs e)
        {
            // Notify parent form to apply light theme
            ThemeChanged?.Invoke(this, "Light");
        }

        private void btnDarkTheme_Click(object sender, EventArgs e)
        {
            // Notify parent form to apply dark theme
            ThemeChanged?.Invoke(this, "Dark");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}