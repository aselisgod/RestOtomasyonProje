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
        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkışı Onaylıyor Musunuz?", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }
    }
}
