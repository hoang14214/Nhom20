namespace Nhom20_MayTram
{
    partial class Nhom20_MayTram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_KetNoiTuDong = new System.Windows.Forms.TextBox();
            this.bt_TuDongKetNoi = new System.Windows.Forms.Button();
            this.bt_Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ds_KetNoi = new System.Windows.Forms.ComboBox();
            this.tb_DeTai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lv_ThanhVien = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_KetNoiTuDong
            // 
            this.tb_KetNoiTuDong.Location = new System.Drawing.Point(351, 8);
            this.tb_KetNoiTuDong.Name = "tb_KetNoiTuDong";
            this.tb_KetNoiTuDong.ReadOnly = true;
            this.tb_KetNoiTuDong.Size = new System.Drawing.Size(100, 20);
            this.tb_KetNoiTuDong.TabIndex = 17;
            // 
            // bt_TuDongKetNoi
            // 
            this.bt_TuDongKetNoi.Location = new System.Drawing.Point(253, 6);
            this.bt_TuDongKetNoi.Name = "bt_TuDongKetNoi";
            this.bt_TuDongKetNoi.Size = new System.Drawing.Size(92, 23);
            this.bt_TuDongKetNoi.TabIndex = 16;
            this.bt_TuDongKetNoi.Text = "Asynchronous";
            this.bt_TuDongKetNoi.UseVisualStyleBackColor = true;
            this.bt_TuDongKetNoi.Click += new System.EventHandler(this.bt_TuDongKetNoi_Click);
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(198, 6);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(49, 23);
            this.bt_Start.TabIndex = 15;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kiểu kết nối";
            // 
            // ds_KetNoi
            // 
            this.ds_KetNoi.FormattingEnabled = true;
            this.ds_KetNoi.Items.AddRange(new object[] {
            "BasicHttpBinding",
            "WSHttpBinding",
            "NetTcpBinding"});
            this.ds_KetNoi.Location = new System.Drawing.Point(81, 6);
            this.ds_KetNoi.Name = "ds_KetNoi";
            this.ds_KetNoi.Size = new System.Drawing.Size(110, 21);
            this.ds_KetNoi.TabIndex = 13;
            // 
            // tb_DeTai
            // 
            this.tb_DeTai.Location = new System.Drawing.Point(81, 33);
            this.tb_DeTai.Name = "tb_DeTai";
            this.tb_DeTai.Size = new System.Drawing.Size(370, 20);
            this.tb_DeTai.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đề tài";
            // 
            // lv_ThanhVien
            // 
            this.lv_ThanhVien.Location = new System.Drawing.Point(81, 61);
            this.lv_ThanhVien.Name = "lv_ThanhVien";
            this.lv_ThanhVien.Size = new System.Drawing.Size(370, 58);
            this.lv_ThanhVien.TabIndex = 10;
            this.lv_ThanhVien.TileSize = new System.Drawing.Size(130, 15);
            this.lv_ThanhVien.UseCompatibleStateImageBehavior = false;
            this.lv_ThanhVien.View = System.Windows.Forms.View.Tile;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thành viên";
            // 
            // Nhom20_MayTram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 128);
            this.Controls.Add(this.tb_KetNoiTuDong);
            this.Controls.Add(this.bt_TuDongKetNoi);
            this.Controls.Add(this.bt_Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ds_KetNoi);
            this.Controls.Add(this.tb_DeTai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lv_ThanhVien);
            this.Controls.Add(this.label1);
            this.Name = "Nhom20_MayTram";
            this.Text = "Máy trạm - Nhóm 20";
            this.Load += new System.EventHandler(this.Nhom20_MayTram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_KetNoiTuDong;
        private System.Windows.Forms.Button bt_TuDongKetNoi;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ds_KetNoi;
        private System.Windows.Forms.TextBox tb_DeTai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lv_ThanhVien;
        private System.Windows.Forms.Label label1;
    }
}

