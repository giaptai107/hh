namespace ThiKTHP
{
    partial class ThemLop
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
            this.tbLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKhoa = new System.Windows.Forms.TextBox();
            this.tbKhoi = new System.Windows.Forms.TextBox();
            this.tbSiSo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOKLOP = new System.Windows.Forms.Button();
            this.btnCANCELLop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLop
            // 
            this.tbLop.Location = new System.Drawing.Point(129, 31);
            this.tbLop.Name = "tbLop";
            this.tbLop.Size = new System.Drawing.Size(100, 20);
            this.tbLop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng học:";
            // 
            // tbPhong
            // 
            this.tbPhong.Location = new System.Drawing.Point(129, 69);
            this.tbPhong.Name = "tbPhong";
            this.tbPhong.Size = new System.Drawing.Size(100, 20);
            this.tbPhong.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sĩ số:";
            // 
            // tbKhoa
            // 
            this.tbKhoa.Location = new System.Drawing.Point(129, 178);
            this.tbKhoa.Name = "tbKhoa";
            this.tbKhoa.Size = new System.Drawing.Size(100, 20);
            this.tbKhoa.TabIndex = 0;
            // 
            // tbKhoi
            // 
            this.tbKhoi.Location = new System.Drawing.Point(129, 148);
            this.tbKhoi.Name = "tbKhoi";
            this.tbKhoi.Size = new System.Drawing.Size(100, 20);
            this.tbKhoi.TabIndex = 0;
            // 
            // tbSiSo
            // 
            this.tbSiSo.Location = new System.Drawing.Point(129, 109);
            this.tbSiSo.Name = "tbSiSo";
            this.tbSiSo.Size = new System.Drawing.Size(100, 20);
            this.tbSiSo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Khối:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Khóa:";
            // 
            // btnOKLOP
            // 
            this.btnOKLOP.Location = new System.Drawing.Point(234, 217);
            this.btnOKLOP.Name = "btnOKLOP";
            this.btnOKLOP.Size = new System.Drawing.Size(75, 23);
            this.btnOKLOP.TabIndex = 2;
            this.btnOKLOP.Text = "OK";
            this.btnOKLOP.UseVisualStyleBackColor = true;
            this.btnOKLOP.Click += new System.EventHandler(this.BtnOKLOP_Click);
            // 
            // btnCANCELLop
            // 
            this.btnCANCELLop.Location = new System.Drawing.Point(333, 217);
            this.btnCANCELLop.Name = "btnCANCELLop";
            this.btnCANCELLop.Size = new System.Drawing.Size(75, 23);
            this.btnCANCELLop.TabIndex = 3;
            this.btnCANCELLop.Text = "Hủy";
            this.btnCANCELLop.UseVisualStyleBackColor = true;
            // 
            // ThemLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 252);
            this.Controls.Add(this.btnCANCELLop);
            this.Controls.Add(this.btnOKLOP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSiSo);
            this.Controls.Add(this.tbKhoi);
            this.Controls.Add(this.tbKhoa);
            this.Controls.Add(this.tbPhong);
            this.Controls.Add(this.tbLop);
            this.Name = "ThemLop";
            this.Text = "ThemLop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKhoa;
        private System.Windows.Forms.TextBox tbKhoi;
        private System.Windows.Forms.TextBox tbSiSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOKLOP;
        private System.Windows.Forms.Button btnCANCELLop;
    }
}