namespace RestoranDemo
{
    partial class frmMenu
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
            btnMasaSiparis = new Button();
            btnCikis = new Button();
            btnGeriDön = new Button();
            SuspendLayout();
            // 
            // btnMasaSiparis
            // 
            btnMasaSiparis.BackgroundImage = Properties.Resources.masa1;
            btnMasaSiparis.BackgroundImageLayout = ImageLayout.Stretch;
            btnMasaSiparis.FlatStyle = FlatStyle.Popup;
            btnMasaSiparis.Location = new Point(129, 72);
            btnMasaSiparis.Name = "btnMasaSiparis";
            btnMasaSiparis.Size = new Size(671, 555);
            btnMasaSiparis.TabIndex = 0;
            btnMasaSiparis.UseVisualStyleBackColor = true;
            btnMasaSiparis.Click += btnMasaSiparis_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackgroundImage = Properties.Resources.cikis;
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.FlatStyle = FlatStyle.Popup;
            btnCikis.Location = new Point(846, 456);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(212, 171);
            btnCikis.TabIndex = 0;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnGeriDön
            // 
            btnGeriDön.BackgroundImage = Properties.Resources.geridön;
            btnGeriDön.BackgroundImageLayout = ImageLayout.Stretch;
            btnGeriDön.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeriDön.ForeColor = Color.Brown;
            btnGeriDön.Location = new Point(846, 226);
            btnGeriDön.Name = "btnGeriDön";
            btnGeriDön.Size = new Size(212, 160);
            btnGeriDön.TabIndex = 7;
            btnGeriDön.UseVisualStyleBackColor = true;
            btnGeriDön.Click += btnGeriDön_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.STAR_CHEF_Corporate_logo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1201, 779);
            Controls.Add(btnGeriDön);
            Controls.Add(btnCikis);
            Controls.Add(btnMasaSiparis);
            DoubleBuffered = true;
            Name = "frmMenu";
            Text = "frmMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMasaSiparis;
        private Button btnCikis;
        private Button btnGeriDön;
    }
}