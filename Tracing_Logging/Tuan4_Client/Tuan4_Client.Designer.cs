namespace Tuan4_Client
{
    partial class Tuan4_Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.lv_ThanhVien = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_DeTai = new System.Windows.Forms.TextBox();
            this.ds_KetNoi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thành viên";
            // 
            // lv_ThanhVien
            // 
            this.lv_ThanhVien.Location = new System.Drawing.Point(80, 61);
            this.lv_ThanhVien.Name = "lv_ThanhVien";
            this.lv_ThanhVien.Size = new System.Drawing.Size(166, 58);
            this.lv_ThanhVien.TabIndex = 1;
            this.lv_ThanhVien.TileSize = new System.Drawing.Size(130, 15);
            this.lv_ThanhVien.UseCompatibleStateImageBehavior = false;
            this.lv_ThanhVien.View = System.Windows.Forms.View.Tile;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đề tài";
            // 
            // tb_DeTai
            // 
            this.tb_DeTai.Location = new System.Drawing.Point(80, 33);
            this.tb_DeTai.Name = "tb_DeTai";
            this.tb_DeTai.Size = new System.Drawing.Size(166, 20);
            this.tb_DeTai.TabIndex = 3;
            // 
            // ds_KetNoi
            // 
            this.ds_KetNoi.FormattingEnabled = true;
            this.ds_KetNoi.Items.AddRange(new object[] {
            "BasicHttpBinding",
            "WSHttpBinding",
            "NetTcpBinding"});
            this.ds_KetNoi.Location = new System.Drawing.Point(80, 6);
            this.ds_KetNoi.Name = "ds_KetNoi";
            this.ds_KetNoi.Size = new System.Drawing.Size(110, 21);
            this.ds_KetNoi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kiểu kết nối";
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(197, 6);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(49, 23);
            this.bt_Start.TabIndex = 6;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // Tuan4_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 126);
            this.Controls.Add(this.bt_Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ds_KetNoi);
            this.Controls.Add(this.tb_DeTai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lv_ThanhVien);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tuan4_Client";
            this.Text = "Tuan4_Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_ThanhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_DeTai;
        private System.Windows.Forms.ComboBox ds_KetNoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Start;


    }
}

