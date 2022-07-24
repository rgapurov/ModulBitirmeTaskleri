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
            DialogResult dialogResult = MessageBox.Show("Veritabanı ve Tabloları Oluşturmak için EVET'e " +
                                                        "Devam Etmek için Hayıra Tıklayın", "UYARI!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                method.DBOlustur();
                method.TabloOluştur();
            }

        }

        private void txtTC_Enter(object sender, EventArgs e)
        {
            lblTcno.ForeColor = renkler.pembeFocus;
        }

        private void txtTC_Leave(object sender, EventArgs e)
        {
            lblTcno.ForeColor = renkler.maviUnFocus;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            lblPassword.ForeColor = renkler.pembeFocus;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            lblPassword.ForeColor = renkler.maviUnFocus;
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
            { MessageBox.Show("Başarılı Giriş!", "UYARI!"); }
            else { MessageBox.Show("Hatalı Giriş!", "UYARI!"); }
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
        }

        private void txtEkleTc_Leave(object sender, EventArgs e)
        {
            lblTcEkle.ForeColor =renkler.maviUnFocus;
        }

        private void rgTextBox2_Enter(object sender, EventArgs e)
        {
            lblIsimEkle.ForeColor = renkler.pembeFocus;
        }

        private void txtEkleIsim_Leave(object sender, EventArgs e)
        {
            lblIsimEkle.ForeColor = renkler.maviUnFocus;  
        }

        private void txtEkleSifre_Enter(object sender, EventArgs e)
        {
            lblSifreEkle.ForeColor = renkler.pembeFocus;    
        }

        private void txtEkleSifre_Leave(object sender, EventArgs e)
        {
            lblSifreEkle.ForeColor = renkler.maviUnFocus;
        }

        private void lblEkleBakiye_Enter(object sender, EventArgs e)
        {
            lblBakiyeEkle.ForeColor = renkler.pembeFocus;
        }

        private void lblEkleBakiye_Leave(object sender, EventArgs e)
        {
            lblBakiyeEkle.ForeColor = renkler.maviUnFocus;  
        }
    }
}
