namespace Nesne_Programlama_Lab_Proje
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
            this.btngiris = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbisim = new System.Windows.Forms.Label();
            this.lbsifre = new System.Windows.Forms.Label();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblgamename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngiris
            // 
            this.btngiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngiris.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.Location = new System.Drawing.Point(208, 297);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(67, 29);
            this.btngiris.TabIndex = 0;
            this.btngiris.Text = "Log In";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(236, 195);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(236, 246);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // lbisim
            // 
            this.lbisim.AutoSize = true;
            this.lbisim.BackColor = System.Drawing.Color.Red;
            this.lbisim.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbisim.ForeColor = System.Drawing.Color.White;
            this.lbisim.Location = new System.Drawing.Point(120, 190);
            this.lbisim.Name = "lbisim";
            this.lbisim.Size = new System.Drawing.Size(95, 25);
            this.lbisim.TabIndex = 3;
            this.lbisim.Text = "Username";
            // 
            // lbsifre
            // 
            this.lbsifre.AutoSize = true;
            this.lbsifre.BackColor = System.Drawing.Color.Red;
            this.lbsifre.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsifre.ForeColor = System.Drawing.Color.White;
            this.lbsifre.Location = new System.Drawing.Point(123, 241);
            this.lbsifre.Name = "lbsifre";
            this.lbsifre.Size = new System.Drawing.Size(92, 25);
            this.lbsifre.TabIndex = 4;
            this.lbsifre.Text = "Password";
            // 
            // btncıkıs
            // 
            this.btncıkıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncıkıs.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncıkıs.Location = new System.Drawing.Point(278, 297);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(67, 29);
            this.btncıkıs.TabIndex = 5;
            this.btncıkıs.Text = "Exit";
            this.btncıkıs.UseVisualStyleBackColor = true;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblgamename
            // 
            this.lblgamename.AutoSize = true;
            this.lblgamename.BackColor = System.Drawing.Color.White;
            this.lblgamename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgamename.Location = new System.Drawing.Point(205, 91);
            this.lblgamename.Name = "lblgamename";
            this.lblgamename.Size = new System.Drawing.Size(150, 25);
            this.lblgamename.TabIndex = 7;
            this.lblgamename.Text = "GAME NAME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 523);
            this.Controls.Add(this.lblgamename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.lbsifre);
            this.Controls.Add(this.lbisim);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btngiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbisim;
        private System.Windows.Forms.Label lbsifre;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblgamename;
    }
}

