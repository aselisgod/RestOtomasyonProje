namespace RestoranDemo
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            groupBox1 = new GroupBox();
            chkIndirim = new CheckBox();
            gbIndirim = new GroupBox();
            txtIndirimTutarı = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            lblOdenecek = new Label();
            lblToplamTutar = new Label();
            label10 = new Label();
            label3 = new Label();
            lblKdv = new Label();
            label2 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            lblIndirim = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            rbTicket = new RadioButton();
            rbKrediKartı = new RadioButton();
            rbNakit = new RadioButton();
            lvUrunler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnCikis = new Button();
            btnGeriDön = new Button();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            lblAdisyonID = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            groupBox1.SuspendLayout();
            gbIndirim.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(chkIndirim);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(752, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 148);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Özel İndirim";
            // 
            // chkIndirim
            // 
            chkIndirim.AutoSize = true;
            chkIndirim.Location = new Point(0, 70);
            chkIndirim.Name = "chkIndirim";
            chkIndirim.Size = new Size(235, 42);
            chkIndirim.TabIndex = 0;
            chkIndirim.Text = "İndirim Uygula";
            chkIndirim.UseVisualStyleBackColor = true;
            chkIndirim.CheckedChanged += chkIndirim_CheckedChanged;
            // 
            // gbIndirim
            // 
            gbIndirim.BackColor = Color.LightGray;
            gbIndirim.Controls.Add(txtIndirimTutarı);
            gbIndirim.Controls.Add(label6);
            gbIndirim.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbIndirim.Location = new Point(1006, 72);
            gbIndirim.Name = "gbIndirim";
            gbIndirim.Size = new Size(248, 148);
            gbIndirim.TabIndex = 0;
            gbIndirim.TabStop = false;
            gbIndirim.Text = "Özel Aktivite";
            gbIndirim.Visible = false;
            // 
            // txtIndirimTutarı
            // 
            txtIndirimTutarı.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtIndirimTutarı.Location = new Point(6, 82);
            txtIndirimTutarı.Multiline = true;
            txtIndirimTutarı.Name = "txtIndirimTutarı";
            txtIndirimTutarı.Size = new Size(190, 30);
            txtIndirimTutarı.TabIndex = 1;
            txtIndirimTutarı.TextChanged += txtIndirimTutarı_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 39);
            label6.Name = "label6";
            label6.Size = new Size(190, 28);
            label6.TabIndex = 0;
            label6.Text = "Özel İndirim Tutarı";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightGray;
            groupBox3.Controls.Add(lblOdenecek);
            groupBox3.Controls.Add(lblToplamTutar);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(lblKdv);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(lblIndirim);
            groupBox3.Controls.Add(label1);
            groupBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 391);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(356, 241);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ödeme Bilgileri";
            // 
            // lblOdenecek
            // 
            lblOdenecek.AutoSize = true;
            lblOdenecek.Location = new Point(183, 189);
            lblOdenecek.Name = "lblOdenecek";
            lblOdenecek.Size = new Size(33, 38);
            lblOdenecek.TabIndex = 1;
            lblOdenecek.Text = "0";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(183, 141);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(33, 38);
            lblToplamTutar.TabIndex = 1;
            lblToplamTutar.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 189);
            label10.Name = "label10";
            label10.Size = new Size(167, 38);
            label10.TabIndex = 1;
            label10.Text = "Ara Toplam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 141);
            label3.Name = "label3";
            label3.Size = new Size(81, 38);
            label3.TabIndex = 1;
            label3.Text = "Fiyat";
            // 
            // lblKdv
            // 
            lblKdv.AutoSize = true;
            lblKdv.Location = new Point(183, 93);
            lblKdv.Name = "lblKdv";
            lblKdv.Size = new Size(33, 38);
            lblKdv.TabIndex = 1;
            lblKdv.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 94);
            label2.Name = "label2";
            label2.Size = new Size(75, 38);
            label2.TabIndex = 1;
            label2.Text = "KDV";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(303, 189);
            label16.Name = "label16";
            label16.Size = new Size(47, 38);
            label16.TabIndex = 1;
            label16.Text = "TL";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(303, 142);
            label15.Name = "label15";
            label15.Size = new Size(47, 38);
            label15.TabIndex = 1;
            label15.Text = "TL";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(303, 93);
            label14.Name = "label14";
            label14.Size = new Size(47, 38);
            label14.TabIndex = 1;
            label14.Text = "TL";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(303, 46);
            label13.Name = "label13";
            label13.Size = new Size(47, 38);
            label13.TabIndex = 1;
            label13.Text = "TL";
            // 
            // lblIndirim
            // 
            lblIndirim.AutoSize = true;
            lblIndirim.Location = new Point(183, 46);
            lblIndirim.Name = "lblIndirim";
            lblIndirim.Size = new Size(33, 38);
            lblIndirim.TabIndex = 1;
            lblIndirim.Text = "0";
            lblIndirim.TextChanged += lblIndirim_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(113, 38);
            label1.TabIndex = 1;
            label1.Text = "İndirim";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.LightGray;
            groupBox4.Controls.Add(rbTicket);
            groupBox4.Controls.Add(rbKrediKartı);
            groupBox4.Controls.Add(rbNakit);
            groupBox4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(375, 391);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(371, 212);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ödeme Türü";
            // 
            // rbTicket
            // 
            rbTicket.AutoSize = true;
            rbTicket.Location = new Point(6, 138);
            rbTicket.Name = "rbTicket";
            rbTicket.Size = new Size(117, 42);
            rbTicket.TabIndex = 0;
            rbTicket.TabStop = true;
            rbTicket.Text = "Ticket";
            rbTicket.UseVisualStyleBackColor = true;
            // 
            // rbKrediKartı
            // 
            rbKrediKartı.AutoSize = true;
            rbKrediKartı.Location = new Point(6, 90);
            rbKrediKartı.Name = "rbKrediKartı";
            rbKrediKartı.Size = new Size(179, 42);
            rbKrediKartı.TabIndex = 0;
            rbKrediKartı.TabStop = true;
            rbKrediKartı.Text = "Kredi Kartı";
            rbKrediKartı.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            rbNakit.AutoSize = true;
            rbNakit.Location = new Point(6, 42);
            rbNakit.Name = "rbNakit";
            rbNakit.Size = new Size(110, 42);
            rbNakit.TabIndex = 0;
            rbNakit.TabStop = true;
            rbNakit.Text = "Nakit";
            rbNakit.UseVisualStyleBackColor = true;
            // 
            // lvUrunler
            // 
            lvUrunler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvUrunler.FullRowSelect = true;
            lvUrunler.GridLines = true;
            lvUrunler.Location = new Point(12, 72);
            lvUrunler.Name = "lvUrunler";
            lvUrunler.Size = new Size(734, 299);
            lvUrunler.TabIndex = 1;
            lvUrunler.UseCompatibleStateImageBehavior = false;
            lvUrunler.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Urun Adı";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adet";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "UrunId";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fiyat";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "SatisId";
            columnHeader5.Width = 120;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = Properties.Resources.cikis;
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.Brown;
            btnCikis.Location = new Point(160, 688);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(142, 79);
            btnCikis.TabIndex = 7;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnGeriDön
            // 
            btnGeriDön.BackgroundImage = Properties.Resources.geridön;
            btnGeriDön.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeriDön.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeriDön.ForeColor = Color.Brown;
            btnGeriDön.Location = new Point(12, 688);
            btnGeriDön.Name = "btnGeriDön";
            btnGeriDön.Size = new Size(142, 79);
            btnGeriDön.TabIndex = 8;
            btnGeriDön.UseVisualStyleBackColor = true;
            btnGeriDön.Click += btnGeriDön_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.hesapözet1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(800, 342);
            button1.Name = "button1";
            button1.Size = new Size(235, 133);
            button1.TabIndex = 1;
            button1.Text = "HESAP ÖZETİ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.hesapkapat;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(800, 481);
            button2.Name = "button2";
            button2.Size = new Size(235, 133);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 21);
            label4.Name = "label4";
            label4.Size = new Size(138, 38);
            label4.TabIndex = 9;
            label4.Text = "Siparisler";
            // 
            // lblAdisyonID
            // 
            lblAdisyonID.AutoSize = true;
            lblAdisyonID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdisyonID.Location = new Point(198, 21);
            lblAdisyonID.Name = "lblAdisyonID";
            lblAdisyonID.Size = new Size(30, 28);
            lblAdisyonID.TabIndex = 10;
            lblAdisyonID.Text = "Id";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage_1;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.STAR_CHEF_Corporate_logo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1512, 779);
            Controls.Add(lblAdisyonID);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCikis);
            Controls.Add(btnGeriDön);
            Controls.Add(lvUrunler);
            Controls.Add(groupBox4);
            Controls.Add(gbIndirim);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "frmBill";
            Text = "frmBill";
            Load += frmBill_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbIndirim.ResumeLayout(false);
            gbIndirim.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox gbIndirim;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private CheckBox chkIndirim;
        private ListView lvUrunler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private RadioButton rbTicket;
        private RadioButton rbKrediKartı;
        private RadioButton rbNakit;
        private Label lblOdenecek;
        private Label lblToplamTutar;
        private Label label10;
        private Label label3;
        private Label lblKdv;
        private Label label2;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label lblIndirim;
        private Label label1;
        private Button btnCikis;
        private Button btnGeriDön;
        private Button button1;
        private Button button2;
        private TextBox txtIndirimTutarı;
        private Label label6;
        private Label label4;
        private Label lblAdisyonID;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}