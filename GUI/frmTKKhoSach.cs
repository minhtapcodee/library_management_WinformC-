using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QUANLYTHUVIENC3.BLL;

namespace QUANLYTHUVIENC3.GUI
{
    public partial class frmTKKhoSach : Form
    {
        private KhoSachBLL khoSachBLL = new KhoSachBLL();
        private SachBLL sachBLL = new SachBLL();

        public frmTKKhoSach()
        {
            InitializeComponent();
            InitializeControls();
            LoadData();
            CustomizeFormAppearance();
        }

        private void CustomizeFormAppearance()
        {
            this.Font = new Font("Segoe UI", 10F);
            this.BackColor = Color.FromArgb(240, 244, 255);
            CustomizeDataGridView();
            CustomizeInputControls();
        }

        private void CustomizeDataGridView()
        {
            dgvKhoSach.BackgroundColor = Color.White;
            dgvKhoSach.BorderStyle = BorderStyle.None;
            dgvKhoSach.EnableHeadersVisualStyles = false;
            dgvKhoSach.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(67, 115, 227);
            dgvKhoSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKhoSach.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvKhoSach.ColumnHeadersHeight = 40;
            dgvKhoSach.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvKhoSach.DefaultCellStyle.BackColor = Color.White;
            dgvKhoSach.DefaultCellStyle.ForeColor = Color.Black;
            dgvKhoSach.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvKhoSach.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);
            dgvKhoSach.DefaultCellStyle.SelectionBackColor = Color.FromArgb(135, 171, 255);
            dgvKhoSach.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvKhoSach.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvKhoSach.GridColor = Color.FromArgb(220, 220, 220);
        }

