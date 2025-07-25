namespace LMT_KT2_Lab
{
    partial class F_PhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_PhanQuyen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgv_QuanLy = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.txt_TimKiemQL = new System.Windows.Forms.TextBox();
            this.txt_TimKiemNV = new System.Windows.Forms.TextBox();
            this.btn_TimKiemQL = new System.Windows.Forms.Button();
            this.btn_TimKiemNV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuanLy)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TimKiemQL);
            this.groupBox1.Controls.Add(this.txt_TimKiemQL);
            this.groupBox1.Controls.Add(this.dgv_QuanLy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1177, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân Viên Quản Lý";
            // 
            // dgv_QuanLy
            // 
            this.dgv_QuanLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QuanLy.Location = new System.Drawing.Point(28, 68);
            this.dgv_QuanLy.Name = "dgv_QuanLy";
            this.dgv_QuanLy.RowHeadersWidth = 51;
            this.dgv_QuanLy.RowTemplate.Height = 24;
            this.dgv_QuanLy.Size = new System.Drawing.Size(1115, 208);
            this.dgv_QuanLy.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_TimKiemNV);
            this.groupBox2.Controls.Add(this.txt_TimKiemNV);
            this.groupBox2.Controls.Add(this.dgv_NhanVien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1177, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhân Viên Bán Hàng";
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(28, 73);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(1115, 186);
            this.dgv_NhanVien.TabIndex = 0;
            // 
            // txt_TimKiemQL
            // 
            this.txt_TimKiemQL.Location = new System.Drawing.Point(882, 23);
            this.txt_TimKiemQL.Name = "txt_TimKiemQL";
            this.txt_TimKiemQL.Size = new System.Drawing.Size(179, 38);
            this.txt_TimKiemQL.TabIndex = 1;
            this.txt_TimKiemQL.TextChanged += new System.EventHandler(this.txt_TimKiemQL_TextChanged);
            // 
            // txt_TimKiemNV
            // 
            this.txt_TimKiemNV.Location = new System.Drawing.Point(882, 20);
            this.txt_TimKiemNV.Name = "txt_TimKiemNV";
            this.txt_TimKiemNV.Size = new System.Drawing.Size(179, 38);
            this.txt_TimKiemNV.TabIndex = 2;
            // 
            // btn_TimKiemQL
            // 
            this.btn_TimKiemQL.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiemQL.Image")));
            this.btn_TimKiemQL.Location = new System.Drawing.Point(1095, 23);
            this.btn_TimKiemQL.Name = "btn_TimKiemQL";
            this.btn_TimKiemQL.Size = new System.Drawing.Size(48, 39);
            this.btn_TimKiemQL.TabIndex = 2;
            this.btn_TimKiemQL.UseVisualStyleBackColor = true;
            // 
            // btn_TimKiemNV
            // 
            this.btn_TimKiemNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiemNV.Image")));
            this.btn_TimKiemNV.Location = new System.Drawing.Point(1095, 20);
            this.btn_TimKiemNV.Name = "btn_TimKiemNV";
            this.btn_TimKiemNV.Size = new System.Drawing.Size(48, 39);
            this.btn_TimKiemNV.TabIndex = 3;
            this.btn_TimKiemNV.UseVisualStyleBackColor = true;
            this.btn_TimKiemNV.Click += new System.EventHandler(this.btn_TimKiemNV_Click);
            // 
            // F_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 682);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_PhanQuyen";
            this.Text = "F_PhanQuyen";
            this.Load += new System.EventHandler(this.F_PhanQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuanLy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgv_QuanLy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Button btn_TimKiemQL;
        private System.Windows.Forms.TextBox txt_TimKiemQL;
        private System.Windows.Forms.TextBox txt_TimKiemNV;
        private System.Windows.Forms.Button btn_TimKiemNV;
    }
}