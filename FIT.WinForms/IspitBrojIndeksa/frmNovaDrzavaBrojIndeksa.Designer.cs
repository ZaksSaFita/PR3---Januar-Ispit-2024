namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmNovaDrzavaBrojIndeksa
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pbSlika = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            label2 = new Label();
            txtNaziv = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            cbStatus = new CheckBox();
            btnSacuvaj = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Zastava:";
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(21, 35);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(266, 161);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 1;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 220);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(21, 238);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(266, 23);
            txtNaziv.TabIndex = 3;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(21, 267);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(66, 19);
            cbStatus.TabIndex = 4;
            cbStatus.Text = "Aktivna";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(197, 295);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(90, 23);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmNovaDrzavaBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 324);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbStatus);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(pbSlika);
            Controls.Add(label1);
            Name = "frmNovaDrzavaBrojIndeksa";
            Text = "Podaci o drzavi";
            Load += frmNovaDrzavaBrojIndeksa_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbSlika;
        private OpenFileDialog openFileDialog1;
        private Label label2;
        private TextBox txtNaziv;
        private ErrorProvider errorProvider1;
        private Button btnSacuvaj;
        private CheckBox cbStatus;
    }
}