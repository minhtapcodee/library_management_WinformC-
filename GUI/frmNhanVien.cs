using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmNhanVien : Form
    {
        FrmNhanvienAdmin nhanvienAdmin;
        SachForm sachForm;
        TheLoaiSachForm theLoaiSachForm;
        frmMuonTra muonTra;
        frmDocGia docGia;
        frmThongKe frmThongKe;
        frmKhoSach frmKhoSach;
        frmNgayCong frmNgayCong;
        frmNgayCongNhanvien frmNgayCongNhanvien;
        frmPhanQuyen frmPhanQuyen;
        frmCaiDat frmCaiDat;
        frmTongHopNhanvien frmTongHopNhanvien;
        frmProfileNhanvien frmProfile;
        private Control mdiClient;
        private Button lastActiveButtonInMenuContainer;
        private int loggedInUserId;
        private string loggedInUserRole;
        private bool isLightTheme = true; // Default to light theme with green palette
        // Add fields to store profile data
        private string maNhanvien;
        private string hoTen;
        private string ngaySinh;
        private string diaChi;
        private string soDienThoai;
        private string email;
        private string gioiTinh; // Add field for GioiTinh
        private string username;

        public frmNhanVien(int userId, string role, string maNhanvien = "", string hoTen = "", string ngaySinh = "", string diaChi = "", string soDienThoai = "", string email = "", string gioiTinh = "", string username = "")
        {
            InitializeComponent();
            loggedInUserId = userId;
            loggedInUserRole = role;
            this.maNhanvien = maNhanvien;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.gioiTinh = gioiTinh;
            this.username = username;
            this.WindowState = FormWindowState.Maximized;
        }

        public frmNhanVien()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true; // Ensure the form is an MDI container
            this.WindowState = FormWindowState.Maximized;
            mdiClient = this.Controls.OfType<Control>().FirstOrDefault(c => c.GetType().Name == "MdiClient");
            if (mdiClient != null)
            {
                try
                {
                    mdiClient.Dock = DockStyle.Fill; // Đảm bảo MDI Client lấp đầy form cha
                    string imagePath = @"C:\Users\DELL\Visual .NET folder\QUANLYTHUVIENC3\QUANLYTHUVIENC3\GUI\Image\backgrod.jpg";
                    if (!File.Exists(imagePath))
                    {
                        MessageBox.Show($"File không tồn tại tại đường dẫn: {imagePath}", "Lỗi");
                    }
                    else
                    {
                        // Set the background image on the form instead of mdiClient
                        this.BackgroundImage = Image.FromFile(imagePath);
                        this.BackgroundImageLayout = ImageLayout.Stretch;
                        // Make the mdiClient transparent to show the form's background
                        mdiClient.BackColor = Color.Transparent;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show($"Lỗi khi tải hình ảnh: {ex.Message}\nStackTrace: {ex.StackTrace}", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy MDI Client!", "Lỗi");
            }
            ApplyTheme(); // Apply default theme
        }

        private void ApplyTheme()
        {
            Color sidebarColor = isLightTheme ? Color.FromArgb(127, 255, 212) : Color.FromArgb(23, 24, 29); // #D4F4D4 for light, #17181D for dark
            Color buttonBackColor = isLightTheme ? Color.FromArgb(127, 255, 212) : Color.FromArgb(23, 24, 29); // #D4F4D4
            Color buttonForeColor = isLightTheme ? Color.Black : Color.White;
            Color panelTopColor = isLightTheme ? Color.FromArgb(139, 195, 74) : Color.DarkSlateGray; // #8BC34A
            Color labelForeColor = isLightTheme ? Color.Black : Color.White;

            sidebar.BackColor = sidebarColor;
            menuContainer.BackColor = sidebarColor;
            panel12.BackColor = panelTopColor;
            label1.ForeColor = labelForeColor;

            ResetButtonColors();
        }

        private void HideBackground()
        {
            if (mdiClient != null)
            {
                mdiClient.BackgroundImage = null;
            }
        }

        private void ShowBackground()
        {
            if (mdiClient != null)
            {
                try
                {
                    string imagePath = Path.Combine("GUI", "Image", "background.png");
                    if (!File.Exists(imagePath))
                    {
                        MessageBox.Show($"File không tồn tại tại đường dẫn: {Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath)}", "Lỗi");
                    }
                    else
                    {
                        mdiClient.BackgroundImage = Image.FromFile(imagePath);
                        mdiClient.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải hình ảnh: {ex.Message}\nStackTrace: {ex.StackTrace}", "Lỗi");
                }
            }
        }

        private void ResetButtonColors()
        {
            Color defaultBackColor = isLightTheme ? Color.FromArgb(127, 255, 212) : Color.FromArgb(23, 24, 29); // #D4F4D4
            Color defaultForeColor = isLightTheme ? Color.Black : Color.White;

            foreach (Control control in sidebar.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control innerControl in panel.Controls)
                    {
                        if (innerControl is Button btn)
                        {
                            btn.BackColor = defaultBackColor;
                            btn.ForeColor = defaultForeColor;
                            btn.FlatAppearance.BorderSize = 0;
                        }
                    }
                }
                else if (control is Button btn)
                {
                    btn.BackColor = defaultBackColor;
                    btn.ForeColor = defaultForeColor;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }

            ResetButtonsInContainer(menuContainer, defaultBackColor, defaultForeColor);
        }

        private void ResetButtonsInContainer(Control container, Color defaultBackColor, Color defaultForeColor)
        {
            foreach (Control control in container.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = defaultBackColor;
                    btn.ForeColor = defaultForeColor;
                    btn.FlatAppearance.BorderSize = 0;
                }
                else if (control.HasChildren)
                {
                    ResetButtonsInContainer(control, defaultBackColor, defaultForeColor);
                }
            }
        }

        private void SetActiveButton(Button selectedButton)
        {
            Color activeBackColor = isLightTheme ? Color.FromArgb(38, 166, 154) : SystemColors.ButtonShadow; // #26A69A
            Color activeForeColor = isLightTheme ? Color.White : Color.Black;
            Color activeBorderColor = isLightTheme ? Color.FromArgb(77, 208, 225) : Color.DarkGray; // #4DD0E1

            selectedButton.BackColor = activeBackColor;
            selectedButton.ForeColor = activeForeColor;
            selectedButton.FlatAppearance.BorderSize = 2;
            selectedButton.FlatAppearance.BorderColor = activeBorderColor;
            selectedButton.FlatStyle = FlatStyle.Flat;

            if (menuContainer.Controls.Contains(selectedButton) || menuContainer.Controls.OfType<Control>().Any(c => c.Controls.Contains(selectedButton)))
            {
                lastActiveButtonInMenuContainer = selectedButton;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) { }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e) { }

        private void panel3_Paint(object sender, PaintEventArgs e) { }

        private void menu_Click(object sender, EventArgs e) { }

        bool menuExpand = true;

        private void menuContainer_Click(object sender, EventArgs e) { }

        private void menuTransion_Tick(object sender, EventArgs e) { }

        private void menuContainer_Paint(object sender, PaintEventArgs e) { }

        bool sidebarExpand = true;
        private Form activeForm = null;

        private void sidebarTransition_Tick(object sender, EventArgs e) { }

        private void btnHam_Click(object sender, EventArgs e)
        {
            activeForm = this.ActiveMdiChild;
            if (activeForm != null)
            {
                activeForm.Dock = DockStyle.None;
            }

            if (sidebarExpand)
            {
                sidebar.Width = 58;
                sidebarExpand = false;
                menuContainer.Height = 52;
                menuExpand = false;
                ResetButtonColors();
                SetActiveButton(menu);
            }
            else
            {
                sidebar.Width = 239;
                sidebarExpand = true;
                ResetButtonColors();
                if (lastActiveButtonInMenuContainer != null)
                {
                    SetActiveButton(lastActiveButtonInMenuContainer);
                }
            }

            pnDashboard.Width = sidebar.Width;
            pnBooks.Width = sidebar.Width;
            pnBorrow.Width = sidebar.Width;
            pnCatagoryBook.Width = sidebar.Width;
            pnSettings.Width = sidebar.Width;
            pnLogout.Width = sidebar.Width;
            menuContainer.Width = sidebar.Width;

            if (activeForm != null)
            {
                activeForm.Dock = DockStyle.Fill;
            }
        }

        private void button13_Click(object sender, EventArgs e) { }

        private void sidebar_Paint(object sender, PaintEventArgs e) { }

        private void button7_Click(object sender, EventArgs e) { }

        private void menu_Click_1(object sender, EventArgs e)
        {
            ResetButtonColors();
            SetActiveButton((Button)sender);

            if (docGia == null)
            {
                docGia = new frmDocGia();
                docGia.FormClosed += docGia1_FormClosed;
                docGia.MdiParent = this;
                docGia.Dock = DockStyle.Fill;
                docGia.Show();
            }
            else
            {
                docGia.Activate();
            }
        }

        private void docGia1_FormClosed(object sender, FormClosedEventArgs e)
        {
            docGia = null;
        }

        private void menuContainer_Paint_1(object sender, PaintEventArgs e) { }

        private void menuContainer_Paint_2(object sender, EventArgs e) { }

        private void docgiaadmin_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            SetActiveButton((Button)sender);
            if (docGia == null)
            {
                docGia = new frmDocGia();
                docGia.FormClosed += docGia_FormClosed;
                docGia.MdiParent = this;
                docGia.Dock = DockStyle.Fill;
                docGia.Show();
            }
            else
            {
                docGia.Activate();
            }
        }

        private void docGia_FormClosed(object sender, FormClosedEventArgs e)
        {
            docGia = null;
        }

        private void nhanvienadmin_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            SetActiveButton((Button)sender);
            if (nhanvienAdmin == null)
            {
                nhanvienAdmin = new FrmNhanvienAdmin();
                nhanvienAdmin.FormClosed += nhanvienAdmin_FormClosed;
                nhanvienAdmin.MdiParent = this;
                nhanvienAdmin.Dock = DockStyle.Fill;
                nhanvienAdmin.Show();
            }
            else
            {
                nhanvienAdmin.Activate();
            }
        }

        private void nhanvienAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            nhanvienAdmin = null;
        }

        private void btnSachForm_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            SetActiveButton((Button)sender);
            if (sachForm == null)
            {
                sachForm = new SachForm();
                sachForm.FormClosed += sachForm_FormClosed;
                sachForm.MdiParent = this;
                sachForm.FormBorderStyle = FormBorderStyle.None;
                sachForm.Dock = DockStyle.Fill;
                sachForm.Show();
            }
            else
            {
                sachForm.Activate();
            }
        }

        private void sachForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sachForm = null;
        }

       

        private void btnTheLoaiSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            theLoaiSachForm = null;
        }

        private void btnTheLoaiSach_Click_1(object sender, EventArgs e)
        {
            ResetButtonColors();
            SetActiveButton((Button)sender);
            if (theLoaiSachForm == null)
            {
                theLoaiSachForm = new TheLoaiSachForm();
                theLoaiSachForm.FormClosed += btnTheLoaiSach_FormClosed;
                theLoaiSachForm.MdiParent = this;
                theLoaiSachForm.FormBorderStyle = FormBorderStyle.None;
                theLoaiSachForm.Dock = DockStyle.Fill;
                theLoaiSachForm.Show();
            }
            else
            {
                theLoaiSachForm.Activate();
            }
        }

        private void muonTra_FormClosed(object sender, FormClosedEventArgs e)
        {
            muonTra = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            SetActiveButton((Button)sender);
            if (muonTra == null)
            {
                muonTra = new frmMuonTra();
                muonTra.FormClosed += muonTra_FormClosed;
                muonTra.MdiParent = this;
                muonTra.Dock = DockStyle.Fill;
                muonTra.Show();
            }
            else
            {
                muonTra.Activate();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            SetActiveButton((Button)sender);
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin loginForm = new frmLogin();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            ResetButtonColors();
            SetActiveButton((Button)sender);

            if (frmTongHopNhanvien == null)
            {
                frmTongHopNhanvien = new frmTongHopNhanvien();
                frmTongHopNhanvien.FormClosed += frmTongHopNhanvien_FormClosed;
                frmTongHopNhanvien.MdiParent = this;
                frmTongHopNhanvien.Dock = DockStyle.Fill;
                frmTongHopNhanvien.Show();

            }
            else
            {
                frmTongHopNhanvien.Activate();

            }
        }
        private void frmTongHopNhanvien_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTongHopNhanvien = null;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            SetActiveButton((Button)sender);
            if (frmNgayCongNhanvien == null)
            {
                frmNgayCongNhanvien = new frmNgayCongNhanvien(loggedInUserId, loggedInUserRole);
                frmNgayCongNhanvien.FormClosed += frmNgayCongNhanvien_FormClosed;
                frmNgayCongNhanvien.MdiParent = this;
                frmNgayCongNhanvien.Dock = DockStyle.Fill;
                frmNgayCongNhanvien.Show();
            }
            else
            {
                frmNgayCongNhanvien.Activate();
            }
        }

        private void frmNgayCongNhanvien_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmNgayCongNhanvien = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            SetActiveButton((Button)sender);
            if (frmKhoSach == null)
            {
                frmKhoSach = new frmKhoSach();
                frmKhoSach.FormClosed += frmKhoSach_FormClosed;
                frmKhoSach.MdiParent = this;
                frmKhoSach.FormBorderStyle = FormBorderStyle.None;
                frmKhoSach.Dock = DockStyle.Fill;
                frmKhoSach.Show();
            }
            else
            {
                frmKhoSach.Activate();
            }
        }

        private void frmKhoSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKhoSach = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            SetActiveButton((Button)sender);
            if (frmCaiDat == null)
            {
                frmCaiDat = new frmCaiDat();
                frmCaiDat.FormClosed += frmCaiDat_FormClosed;
                frmCaiDat.MdiParent = this;
                frmCaiDat.FormBorderStyle = FormBorderStyle.None;
                frmCaiDat.Dock = DockStyle.Fill;
                frmCaiDat.ThemeChanged += FrmCaiDat_ThemeChanged;
                frmCaiDat.Show();
            }
            else
            {
                frmCaiDat.Activate();
            }
        }

        private void FrmCaiDat_ThemeChanged(object sender, string theme)
        {
            isLightTheme = theme == "Light";
            ApplyTheme();
            if (lastActiveButtonInMenuContainer != null)
            {
                SetActiveButton(lastActiveButtonInMenuContainer);
            }
            else
            {
                ResetButtonColors();
            }
        }

        private void frmCaiDat_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCaiDat = null;
        }

        private void picBackgroud_Click(object sender, EventArgs e) { }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            SetActiveButton((Button)sender);
            if (frmPhanQuyen == null)
            {
                frmPhanQuyen = new frmPhanQuyen();
                frmPhanQuyen.FormClosed += frmPhanQuyen_FormClosed;
                frmPhanQuyen.MdiParent = this;
                frmPhanQuyen.Dock = DockStyle.Fill;
                frmPhanQuyen.Show();
            }
            else
            {
                frmPhanQuyen.Activate();
            }
        }

        private void frmPhanQuyen_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPhanQuyen = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            SetActiveButton((Button)sender);

            if (frmProfile == null)
            {
                frmProfile = new frmProfileNhanvien();
                frmProfile.FormClosed += frmProfile_FormClosed;
                frmProfile.MdiParent = this;
                frmProfile.Dock = DockStyle.Fill;
                // Load the stored profile data into frmProfileNhanvien
                frmProfile.LoadUserData(maNhanvien, hoTen, ngaySinh, diaChi, soDienThoai, email, gioiTinh, username);
                frmProfile.Show();
            }
            else
            {
                frmProfile.Activate();
            }
        }

        private void frmProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProfile = null;
        }
    }
}