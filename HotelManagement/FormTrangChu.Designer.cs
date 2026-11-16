namespace HotelManagement
{
    partial class FormTrangChu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblChaoMung = new Label();
            this.lblTenNhanVien = new Label();
            this.lblHuongDan = new Label();
            this.SuspendLayout();
            // 
            // lblChaoMung
            // 
            this.lblChaoMung.Anchor = AnchorStyles.None;
            this.lblChaoMung.AutoSize = true;
            this.lblChaoMung.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.lblChaoMung.ForeColor = Color.DarkCyan;
            this.lblChaoMung.Location = new Point(180, 150);
            this.lblChaoMung.Name = "lblChaoMung";
            this.lblChaoMung.Size = new Size(420, 45);
            this.lblChaoMung.TabIndex = 0;
            this.lblChaoMung.Text = "Chào mừng đến với khách sạn";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.Anchor = AnchorStyles.None;
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new Font("Segoe UI", 16F, FontStyle.Italic);
            this.lblTenNhanVien.ForeColor = Color.MidnightBlue;
            this.lblTenNhanVien.Location = new Point(180, 220);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new Size(200, 30);
            this.lblTenNhanVien.TabIndex = 1;
            this.lblTenNhanVien.Text = "Xin chào";
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.Anchor = AnchorStyles.None;
            this.lblHuongDan.AutoSize = true;
            this.lblHuongDan.Font = new Font("Segoe UI", 11F);
            this.lblHuongDan.ForeColor = Color.Gray;
            this.lblHuongDan.Location = new Point(180, 280);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new Size(380, 20);
            this.lblHuongDan.TabIndex = 2;
            this.lblHuongDan.Text = "Chọn chức năng ở menu bên trái để bắt đầu làm việc.";
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.Controls.Add(this.lblHuongDan);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.lblChaoMung);
            this.Name = "FormTrangChu";
            this.Size = new Size(1030, 628);
            this.Load += new EventHandler(this.FormTrangChu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblChaoMung;
        private Label lblTenNhanVien;
        private Label lblHuongDan;
    }
}
