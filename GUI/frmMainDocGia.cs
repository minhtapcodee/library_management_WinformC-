using System;
using System.Drawing;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;
using System.Data;
using QUANLYTHUVIENC3.Controls;
using System.Diagnostics;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmMainDocGia : Form
    {
        private SachBLL sachBLL = new SachBLL();
        private string maDocGia;
        private Button selectedButton;

        public frmMainDocGia(string maDocGia)
        {
            InitializeComponent();
            this.maDocGia = maDocGia;
            this.BackColor = Color.FromArgb(240, 248, 255);
            this.WindowState = FormWindowState.Maximized; 
            this.Resize += FrmMainDocGia_Resize;
            this.FormClosing += frmMainDocGia_FormClosing; 
        }

        public frmMainDocGia()
        {
            InitializeComponent();
        }

        private void frmMainDocGia_Load(object sender, EventArgs e)
        {
            AdjustMenuButtons();
            theSachTemplate.Visible = false;
            btnTrangChu.PerformClick();
        }

        private void AdjustMenuButtons()
        {
            int panelWidth = panelMenu.ClientSize.Width;
            int buttonCount = 5; // Sửa lỗi: thay bitCount thành buttonCount
            int margin = 20; 
            int totalMargin = margin * (buttonCount + 1);
            int buttonWidth = (panelWidth - totalMargin) / buttonCount;
            int buttonHeight = 50;

            Button[] buttons = { btnTrangChu, btnGioiThieu, btnTimKiem, btnMuonTra, btnThongTinCaNhan };
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Size = new Size(buttonWidth, buttonHeight);
                buttons[i].Location = new Point(margin + i * (buttonWidth + margin), (panelMenu.Height - buttonHeight) / 2);
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                buttons[i].ForeColor = Color.FromArgb(25, 25, 112);
                buttons[i].BackColor = Color.FromArgb(176, 224, 230);
            }
        }

        private void FrmMainDocGia_Resize(object sender, EventArgs e)
        {
            AdjustMenuButtons();
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != selectedButton)
            {
                btn.BackColor = Color.FromArgb(135, 206, 250); 
            }
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != selectedButton)
            {
                btn.BackColor = Color.FromArgb(176, 224, 230);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (selectedButton != null && selectedButton != btn)
            {
                selectedButton.BackColor = Color.FromArgb(176, 224, 230);
            }
            btn.BackColor = Color.FromArgb(70, 130, 180); 
            selectedButton = btn;
            Form frm = null;
            if (btn.Tag != null)
            {
                String tag = btn.Tag + "";
                switch (tag)
                {
                    case "Home":
                        SetupTrangChu();
                        break;
                    case "About":
                        frm = new frmGioiThieu();
                        break;
                    case "Info":
                        frm = new frmThongTin(maDocGia);
                        break;
                    case "Search":
                        frm = new frmTimKiem();
                        break;
                    case "Rent":
                        frm = new frmMuonTraDocGia(maDocGia);
                        break;
                }
            }

            if (frm != null)
            {
                panelContent.Controls.Clear();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                panelContent.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();
            }
        }

        private void SetupTrangChu()
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(
                new UCDocGiaPanel
                {
                    BackColor = Color.White,
                    Location = new Point(0, 0),
                    Size = new Size((int)(panelContent.ClientSize.Width), panelContent.ClientSize.Height)
                }
            );
        }

        private void frmMainDocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.WriteLine("frmMainDocGia đang đóng.");

            frmLogin loginForm = Application.OpenForms.OfType<frmLogin>().FirstOrDefault();
            if (loginForm == null)
            {
                Debug.WriteLine("Tạo mới frmLogin trước khi đóng frmMainDocGia.");
                loginForm = new frmLogin();
                loginForm.Show();
            }
            else
            {
                Debug.WriteLine("Hiển thị frmLogin hiện có trước khi đóng frmMainDocGia.");
                loginForm.Show();
                loginForm.BringToFront();
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}