        private void CustomizeInputControls()
        {
            TextBox[] textBoxes = { txtMaKho, txtSoLuongNhap, txtMoTa, txtSearch };
            foreach (TextBox txt in textBoxes)
            {
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BackColor = Color.White;
                txt.ForeColor = Color.Black;
                txt.Font = new Font("Segoe UI", 10F);
            }

            ComboBox[] comboBoxes = { cbMaSach, cbMaNhanVien };
            foreach (ComboBox cb in comboBoxes)
            {
                cb.FlatStyle = FlatStyle.Flat;
                cb.BackColor = Color.White;
                cb.ForeColor = Color.Black;
                cb.Font = new Font("Segoe UI", 10F);
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            DateTimePicker[] datePickers = { dtpNgayNhap, dtpLocTheoNgay };
            foreach (DateTimePicker dtp in datePickers)
            {
                dtp.Format = DateTimePickerFormat.Custom;
                dtp.CustomFormat = "dd/MM/yyyy";
                dtp.Font = new Font("Segoe UI", 10F);
            }

            Label[] labels = { lblMaKho, lblMaSach, lblSoLuongNhap, lblNgayNhap, lblMoTa, lblMaNhanVien };
            foreach (Label lbl in labels)
            {
                lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                lbl.ForeColor = Color.FromArgb(50, 50, 50);
            }

            // Style buttons
            Button[] buttons = { btnThem, btnCapNhat, btnXoa, btnTimKiem, btnLamMoi, btnCanhBaoTonKho, btnBaoCao, btnLocTheoNgay };
            foreach (Button btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(67, 115, 227);
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn.Size = new Size(120, 35);
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(97, 145, 255);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 95, 207);

                // Apply rounded corners using CreateRoundRectRgn
                IntPtr ptr = CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 10, 10);
                btn.Region = Region.FromHrgn(ptr);
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void InitializeControls()
        {
            dgvKhoSach.AutoGenerateColumns = false;
            dgvKhoSach.Columns.Clear();

            DataGridViewTextBoxColumn colMaKho = new DataGridViewTextBoxColumn
            {
                Name = "MaKho",
                HeaderText = "Mã Kho",
                DataPropertyName = "MaKho"
            };
            dgvKhoSach.Columns.Add(colMaKho);

            DataGridViewTextBoxColumn colMaSach = new DataGridViewTextBoxColumn
            {
                Name = "MaSach",
                HeaderText = "Mã Sách",
                DataPropertyName = "MaSach"
            };
            dgvKhoSach.Columns.Add(colMaSach);

            DataGridViewTextBoxColumn colTenSach = new DataGridViewTextBoxColumn
            {
                Name = "TenSach",
                HeaderText = "Tên Sách",
                DataPropertyName = "TenSach"
            };
            dgvKhoSach.Columns.Add(colTenSach);

            DataGridViewTextBoxColumn colTenTheLoai = new DataGridViewTextBoxColumn
            {
                Name = "TenTheLoai",
                HeaderText = "Thể Loại",
                DataPropertyName = "TenTheLoai"
            };
            dgvKhoSach.Columns.Add(colTenTheLoai);

            DataGridViewTextBoxColumn colSoLuongNhap = new DataGridViewTextBoxColumn
            {
                Name = "SoLuongNhap",
                HeaderText = "Số Lượng Nhập",
                DataPropertyName = "SoLuongNhap"
            };
            dgvKhoSach.Columns.Add(colSoLuongNhap);

            DataGridViewTextBoxColumn colSoLuongDangMuon = new DataGridViewTextBoxColumn
            {
                Name = "SoLuongDangMuon",
                HeaderText = "Số Lượng Đang Mượn",
                DataPropertyName = "SoLuongDangMuon"
            };
            dgvKhoSach.Columns.Add(colSoLuongDangMuon);

            DataGridViewTextBoxColumn colSoLuongConLai = new DataGridViewTextBoxColumn
            {
                Name = "SoLuongConLai",
                HeaderText = "Số Lượng Còn Lại",
                DataPropertyName = "SoLuongConLai"
            };
            dgvKhoSach.Columns.Add(colSoLuongConLai);

            DataGridViewTextBoxColumn colMaNhanVien = new DataGridViewTextBoxColumn
            {
                Name = "MaNhanVien",
                HeaderText = "Mã Nhân Viên",
                DataPropertyName = "MaNhanVien"
            };
            dgvKhoSach.Columns.Add(colMaNhanVien);

            DataGridViewTextBoxColumn colNgayNhap = new DataGridViewTextBoxColumn
            {
                Name = "NgayNhap",
                HeaderText = "Ngày Nhập",
                DataPropertyName = "NgayNhap"
            };
            dgvKhoSach.Columns.Add(colNgayNhap);

            DataGridViewTextBoxColumn colMoTa = new DataGridViewTextBoxColumn
            {
                Name = "MoTa",
                HeaderText = "Mô Tả",
                DataPropertyName = "MoTa"
            };
            dgvKhoSach.Columns.Add(colMoTa);

            foreach (DataGridViewColumn column in dgvKhoSach.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            cbMaSach.DataSource = khoSachBLL.GetSach();
            cbMaSach.DisplayMember = "TenSach";
            cbMaSach.ValueMember = "MaSach";

            cbMaNhanVien.DataSource = khoSachBLL.GetNhanVien();
            cbMaNhanVien.DisplayMember = "HoTen";
            cbMaNhanVien.ValueMember = "ID";

            dtpNgayNhap.Value = DateTime.Now;
            dtpLocTheoNgay.Value = DateTime.Now;
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = khoSachBLL.GetKhoSach();
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu trong kho sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvKhoSach.DataSource = null;
                dgvKhoSach.DataSource = dt;
                dgvKhoSach.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maSach = cbMaSach.SelectedValue.ToString();
                int soLuongNhap = int.Parse(txtSoLuongNhap.Text);
                string ngayNhap = dtpNgayNhap.Value.ToString("yyyy-MM-dd");
                string moTa = txtMoTa.Text;
                int maNhanVien = int.Parse(cbMaNhanVien.SelectedValue.ToString());

                if (soLuongNhap <= 0)
                {
                    MessageBox.Show("Số lượng nhập phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (khoSachBLL.AddKhoSach(maSach, soLuongNhap, ngayNhap, moTa, maNhanVien))
                {
                    MessageBox.Show("Thêm sách vào kho thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKhoSach.SelectedRows.Count > 0)
                {
                    int maKho = int.Parse(dgvKhoSach.SelectedRows[0].Cells["MaKho"].Value.ToString());
                    int soLuongNhap = int.Parse(txtSoLuongNhap.Text);
                    DateTime ngayNhap = dtpNgayNhap.Value;
                    string moTa = txtMoTa.Text;

                    if (soLuongNhap <= 0)
                    {
                        MessageBox.Show("Số lượng nhập phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (khoSachBLL.UpdateKhoSach(maKho, soLuongNhap, ngayNhap, moTa))
                    {
                        MessageBox.Show("Cập nhật kho thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKhoSach.SelectedRows.Count > 0)
                {
                    int maKho = int.Parse(dgvKhoSach.SelectedRows[0].Cells["MaKho"].Value.ToString());
                    if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (khoSachBLL.DeleteKhoSach(maKho))
                        {
                            MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
            }
            else
            {
                DataTable dt = khoSachBLL.SearchKhoSach(keyword);
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvKhoSach.DataSource = null;
                dgvKhoSach.DataSource = dt;
                dgvKhoSach.Refresh();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            txtSearch.Clear();
            txtSoLuongNhap.Clear();
            txtMoTa.Clear();
            txtMaKho.Clear();
            dtpNgayNhap.Value = DateTime.Now;
            dtpLocTheoNgay.Value = DateTime.Now;
        }

        private void btnCanhBaoTonKho_Click(object sender, EventArgs e)
        {
            frmSachSapHet frm = new frmSachSapHet();
            frm.ShowDialog();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmLichSuNhapXuat frm = new frmLichSuNhapXuat();
            frm.ShowDialog();
        }

        private void dgvKhoSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhoSach.SelectedRows.Count > 0)
            {
                var row = dgvKhoSach.SelectedRows[0];
                txtMaKho.Text = row.Cells["MaKho"].Value?.ToString() ?? "";
                cbMaSach.SelectedValue = row.Cells["MaSach"].Value?.ToString() ?? "";
                txtSoLuongNhap.Text = row.Cells["SoLuongNhap"].Value?.ToString() ?? "";
                if (row.Cells["NgayNhap"].Value != null)
                {
                    dtpNgayNhap.Value = DateTime.Parse(row.Cells["NgayNhap"].Value.ToString());
                }
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString() ?? "";
                cbMaNhanVien.SelectedValue = row.Cells["MaNhanVien"].Value?.ToString() ?? "";
            }
        }

        private void txtMaKho_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtpLocTheoNgay_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnLocTheoNgay_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dtpLocTheoNgay.Value;
                DataTable dt = khoSachBLL.FilterKhoSachByDate(selectedDate.ToString("yyyy-MM-dd"));

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cho ngày đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvKhoSach.DataSource = null;
                    return;
                }

                dgvKhoSach.DataSource = null;
                dgvKhoSach.DataSource = dt;
                dgvKhoSach.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}