using HotelManagement.DangNhap;

namespace HotelManagement
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // Nối sự kiện cho 12 nút menu
            btnTrangChu.Click += btnTrangChu_Click;
            btnSoDoPhong.Click += btnSoDoPhong_Click;
            btnQuanLyPhong.Click += btnQuanLyPhong_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button9.Click += button9_Click;
            button10.Click += button10_Click;
            button11.Click += button11_Click;
            button12.Click += button12_Click;
            button13.Click += button13_Click;

            // Nối sự kiện Đăng xuất (linkLabel1) + Load form
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            this.Load += FormMain_Load;

            HienThiThongTinNguoiDung();
        }

        private void FormMain_Load(object? sender, EventArgs e)
        {
            HienThiTrangChu();
        }

        // ==================== Thông tin người dùng / đăng xuất ====================

        private void HienThiThongTinNguoiDung()
        {
            lblTenNguoiDung.Text = FormDangNhap.TenNV_DangNhap;
            lblTenNguoiDung.Left = Math.Max(10, (panel2.Width - lblTenNguoiDung.PreferredWidth) / 2);
        }

        private void linkLabel1_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            this.Hide();
            using (var formLogin = new FormDangNhap())
            {
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    HienThiThongTinNguoiDung();
                    HienThiTrangChu();
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }

        // ==================== Menu ====================

        private void btnTrangChu_Click(object? sender, EventArgs e)
        {
            HienThiTrangChu();
        }

        private void btnSoDoPhong_Click(object? sender, EventArgs e)
        {
            Form formCon = new SoDoPhong.FormSoDoPhong();
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            XoaNoiDungPanelMain();   // hàm có trong bản FormMain mình gửi trước; nếu chưa có, dùng panelMain.Controls.Clear();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void btnQuanLyPhong_Click(object? sender, EventArgs e)
        {
            Form formCon = new Phong.FormDanhSachPhong();
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            XoaNoiDungPanelMain();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button4_Click(object? sender, EventArgs e)
        {
            Form formCon = new LoaiPhong.FormDanhSachLoaiPhong();
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            XoaNoiDungPanelMain();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button5_Click(object? sender, EventArgs e)
        {
            HienThiDangPhatTrien("Danh sách tài khoản");
        }

        private void button6_Click(object? sender, EventArgs e)
        {
            HienThiDangPhatTrien("Danh sách khách hàng");
        }

        private void button7_Click(object? sender, EventArgs e)
        {
            HienThiDangPhatTrien("Danh sách nhân viên");
        }

        private void button9_Click(object? sender, EventArgs e)
        {
            HienThiDangPhatTrien("Danh sách đặt phòng");
        }

        private void button10_Click(object? sender, EventArgs e)
        {
            HienThiDangPhatTrien("Danh sách hóa đơn");
        }

        private void button11_Click(object? sender, EventArgs e)
        {
            HienThiDangPhatTrien("Danh sách dịch vụ");
        }

        private void button12_Click(object? sender, EventArgs e)
        {
            HienThiDangPhatTrien("Danh sách tiện nghi");
        }

        private void button13_Click(object? sender, EventArgs e)
        {
            HienThiDangPhatTrien("Thống kê");
        }

        // ==================== Hàm hỗ trợ hiển thị form con ====================

        private void XoaNoiDungPanelMain()
        {
            foreach (Control c in panelMain.Controls.Cast<Control>().ToList())
            {
                panelMain.Controls.Remove(c);
                c.Dispose();
            }
        }

        private void LoadUserControl(UserControl uc)
        {
            XoaNoiDungPanelMain();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
            uc.BringToFront();
        }

        private void LoadFormCon(Form formCon)
        {
            XoaNoiDungPanelMain();
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void HienThiTrangChu()
        {
            LoadUserControl(new FormTrangChu());
        }

        private void HienThiDangPhatTrien(string tenChucNang)
        {
            XoaNoiDungPanelMain();
            panelMain.Controls.Add(new Label
            {
                Dock = DockStyle.Fill,
                Text = tenChucNang + Environment.NewLine + "(chức năng đang được xây dựng)",
                Font = new Font("Segoe UI", 16F, FontStyle.Italic),
                ForeColor = Color.DarkCyan,
                TextAlign = ContentAlignment.MiddleCenter
            });
        }
    }
}
