using HotelManagement.DangNhap;

namespace HotelManagement
{
    public partial class FormTrangChu : UserControl
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void FormTrangChu_Load(object? sender, EventArgs e)
        {
            lblTenNhanVien.Text = "Xin chào, " + FormDangNhap.TenNV_DangNhap + "!";
        }
    }
}
