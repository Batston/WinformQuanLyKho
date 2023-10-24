
namespace WinformQuanLyKho
{
    partial class FrmPHIEUNHAP
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
            this.dtgvPHIEUNHAP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsophieu = new System.Windows.Forms.TextBox();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.txtngaynhap = new System.Windows.Forms.DateTimePicker();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btbthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPHIEUNHAP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPHIEUNHAP
            // 
            this.dtgvPHIEUNHAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPHIEUNHAP.Location = new System.Drawing.Point(12, 12);
            this.dtgvPHIEUNHAP.Name = "dtgvPHIEUNHAP";
            this.dtgvPHIEUNHAP.RowHeadersWidth = 51;
            this.dtgvPHIEUNHAP.RowTemplate.Height = 24;
            this.dtgvPHIEUNHAP.Size = new System.Drawing.Size(531, 557);
            this.dtgvPHIEUNHAP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(619, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã NCC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 4;
            // 
            // txtsophieu
            // 
            this.txtsophieu.Location = new System.Drawing.Point(768, 36);
            this.txtsophieu.Name = "txtsophieu";
            this.txtsophieu.Size = new System.Drawing.Size(309, 22);
            this.txtsophieu.TabIndex = 5;
            // 
            // txtmancc
            // 
            this.txtmancc.Location = new System.Drawing.Point(768, 143);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(309, 22);
            this.txtmancc.TabIndex = 6;
            // 
            // txtngaynhap
            // 
            this.txtngaynhap.Location = new System.Drawing.Point(768, 86);
            this.txtngaynhap.Name = "txtngaynhap";
            this.txtngaynhap.Size = new System.Drawing.Size(309, 22);
            this.txtngaynhap.TabIndex = 7;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(608, 252);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(1025, 252);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(608, 363);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btbthoat
            // 
            this.btbthoat.Location = new System.Drawing.Point(1025, 376);
            this.btbthoat.Name = "btbthoat";
            this.btbthoat.Size = new System.Drawing.Size(75, 23);
            this.btbthoat.TabIndex = 11;
            this.btbthoat.Text = "Thoát";
            this.btbthoat.UseVisualStyleBackColor = true;
            // 
            // FrmPHIEUNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 581);
            this.Controls.Add(this.btbthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtngaynhap);
            this.Controls.Add(this.txtmancc);
            this.Controls.Add(this.txtsophieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvPHIEUNHAP);
            this.Name = "FrmPHIEUNHAP";
            this.Text = "FrmPHIEUNHAP";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPHIEUNHAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPHIEUNHAP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsophieu;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.DateTimePicker txtngaynhap;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btbthoat;
    }
}