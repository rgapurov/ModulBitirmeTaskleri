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
    public partial class frmMain : Form
    {
        public int aktifTC, islemdekiPara=0, bakiye;
        methods method = new methods();
        public frmMain()
        {
            InitializeComponent();
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = method.IsimGetir(aktifTC).ToUpper() + " Hoşgeldiniz!";
            bakiye = method.BakiyeGetir(aktifTC);
            lblBakiye.Text = "Bakiyeniz: " + bakiye + " TL";
        }

        private void txtParaCek_Enter(object sender, EventArgs e)
        {
            lblParaCek.ForeColor = renkler.maviYazi;
            pnlParaCek.BackgroundImage = Properties.Resources.pembe;
        }

        private void txtParaCek_Leave(object sender, EventArgs e)
        {
            lblParaCek.ForeColor = Color.White;
            pnlParaCek.BackgroundImage = Properties.Resources.mavi;
            txtParaCek.Text = "";
        }

        private void txtParaYatir_Enter(object sender, EventArgs e)
        {
            lblParaYatir.ForeColor = renkler.maviYazi;
            pnlParaYatir.BackgroundImage = Properties.Resources.pembe;
        }

        private void txtParaYatir_Leave(object sender, EventArgs e)
        {
            lblParaYatir.ForeColor = Color.White;
            pnlParaYatir.BackgroundImage = Properties.Resources.mavi;
            txtParaYatir.Text = "";
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            lblWelcome.Focus();
        }

        private void txtParaAktar_Leave(object sender, EventArgs e)
        {
            lblParaAktar.ForeColor = Color.White;
            pnlParaAktar.BackgroundImage = Properties.Resources.mavi;
            txtParaAktar.Text = "";
        }

        private void pnlParaYatir_Click(object sender, EventArgs e)
        {
            try { islemdekiPara = Convert.ToInt32(txtParaYatir.Text); } catch { }
            if (islemdekiPara == 0)
            {
                MessageBox.Show("Hatalı İşlem", "Uyarı!");
                txtParaYatir.Text = "";
            }
            else
            {
                method.ParaYatir(aktifTC, islemdekiPara);
                bakiye = method.BakiyeGetir(aktifTC);
                lblBakiye.Text = "Bakiyeniz: " + bakiye + " TL";
                lblBakiye.Focus();
                islemdekiPara = 0;
                txtParaCek.Text = "";
                MessageBox.Show("İşlem Başarılı", "Uyarı!");
            }
        }

        private void pnlCikis_Click(object sender, EventArgs e)
        {
            frmLoginPanel frm = new frmLoginPanel();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void lblParaCek_Click(object sender, EventArgs e)
        {
            try { islemdekiPara = Convert.ToInt32(txtParaCek.Text); } catch { }
            if (islemdekiPara > bakiye)
            {
                MessageBox.Show("Yetersiz Bakiye", "Uyarı!");
                txtParaCek.Text = "";
            }
            else if (islemdekiPara == 0)
            {
                MessageBox.Show("Hatalı İşlem", "Uyarı!");
                txtParaCek.Text = "";
            }
            else
            {
                method.ParaCek(aktifTC, islemdekiPara);
                bakiye = method.BakiyeGetir(aktifTC);
                lblBakiye.Text = "Bakiyeniz: " + bakiye + " TL";
                lblBakiye.Focus();
                islemdekiPara = 0;
                txtParaCek.Text = "";
                MessageBox.Show("İşlem Başarılı", "Uyarı!");
            }
        }

        private void lblParaYatir_Click(object sender, EventArgs e)
        {
            try { islemdekiPara = Convert.ToInt32(txtParaYatir.Text); } catch { }
            if (islemdekiPara == 0)
            {
                MessageBox.Show("Hatalı İşlem", "Uyarı!");
                txtParaYatir.Text = "";
            }
            else
            {
                method.ParaYatir(aktifTC, islemdekiPara);
                bakiye = method.BakiyeGetir(aktifTC);
                lblBakiye.Text = "Bakiyeniz: " + bakiye + " TL";
                lblBakiye.Focus();
                islemdekiPara = 0;
                txtParaCek.Text = "";
                MessageBox.Show("İşlem Başarılı", "Uyarı!");
            }
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            frmLoginPanel frm = new frmLoginPanel();
            this.Hide();
            frm.ShowDialog();
        }

        private void txtParaAktar_Enter(object sender, EventArgs e)
        {
            lblParaAktar.ForeColor = renkler.maviYazi;
            pnlParaAktar.BackgroundImage = Properties.Resources.pembe;
        }

        private void pnlParaCek_Click(object sender, EventArgs e)
        {
            try { islemdekiPara = Convert.ToInt32(txtParaCek.Text); } catch { }            
            if (islemdekiPara > bakiye)
            {
                MessageBox.Show("Yetersiz Bakiye", "Uyarı!");
                txtParaCek.Text = "";
            }
            else if (islemdekiPara == 0) 
            {
                MessageBox.Show("Hatalı İşlem", "Uyarı!");
                txtParaCek.Text = "";
            }
            else
            {
                method.ParaCek(aktifTC, islemdekiPara);
                bakiye = method.BakiyeGetir(aktifTC);
                lblBakiye.Text = "Bakiyeniz: " + bakiye + " TL";
                lblBakiye.Focus();
                islemdekiPara = 0;
                txtParaCek.Text = "";
                MessageBox.Show("İşlem Başarılı", "Uyarı!");
            }
        }
    }
}
