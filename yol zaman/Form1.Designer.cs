
namespace yol_zaman
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hesapla_btn = new System.Windows.Forms.Button();
            this.zaman_txt = new System.Windows.Forms.TextBox();
            this.hız_txt = new System.Windows.Forms.TextBox();
            this.cvp_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yol_cmb = new System.Windows.Forms.ComboBox();
            this.hesapla2_btn = new System.Windows.Forms.Button();
            this.zaman2_txt = new System.Windows.Forms.TextBox();
            this.hız2_txt = new System.Windows.Forms.TextBox();
            this.cvp2_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hesapla_btn);
            this.groupBox1.Controls.Add(this.zaman_txt);
            this.groupBox1.Controls.Add(this.hız_txt);
            this.groupBox1.Controls.Add(this.cvp_lbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saat cinsinden zaman değeri girildiğinde yolu hesapla";
            // 
            // hesapla_btn
            // 
            this.hesapla_btn.Location = new System.Drawing.Point(64, 198);
            this.hesapla_btn.Name = "hesapla_btn";
            this.hesapla_btn.Size = new System.Drawing.Size(175, 47);
            this.hesapla_btn.TabIndex = 6;
            this.hesapla_btn.Text = "hesapla";
            this.hesapla_btn.UseVisualStyleBackColor = true;
            this.hesapla_btn.Click += new System.EventHandler(this.hesapla_btn_Click);
            // 
            // zaman_txt
            // 
            this.zaman_txt.Location = new System.Drawing.Point(109, 103);
            this.zaman_txt.Name = "zaman_txt";
            this.zaman_txt.Size = new System.Drawing.Size(100, 20);
            this.zaman_txt.TabIndex = 5;
            // 
            // hız_txt
            // 
            this.hız_txt.Location = new System.Drawing.Point(109, 40);
            this.hız_txt.Name = "hız_txt";
            this.hız_txt.Size = new System.Drawing.Size(100, 20);
            this.hız_txt.TabIndex = 4;
            // 
            // cvp_lbl
            // 
            this.cvp_lbl.AutoSize = true;
            this.cvp_lbl.Location = new System.Drawing.Point(115, 278);
            this.cvp_lbl.Name = "cvp_lbl";
            this.cvp_lbl.Size = new System.Drawing.Size(82, 13);
            this.cvp_lbl.TabIndex = 3;
            this.cvp_lbl.Text = ". . . . . . . . . . . . .";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zaman";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hız";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yol_cmb);
            this.groupBox2.Controls.Add(this.hesapla2_btn);
            this.groupBox2.Controls.Add(this.zaman2_txt);
            this.groupBox2.Controls.Add(this.hız2_txt);
            this.groupBox2.Controls.Add(this.cvp2_lbl);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(390, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 426);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saat,dakika yada saniye cinsinedn değer veridiğide yol bilgisini hesapla";
            // 
            // yol_cmb
            // 
            this.yol_cmb.FormattingEnabled = true;
            this.yol_cmb.Items.AddRange(new object[] {
            "cm",
            "m",
            "km"});
            this.yol_cmb.Location = new System.Drawing.Point(260, 212);
            this.yol_cmb.Name = "yol_cmb";
            this.yol_cmb.Size = new System.Drawing.Size(38, 21);
            this.yol_cmb.TabIndex = 13;
            // 
            // hesapla2_btn
            // 
            this.hesapla2_btn.Location = new System.Drawing.Point(57, 198);
            this.hesapla2_btn.Name = "hesapla2_btn";
            this.hesapla2_btn.Size = new System.Drawing.Size(184, 47);
            this.hesapla2_btn.TabIndex = 12;
            this.hesapla2_btn.Text = "hesapla";
            this.hesapla2_btn.UseVisualStyleBackColor = true;
            this.hesapla2_btn.Click += new System.EventHandler(this.hesapla2_btn_Click);
            // 
            // zaman2_txt
            // 
            this.zaman2_txt.Location = new System.Drawing.Point(141, 106);
            this.zaman2_txt.Name = "zaman2_txt";
            this.zaman2_txt.Size = new System.Drawing.Size(100, 20);
            this.zaman2_txt.TabIndex = 11;
            // 
            // hız2_txt
            // 
            this.hız2_txt.Location = new System.Drawing.Point(141, 43);
            this.hız2_txt.Name = "hız2_txt";
            this.hız2_txt.Size = new System.Drawing.Size(100, 20);
            this.hız2_txt.TabIndex = 10;
            // 
            // cvp2_lbl
            // 
            this.cvp2_lbl.AutoSize = true;
            this.cvp2_lbl.Location = new System.Drawing.Point(147, 281);
            this.cvp2_lbl.Name = "cvp2_lbl";
            this.cvp2_lbl.Size = new System.Drawing.Size(82, 13);
            this.cvp2_lbl.TabIndex = 9;
            this.cvp2_lbl.Text = ". . . . . . . . . . . . .";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Yol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Zaman";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Hız";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button hesapla_btn;
        private System.Windows.Forms.TextBox zaman_txt;
        private System.Windows.Forms.TextBox hız_txt;
        private System.Windows.Forms.Label cvp_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox yol_cmb;
        private System.Windows.Forms.Button hesapla2_btn;
        private System.Windows.Forms.TextBox zaman2_txt;
        private System.Windows.Forms.TextBox hız2_txt;
        private System.Windows.Forms.Label cvp2_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

