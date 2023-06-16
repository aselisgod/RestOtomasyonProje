using Restoran;
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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
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

        cSiparis cs = new cSiparis();
        int odemeTurId = 0;

        private void frmBill_Load(object sender, EventArgs e)
        {
            gbIndirim.Visible = false;
            if (cGenel._ServisTurNO == 1)
            {
                lblAdisyonID.Text = cGenel._AdisyonId;
                txtIndirimTutarı.TextChanged += new EventHandler(txtIndirimTutarı_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonID.Text));
                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.000}", kdv);
                }
                gbIndirim.Visible = true;
                txtIndirimTutarı.Clear();
            }

            else if (cGenel._ServisTurNO == 2)
            {
                lblAdisyonID.Text = cGenel._AdisyonId;
                cPaketler pc = new cPaketler();
                odemeTurId = pc.OdemeTurIdGetir(Convert.ToInt32(lblAdisyonID.Text));
                txtIndirimTutarı.TextChanged += new EventHandler(txtIndirimTutarı_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lblAdisyonID.Text));

                if (odemeTurId == 1)
                {
                    rbNakit.Checked = true;
                }
                else if (odemeTurId == 2)
                {
                    rbKrediKartı.Checked = true;
                }
                else if (odemeTurId == 3)
                {
                    rbTicket.Checked = true;
                }


                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);
                    }
                    lblToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lblOdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
                    lblKdv.Text = string.Format("{0:0.000}", kdv);
                }
                gbIndirim.Visible = true;
                txtIndirimTutarı.Clear();
            }
        }

        private void txtIndirimTutarı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtIndirimTutarı.Text) < Convert.ToDecimal(lblToplamTutar.Text))
                {
                    try
                    {
                        lblIndirim.Text = string.Format("{0:0.000}", Convert.ToDecimal(txtIndirimTutarı.Text));
                    }
                    catch (Exception)
                    {

                        lblIndirim.Text = string.Format("{0:0.000}", 0);
                    }
                }
                else
                {
                    MessageBox.Show("İndirim Tutarı Toplam Tutardan Fazla Olamaz !!!");
                }
            }
            catch (Exception)
            {

                lblIndirim.Text = string.Format("{0:0.000}", 0);
            }
        }

        private void chkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndirim.Checked)
            {
                gbIndirim.Visible = true;
                txtIndirimTutarı.Clear();
            }
            else
            {
                gbIndirim.Visible = false;
                txtIndirimTutarı.Clear();
            }
        }

        private void lblIndirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblIndirim.Text) > 0)
            {
                decimal odenecek = 0;
                lblOdenecek.Text = lblToplamTutar.Text;
                odenecek = Convert.ToDecimal(lblOdenecek.Text) - Convert.ToDecimal(lblIndirim.Text);
                lblOdenecek.Text = string.Format("{0:0.000}", odenecek);
            }
            decimal kdv = Convert.ToDecimal(lblOdenecek.Text) * 18 / 100;
            lblKdv.Text = string.Format("{0:0.000}", kdv);
        }

        cMasalar masalar = new cMasalar();
        cRezervasyon rezerve = new cRezervasyon();
        private void button2_Click(object sender, EventArgs e)
        {
            if (cGenel._ServisTurNO == 1)
            {
                int masaid = masalar.TableGetbyNumber(cGenel._ButtonName);
                int musteriId = 0;
                if (masalar.TableGetByState(masaid, 4) == true)
                {
                    musteriId = rezerve.getByClientIdFromRezervasyon(masaid);
                }
                else
                {
                    musteriId = 1;
                }
                int odemeTurId = 0;
                if (rbNakit.Checked)
                {
                    odemeTurId = 1;
                }
                if (rbKrediKartı.Checked)
                {
                    odemeTurId = 2;
                }
                if (rbTicket.Checked)
                {
                    odemeTurId = 3;
                }
                cÖdeme odeme = new cÖdeme();
                odeme.AdisyonID = Convert.ToInt32(lblAdisyonID.Text);
                odeme.OdemeTurId = odemeTurId;
                odeme.MusteriId = musteriId;
                odeme.AraToplam = Convert.ToDecimal(lblOdenecek.Text);
                odeme.KdvTutari = Convert.ToDecimal(lblKdv.Text);
                odeme.GenelToplam = Convert.ToDecimal(lblToplamTutar.Text);
                odeme.Indirim = Convert.ToDecimal(lblIndirim.Text);

                bool result = odeme.billClose(odeme);

                if (result)
                {
                    MessageBox.Show("Hesap Kapatıldı.");
                    masalar.setChangeTableState(Convert.ToString(masaid), 1);
                    cRezervasyon c = new cRezervasyon();
                    c.rezervationClose(Convert.ToInt32(lblAdisyonID.Text));

                    cAdisyon a = new cAdisyon();
                    a.AdisyonKapat(Convert.ToInt32(lblAdisyonID.Text), 0);

                    this.Close();
                    frmMasa frm = new frmMasa();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Hesap Kapatılamadı!!!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        Font Baslik = new Font("Verdana", 15, FontStyle.Bold);
        Font altBaslik = new Font("Verdana", 12, FontStyle.Regular);
        Font icerik = new Font("Verdana", 10);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {



        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("StarChef RESTAURANT", Baslik, sb, 250, 100, st);

            e.Graphics.DrawString("............................................", altBaslik, sb, 350, 120, st);
            e.Graphics.DrawString("Ürün Adı                 Adet          Fiyat", altBaslik, sb, 150, 250, st);
            e.Graphics.DrawString("............................................", altBaslik, sb, 150, 280, st);

            for (int i = 0; i < lvUrunler.Items.Count; i++)
            {
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[0].Text, icerik, sb, 150, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[1].Text, icerik, sb, 350, 300 + i * 30, st);
                e.Graphics.DrawString(lvUrunler.Items[i].SubItems[3].Text, icerik, sb, 420, 300 + i * 30, st);
            }
            e.Graphics.DrawString("........................................................", altBaslik, sb, 150, 300 + 30 * lvUrunler.Items.Count, st);
            e.Graphics.DrawString("İndirim Tutarı   :" + lblIndirim.Text + "TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 1), st);
            e.Graphics.DrawString("KDV Tutarı       :" + lblKdv.Text + "TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 2), st);
            e.Graphics.DrawString("Toplam Tutar     :" + lblToplamTutar.Text + "TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 3), st);
            e.Graphics.DrawString("Ödenen Tutar     :" + lblOdenecek.Text + "TL", altBaslik, sb, 250, 300 + 30 * (lvUrunler.Items.Count + 4), st);

        }
    }
}
