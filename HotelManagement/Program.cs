using HotelManagement.DangNhap;

namespace HotelManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Hiện form đăng nhập trước; chỉ khi đăng nhập OK mới mở form chính
            using (var formDangNhap = new FormDangNhap())
            {
                if (formDangNhap.ShowDialog() != DialogResult.OK)
                    return;
            }

            Application.Run(new FormMain());
        }
    }
}
