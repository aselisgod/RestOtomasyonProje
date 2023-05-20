using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranDemo
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMasaSiparis_Click(object sender, EventArgs e)
        {
            frmMasa frm = new frmMasa();
            this.Close();
            frm.Show();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            frmRezervasyon frm = new frmRezervasyon();
            this.Close();
            frm.Show();
        }

        private void btnPaketServis_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            this.Close();
            frm.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            this.Close();
            frm.Show();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            frmKasa frm = new frmKasa();
            this.Close();
            frm.Show();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            frmMutfak frm = new frmMutfak();
            this.Close();
            frm.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRaporlar frmRaporlar = new frmRaporlar();
            this.Close();
            frmRaporlar.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            this.Close();
            frmSettings.Show();
        }

        private void btnKilit_Click(object sender, EventArgs e)
        {
            frmLock frmLock = new frmLock();
            frmLock.Show();
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkışı Onaylıyor Musunuz?", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
