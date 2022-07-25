using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankamatik
{
    public partial class frmLoginPanel : Form
    {
        methods method = new methods();
        public frmLoginPanel()
        {
            InitializeComponent();
        }

        private void frmLoginPanel_Load(object sender, EventArgs e)
        {
            method.DBOlustur();
            method.TabloOluştur();
        }

        private void txtTC_Enter(object sender, EventArgs e)
        {
            lblTcno.ForeColor = renkler.pembeFocus;
            txtTC.ForeColor = renkler.pembeFocus;
        }

        private void txtTC_Leave(object sender, EventArgs e)
        {
            lblTcno.ForeColor = renkler.maviUnFocus;
            txtTC.ForeColor = renkler.maviUnFocus;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            lblPassword.ForeColor = renkler.pembeFocus;
            txtPassword.ForeColor = renkler.pembeFocus;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            lblPassword.ForeColor = renkler.maviUnFocus;
            txtPassword.ForeColor = renkler.maviUnFocus; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.IconColor = renkler.pembeFocus;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.IconColor = renkler.maviUnFocus;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (method.KullanıcıKontrol(txtTC.Texts, txtPassword.Texts)==true)
            {
                
                frmMain frmMain = new frmMain();
                frmMain.aktifTC = Convert.ToInt32(txtTC.Texts);
                txtTC.Texts = "";
                txtPassword.Texts = "";
                this.Hide();
                frmMain.Show();                
                
            }
            else { MessageBox.Show("Hatalı Giriş!", "UYARI!"); }
            txtTC.Texts = "";
            txtPassword.Texts = "";
        }

        private void lblSignUp_MouseHover(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = renkler.pembeFocus;
        }

        private void lblSignUp_MouseLeave(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = renkler.maviUnFocus;
        }

        private void txtEkleTc_Enter(object sender, EventArgs e)
        {
            lblTcEkle.ForeColor = renkler.pembeFocus;
            txtEkleTc.ForeColor = renkler.pembeFocus;
        }

        private void txtEkleTc_Leave(object sender, EventArgs e)
        {
            lblTcEkle.ForeColor = renkler.maviUnFocus;
            txtEkleTc.ForeColor = renkler.maviUnFocus;    
        }

        private void rgTextBox2_Enter(object sender, EventArgs e)
        {
            lblIsimEkle.ForeColor = renkler.pembeFocus;
            txtEkleIsim.ForeColor = renkler.pembeFocus;
        }

        private void txtEkleIsim_Leave(object sender, EventArgs e)
        {
            lblIsimEkle.ForeColor = renkler.maviUnFocus;
            txtEkleIsim.ForeColor = renkler.maviUnFocus;
        }

        private void txtEkleSifre_Enter(object sender, EventArgs e)
        {
            lblSifreEkle.ForeColor = renkler.pembeFocus;
            txtEkleSifre.ForeColor = renkler.pembeFocus;
        }

        private void txtEkleSifre_Leave(object sender, EventArgs e)
        {
            lblSifreEkle.ForeColor = renkler.maviUnFocus;
            txtEkleSifre.ForeColor = renkler.maviUnFocus;    
        }

        private void lblEkleBakiye_Enter(object sender, EventArgs e)
        {
            lblBakiyeEkle.ForeColor = renkler.pembeFocus;
            txtEkleBakiye.ForeColor = renkler.pembeFocus;   
        }

        private void lblEkleBakiye_Leave(object sender, EventArgs e)
        {
            lblBakiyeEkle.ForeColor = renkler.maviUnFocus;
            txtEkleBakiye.ForeColor = renkler.maviUnFocus;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            txtTC.Texts = "";
            txtPassword.Texts = "";
            timerOpen.Enabled = true;
        }

        private void timerOpen_Tick(object sender, EventArgs e)
        {
            if (pnlSignUp.Width < 700) {pnlSignUp.Width = pnlSignUp.Width + 25 ; }
            else { timerOpen.Enabled = false; }
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            if (pnlSignUp.Width >10) { pnlSignUp.Width = pnlSignUp.Width -25; }
            else { timerClose.Enabled = false; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int tc = Convert.ToInt32(txtEkleTc.Texts),
                pass = Convert.ToInt32(txtEkleSifre.Texts),
                bakiye = Convert.ToInt32(txtEkleBakiye.Texts);
            string adi = txtEkleIsim.Texts.ToString();

            if (method.KullanıcıOlustur(tc, adi, pass, bakiye) == true)
            {
                MessageBox.Show("İşlem Başarılı!", "Uyarı!");
                txtEkleTc.Texts = "";
                txtEkleSifre.Texts = "";
                txtEkleIsim.Texts = "";
                txtEkleBakiye.Texts = "";
                timerClose.Enabled = true;
            }
            else { MessageBox.Show("Hatalı İşlem!", "Uyarı!"); }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEkleTc.Texts = "";
            txtEkleSifre.Texts = "";
            txtEkleIsim.Texts = "";
            txtEkleBakiye.Texts = "";
            timerClose.Enabled = true;
        }
    }
}
