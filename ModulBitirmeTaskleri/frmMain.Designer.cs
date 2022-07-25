namespace Bankamatik
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.pnlParaCek = new System.Windows.Forms.Panel();
            this.txtParaCek = new System.Windows.Forms.TextBox();
            this.lblParaCek = new System.Windows.Forms.Label();
            this.pnlParaYatir = new System.Windows.Forms.Panel();
            this.txtParaYatir = new System.Windows.Forms.TextBox();
            this.lblParaYatir = new System.Windows.Forms.Label();
            this.pnlParaAktar = new System.Windows.Forms.Panel();
            this.txtParaAktar = new System.Windows.Forms.TextBox();
            this.lblParaAktar = new System.Windows.Forms.Label();
            this.pnlHesapOzeti = new System.Windows.Forms.Panel();
            this.lblParaOzeti = new System.Windows.Forms.Label();
            this.pnlCikis = new System.Windows.Forms.Panel();
            this.lblCikis = new System.Windows.Forms.Label();
            this.pnlParaCek.SuspendLayout();
            this.pnlParaYatir.SuspendLayout();
            this.pnlParaAktar.SuspendLayout();
            this.pnlHesapOzeti.SuspendLayout();
            this.pnlCikis.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(1149, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.lblWelcome.Location = new System.Drawing.Point(397, 73);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(260, 54);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Hoşgeldiniz!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.BackColor = System.Drawing.Color.Transparent;
            this.lblBakiye.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBakiye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.lblBakiye.Location = new System.Drawing.Point(410, 154);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(218, 54);
            this.lblBakiye.TabIndex = 4;
            this.lblBakiye.Text = "Bakiyeniz:";
            this.lblBakiye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlParaCek
            // 
            this.pnlParaCek.BackColor = System.Drawing.Color.Transparent;
            this.pnlParaCek.BackgroundImage = global::Bankamatik.Properties.Resources.mavi;
            this.pnlParaCek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlParaCek.Controls.Add(this.txtParaCek);
            this.pnlParaCek.Controls.Add(this.lblParaCek);
            this.pnlParaCek.Location = new System.Drawing.Point(23, 284);
            this.pnlParaCek.Name = "pnlParaCek";
            this.pnlParaCek.Size = new System.Drawing.Size(400, 100);
            this.pnlParaCek.TabIndex = 5;
            this.pnlParaCek.Click += new System.EventHandler(this.pnlParaCek_Click);
            // 
            // txtParaCek
            // 
            this.txtParaCek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParaCek.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtParaCek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(126)))));
            this.txtParaCek.Location = new System.Drawing.Point(240, 23);
            this.txtParaCek.Name = "txtParaCek";
            this.txtParaCek.Size = new System.Drawing.Size(125, 54);
            this.txtParaCek.TabIndex = 5;
            this.txtParaCek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtParaCek.Enter += new System.EventHandler(this.txtParaCek_Enter);
            this.txtParaCek.Leave += new System.EventHandler(this.txtParaCek_Leave);
            // 
            // lblParaCek
            // 
            this.lblParaCek.AutoSize = true;
            this.lblParaCek.BackColor = System.Drawing.Color.Transparent;
            this.lblParaCek.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblParaCek.ForeColor = System.Drawing.Color.White;
            this.lblParaCek.Location = new System.Drawing.Point(20, 23);
            this.lblParaCek.Name = "lblParaCek";
            this.lblParaCek.Size = new System.Drawing.Size(191, 54);
            this.lblParaCek.TabIndex = 4;
            this.lblParaCek.Text = "Para Çek";
            this.lblParaCek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblParaCek.Click += new System.EventHandler(this.lblParaCek_Click);
            // 
            // pnlParaYatir
            // 
            this.pnlParaYatir.BackColor = System.Drawing.Color.Transparent;
            this.pnlParaYatir.BackgroundImage = global::Bankamatik.Properties.Resources.mavi;
            this.pnlParaYatir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlParaYatir.Controls.Add(this.txtParaYatir);
            this.pnlParaYatir.Controls.Add(this.lblParaYatir);
            this.pnlParaYatir.Location = new System.Drawing.Point(788, 284);
            this.pnlParaYatir.Name = "pnlParaYatir";
            this.pnlParaYatir.Size = new System.Drawing.Size(400, 100);
            this.pnlParaYatir.TabIndex = 5;
            this.pnlParaYatir.Click += new System.EventHandler(this.pnlParaYatir_Click);
            // 
            // txtParaYatir
            // 
            this.txtParaYatir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParaYatir.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtParaYatir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(126)))));
            this.txtParaYatir.Location = new System.Drawing.Point(42, 23);
            this.txtParaYatir.Name = "txtParaYatir";
            this.txtParaYatir.Size = new System.Drawing.Size(125, 54);
            this.txtParaYatir.TabIndex = 5;
            this.txtParaYatir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtParaYatir.Enter += new System.EventHandler(this.txtParaYatir_Enter);
            this.txtParaYatir.Leave += new System.EventHandler(this.txtParaYatir_Leave);
            // 
            // lblParaYatir
            // 
            this.lblParaYatir.AutoSize = true;
            this.lblParaYatir.BackColor = System.Drawing.Color.Transparent;
            this.lblParaYatir.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblParaYatir.ForeColor = System.Drawing.Color.White;
            this.lblParaYatir.Location = new System.Drawing.Point(173, 23);
            this.lblParaYatir.Name = "lblParaYatir";
            this.lblParaYatir.Size = new System.Drawing.Size(215, 54);
            this.lblParaYatir.TabIndex = 4;
            this.lblParaYatir.Text = "Para Yatır";
            this.lblParaYatir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblParaYatir.Click += new System.EventHandler(this.lblParaYatir_Click);
            // 
            // pnlParaAktar
            // 
            this.pnlParaAktar.BackColor = System.Drawing.Color.Transparent;
            this.pnlParaAktar.BackgroundImage = global::Bankamatik.Properties.Resources.mavi;
            this.pnlParaAktar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlParaAktar.Controls.Add(this.txtParaAktar);
            this.pnlParaAktar.Controls.Add(this.lblParaAktar);
            this.pnlParaAktar.Location = new System.Drawing.Point(23, 426);
            this.pnlParaAktar.Name = "pnlParaAktar";
            this.pnlParaAktar.Size = new System.Drawing.Size(400, 100);
            this.pnlParaAktar.TabIndex = 5;
            // 
            // txtParaAktar
            // 
            this.txtParaAktar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParaAktar.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtParaAktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(126)))));
            this.txtParaAktar.Location = new System.Drawing.Point(240, 23);
            this.txtParaAktar.Name = "txtParaAktar";
            this.txtParaAktar.Size = new System.Drawing.Size(125, 54);
            this.txtParaAktar.TabIndex = 5;
            this.txtParaAktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtParaAktar.Enter += new System.EventHandler(this.txtParaAktar_Enter);
            this.txtParaAktar.Leave += new System.EventHandler(this.txtParaAktar_Leave);
            // 
            // lblParaAktar
            // 
            this.lblParaAktar.AutoSize = true;
            this.lblParaAktar.BackColor = System.Drawing.Color.Transparent;
            this.lblParaAktar.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblParaAktar.ForeColor = System.Drawing.Color.White;
            this.lblParaAktar.Location = new System.Drawing.Point(18, 23);
            this.lblParaAktar.Name = "lblParaAktar";
            this.lblParaAktar.Size = new System.Drawing.Size(228, 54);
            this.lblParaAktar.TabIndex = 4;
            this.lblParaAktar.Text = "Para Aktar";
            this.lblParaAktar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHesapOzeti
            // 
            this.pnlHesapOzeti.BackColor = System.Drawing.Color.Transparent;
            this.pnlHesapOzeti.BackgroundImage = global::Bankamatik.Properties.Resources.mavi;
            this.pnlHesapOzeti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlHesapOzeti.Controls.Add(this.lblParaOzeti);
            this.pnlHesapOzeti.Location = new System.Drawing.Point(791, 426);
            this.pnlHesapOzeti.Name = "pnlHesapOzeti";
            this.pnlHesapOzeti.Size = new System.Drawing.Size(400, 100);
            this.pnlHesapOzeti.TabIndex = 5;
            // 
            // lblParaOzeti
            // 
            this.lblParaOzeti.AutoSize = true;
            this.lblParaOzeti.BackColor = System.Drawing.Color.Transparent;
            this.lblParaOzeti.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblParaOzeti.ForeColor = System.Drawing.Color.White;
            this.lblParaOzeti.Location = new System.Drawing.Point(135, 23);
            this.lblParaOzeti.Name = "lblParaOzeti";
            this.lblParaOzeti.Size = new System.Drawing.Size(250, 54);
            this.lblParaOzeti.TabIndex = 4;
            this.lblParaOzeti.Text = "Hesap Özeti";
            this.lblParaOzeti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCikis
            // 
            this.pnlCikis.BackColor = System.Drawing.Color.Transparent;
            this.pnlCikis.BackgroundImage = global::Bankamatik.Properties.Resources.mavi;
            this.pnlCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlCikis.Controls.Add(this.lblCikis);
            this.pnlCikis.Location = new System.Drawing.Point(791, 568);
            this.pnlCikis.Name = "pnlCikis";
            this.pnlCikis.Size = new System.Drawing.Size(400, 100);
            this.pnlCikis.TabIndex = 5;
            this.pnlCikis.Click += new System.EventHandler(this.pnlCikis_Click);
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.BackColor = System.Drawing.Color.Transparent;
            this.lblCikis.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCikis.ForeColor = System.Drawing.Color.White;
            this.lblCikis.Location = new System.Drawing.Point(188, 26);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(197, 54);
            this.lblCikis.TabIndex = 4;
            this.lblCikis.Text = "Çıkış Yap";
            this.lblCikis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCikis.Click += new System.EventHandler(this.lblCikis_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlParaYatir);
            this.Controls.Add(this.pnlCikis);
            this.Controls.Add(this.pnlHesapOzeti);
            this.Controls.Add(this.pnlParaAktar);
            this.Controls.Add(this.pnlParaCek);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Click += new System.EventHandler(this.frmMain_Click);
            this.pnlParaCek.ResumeLayout(false);
            this.pnlParaCek.PerformLayout();
            this.pnlParaYatir.ResumeLayout(false);
            this.pnlParaYatir.PerformLayout();
            this.pnlParaAktar.ResumeLayout(false);
            this.pnlParaAktar.PerformLayout();
            this.pnlHesapOzeti.ResumeLayout(false);
            this.pnlHesapOzeti.PerformLayout();
            this.pnlCikis.ResumeLayout(false);
            this.pnlCikis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private Label lblWelcome;
        private Label lblBakiye;
        private Panel pnlParaCek;
        private TextBox txtParaCek;
        private Label lblParaCek;
        private Panel pnlParaYatir;
        private TextBox txtParaYatir;
        private Label lblParaYatir;
        private Panel pnlParaAktar;
        private TextBox txtParaAktar;
        private Label lblParaAktar;
        private Panel pnlHesapOzeti;
        private Label lblParaOzeti;
        private Panel pnlCikis;
        private Label lblCikis;
    }
}