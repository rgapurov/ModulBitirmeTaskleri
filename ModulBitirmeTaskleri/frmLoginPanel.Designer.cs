namespace Bankamatik
{
    partial class frmLoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginPanel));
            this.txtTC = new UnderLineTextBox.RGTextBox();
            this.lblTcno = new System.Windows.Forms.Label();
            this.txtPassword = new UnderLineTextBox.RGTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnEnter = new FontAwesome.Sharp.IconButton();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBakiyeEkle = new System.Windows.Forms.Label();
            this.lblSifreEkle = new System.Windows.Forms.Label();
            this.lblIsimEkle = new System.Windows.Forms.Label();
            this.lblTcEkle = new System.Windows.Forms.Label();
            this.txtEkleBakiye = new UnderLineTextBox.RGTextBox();
            this.txtEkleSifre = new UnderLineTextBox.RGTextBox();
            this.txtEkleIsim = new UnderLineTextBox.RGTextBox();
            this.txtEkleTc = new UnderLineTextBox.RGTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.SystemColors.Window;
            this.txtTC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.txtTC.BorderSize = 3;
            this.txtTC.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(165)))));
            this.txtTC.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTC.ForeColor = System.Drawing.Color.DimGray;
            this.txtTC.IsFocused = false;
            this.txtTC.Location = new System.Drawing.Point(269, 136);
            this.txtTC.multiLine = false;
            this.txtTC.Name = "txtTC";
            this.txtTC.Padding = new System.Windows.Forms.Padding(7);
            this.txtTC.passwordChar = false;
            this.txtTC.Size = new System.Drawing.Size(312, 53);
            this.txtTC.TabIndex = 0;
            this.txtTC.Texts = "";
            this.txtTC.UnderLine = false;
            this.txtTC.Enter += new System.EventHandler(this.txtTC_Enter);
            this.txtTC.Leave += new System.EventHandler(this.txtTC_Leave);
            // 
            // lblTcno
            // 
            this.lblTcno.AutoSize = true;
            this.lblTcno.BackColor = System.Drawing.Color.Transparent;
            this.lblTcno.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTcno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.lblTcno.Location = new System.Drawing.Point(262, 95);
            this.lblTcno.Name = "lblTcno";
            this.lblTcno.Size = new System.Drawing.Size(118, 38);
            this.lblTcno.TabIndex = 1;
            this.lblTcno.Text = "T.C. No:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.txtPassword.BorderSize = 3;
            this.txtPassword.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(165)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.IsFocused = false;
            this.txtPassword.Location = new System.Drawing.Point(269, 246);
            this.txtPassword.multiLine = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.passwordChar = false;
            this.txtPassword.Size = new System.Drawing.Size(312, 53);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderLine = false;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.lblPassword.Location = new System.Drawing.Point(262, 205);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 38);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Şifre:";
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
            this.btnClose.Location = new System.Drawing.Point(788, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 42);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(191)))));
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.btnEnter.FlatAppearance.BorderSize = 3;
            this.btnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(191)))));
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(191)))));
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.btnEnter.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnEnter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.btnEnter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnter.IconSize = 56;
            this.btnEnter.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnEnter.Location = new System.Drawing.Point(337, 354);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(0);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(177, 64);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "GİRİŞ";
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.lblSignUp.Location = new System.Drawing.Point(479, 302);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(102, 32);
            this.lblSignUp.TabIndex = 1;
            this.lblSignUp.Text = "Kayıt Ol";
            this.lblSignUp.MouseLeave += new System.EventHandler(this.lblSignUp_MouseLeave);
            this.lblSignUp.MouseHover += new System.EventHandler(this.lblSignUp_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBakiyeEkle);
            this.panel1.Controls.Add(this.lblSifreEkle);
            this.panel1.Controls.Add(this.lblIsimEkle);
            this.panel1.Controls.Add(this.lblTcEkle);
            this.panel1.Controls.Add(this.txtEkleBakiye);
            this.panel1.Controls.Add(this.txtEkleSifre);
            this.panel1.Controls.Add(this.txtEkleIsim);
            this.panel1.Controls.Add(this.txtEkleTc);
            this.panel1.Location = new System.Drawing.Point(68, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 500);
            this.panel1.TabIndex = 3;
            // 
            // lblBakiyeEkle
            // 
            this.lblBakiyeEkle.AutoSize = true;
            this.lblBakiyeEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblBakiyeEkle.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBakiyeEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.lblBakiyeEkle.Location = new System.Drawing.Point(109, 269);
            this.lblBakiyeEkle.Name = "lblBakiyeEkle";
            this.lblBakiyeEkle.Size = new System.Drawing.Size(115, 38);
            this.lblBakiyeEkle.TabIndex = 1;
            this.lblBakiyeEkle.Text = "Bakiye:";
            // 
            // lblSifreEkle
            // 
            this.lblSifreEkle.AutoSize = true;
            this.lblSifreEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblSifreEkle.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSifreEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.lblSifreEkle.Location = new System.Drawing.Point(109, 200);
            this.lblSifreEkle.Name = "lblSifreEkle";
            this.lblSifreEkle.Size = new System.Drawing.Size(86, 38);
            this.lblSifreEkle.TabIndex = 1;
            this.lblSifreEkle.Text = "Şifre:";
            // 
            // lblIsimEkle
            // 
            this.lblIsimEkle.AutoSize = true;
            this.lblIsimEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblIsimEkle.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblIsimEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.lblIsimEkle.Location = new System.Drawing.Point(81, 124);
            this.lblIsimEkle.Name = "lblIsimEkle";
            this.lblIsimEkle.Size = new System.Drawing.Size(150, 38);
            this.lblIsimEkle.TabIndex = 1;
            this.lblIsimEkle.Text = "Ad Soyad:";
            // 
            // lblTcEkle
            // 
            this.lblTcEkle.AutoSize = true;
            this.lblTcEkle.BackColor = System.Drawing.Color.Transparent;
            this.lblTcEkle.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTcEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.lblTcEkle.Location = new System.Drawing.Point(109, 65);
            this.lblTcEkle.Name = "lblTcEkle";
            this.lblTcEkle.Size = new System.Drawing.Size(121, 38);
            this.lblTcEkle.TabIndex = 1;
            this.lblTcEkle.Text = "T.C. No:";
            // 
            // txtEkleBakiye
            // 
            this.txtEkleBakiye.BackColor = System.Drawing.SystemColors.Window;
            this.txtEkleBakiye.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.txtEkleBakiye.BorderSize = 3;
            this.txtEkleBakiye.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(165)))));
            this.txtEkleBakiye.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEkleBakiye.ForeColor = System.Drawing.Color.DimGray;
            this.txtEkleBakiye.IsFocused = false;
            this.txtEkleBakiye.Location = new System.Drawing.Point(240, 267);
            this.txtEkleBakiye.multiLine = false;
            this.txtEkleBakiye.Name = "txtEkleBakiye";
            this.txtEkleBakiye.Padding = new System.Windows.Forms.Padding(7);
            this.txtEkleBakiye.passwordChar = false;
            this.txtEkleBakiye.Size = new System.Drawing.Size(312, 46);
            this.txtEkleBakiye.TabIndex = 0;
            this.txtEkleBakiye.Texts = "";
            this.txtEkleBakiye.UnderLine = false;
            this.txtEkleBakiye.Enter += new System.EventHandler(this.lblEkleBakiye_Enter);
            this.txtEkleBakiye.Leave += new System.EventHandler(this.lblEkleBakiye_Leave);
            // 
            // txtEkleSifre
            // 
            this.txtEkleSifre.BackColor = System.Drawing.SystemColors.Window;
            this.txtEkleSifre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.txtEkleSifre.BorderSize = 3;
            this.txtEkleSifre.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(165)))));
            this.txtEkleSifre.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEkleSifre.ForeColor = System.Drawing.Color.DimGray;
            this.txtEkleSifre.IsFocused = false;
            this.txtEkleSifre.Location = new System.Drawing.Point(240, 198);
            this.txtEkleSifre.multiLine = false;
            this.txtEkleSifre.Name = "txtEkleSifre";
            this.txtEkleSifre.Padding = new System.Windows.Forms.Padding(7);
            this.txtEkleSifre.passwordChar = false;
            this.txtEkleSifre.Size = new System.Drawing.Size(312, 46);
            this.txtEkleSifre.TabIndex = 0;
            this.txtEkleSifre.Texts = "";
            this.txtEkleSifre.UnderLine = false;
            this.txtEkleSifre.Enter += new System.EventHandler(this.txtEkleSifre_Enter);
            this.txtEkleSifre.Leave += new System.EventHandler(this.txtEkleSifre_Leave);
            // 
            // txtEkleIsim
            // 
            this.txtEkleIsim.BackColor = System.Drawing.SystemColors.Window;
            this.txtEkleIsim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.txtEkleIsim.BorderSize = 3;
            this.txtEkleIsim.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(165)))));
            this.txtEkleIsim.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEkleIsim.ForeColor = System.Drawing.Color.DimGray;
            this.txtEkleIsim.IsFocused = false;
            this.txtEkleIsim.Location = new System.Drawing.Point(240, 122);
            this.txtEkleIsim.multiLine = false;
            this.txtEkleIsim.Name = "txtEkleIsim";
            this.txtEkleIsim.Padding = new System.Windows.Forms.Padding(7);
            this.txtEkleIsim.passwordChar = false;
            this.txtEkleIsim.Size = new System.Drawing.Size(312, 46);
            this.txtEkleIsim.TabIndex = 0;
            this.txtEkleIsim.Texts = "";
            this.txtEkleIsim.UnderLine = false;
            this.txtEkleIsim.Enter += new System.EventHandler(this.rgTextBox2_Enter);
            this.txtEkleIsim.Leave += new System.EventHandler(this.txtEkleIsim_Leave);
            // 
            // txtEkleTc
            // 
            this.txtEkleTc.BackColor = System.Drawing.SystemColors.Window;
            this.txtEkleTc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.txtEkleTc.BorderSize = 3;
            this.txtEkleTc.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(118)))), ((int)(((byte)(165)))));
            this.txtEkleTc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEkleTc.ForeColor = System.Drawing.Color.DimGray;
            this.txtEkleTc.IsFocused = false;
            this.txtEkleTc.Location = new System.Drawing.Point(240, 63);
            this.txtEkleTc.multiLine = false;
            this.txtEkleTc.Name = "txtEkleTc";
            this.txtEkleTc.Padding = new System.Windows.Forms.Padding(7);
            this.txtEkleTc.passwordChar = false;
            this.txtEkleTc.Size = new System.Drawing.Size(312, 46);
            this.txtEkleTc.TabIndex = 0;
            this.txtEkleTc.Texts = "";
            this.txtEkleTc.UnderLine = false;
            this.txtEkleTc.Enter += new System.EventHandler(this.txtEkleTc_Enter);
            this.txtEkleTc.Leave += new System.EventHandler(this.txtEkleTc_Leave);
            // 
            // frmLoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblTcno);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginPanel";
            this.Load += new System.EventHandler(this.frmLoginPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UnderLineTextBox.RGTextBox txtTC;
        private Label lblTcno;
        private UnderLineTextBox.RGTextBox txtPassword;
        private Label lblPassword;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnEnter;
        private Label lblSignUp;
        private Panel panel1;
        private Label lblBakiyeEkle;
        private Label lblSifreEkle;
        private Label lblIsimEkle;
        private Label lblTcEkle;
        private UnderLineTextBox.RGTextBox txtEkleBakiye;
        private UnderLineTextBox.RGTextBox txtEkleSifre;
        private UnderLineTextBox.RGTextBox txtEkleIsim;
        private UnderLineTextBox.RGTextBox txtEkleTc;
    }
}