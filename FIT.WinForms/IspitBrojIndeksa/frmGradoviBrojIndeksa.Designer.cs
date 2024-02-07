namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmGradoviBrojIndeksa
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
            pbSlika = new PictureBox();
            lblNaziv = new Label();
            label2 = new Label();
            txtNaziv = new TextBox();
            btnDodaj = new Button();
            dgvGrad = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Promjeni = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            label4 = new Label();
            btnGenerisi = new Button();
            cbStatus = new CheckBox();
            txtBroj = new TextBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrad).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(109, 50);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblNaziv
            // 
            lblNaziv.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblNaziv.Location = new Point(139, 12);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(357, 50);
            lblNaziv.TabIndex = 1;
            lblNaziv.Text = "label1";
            lblNaziv.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 2;
            label2.Text = "Unesite naziv novog grada:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(167, 92);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(248, 23);
            txtNaziv.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(421, 92);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvGrad
            // 
            dgvGrad.AllowUserToAddRows = false;
            dgvGrad.AllowUserToDeleteRows = false;
            dgvGrad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrad.Columns.AddRange(new DataGridViewColumn[] { Naziv, Status, Promjeni });
            dgvGrad.Location = new Point(12, 121);
            dgvGrad.Name = "dgvGrad";
            dgvGrad.ReadOnly = true;
            dgvGrad.RowTemplate.Height = 25;
            dgvGrad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrad.Size = new Size(484, 150);
            dgvGrad.TabIndex = 5;
            dgvGrad.CellContentClick += dgvGrad_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv grada";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Aktivan";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Promjeni
            // 
            Promjeni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Promjeni.HeaderText = "";
            Promjeni.Name = "Promjeni";
            Promjeni.ReadOnly = true;
            Promjeni.Text = "Promjeni";
            Promjeni.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(cbStatus);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 305);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(488, 176);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(8, 79);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(474, 91);
            txtInfo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 61);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 4;
            label4.Text = "Info:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(236, 20);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(75, 23);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(155, 22);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(63, 19);
            cbStatus.TabIndex = 2;
            cbStatus.Text = "Aktivni";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(91, 20);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(58, 23);
            txtBroj.TabIndex = 1;
            txtBroj.KeyPress += txtBroj_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 28);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 0;
            label3.Text = "Broj gradova:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmGradoviBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 487);
            Controls.Add(groupBox1);
            Controls.Add(dgvGrad);
            Controls.Add(btnDodaj);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(lblNaziv);
            Controls.Add(pbSlika);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGradoviBrojIndeksa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Podaci o gradu";
            FormClosed += frmGradoviBrojIndeksa_FormClosed;
            Load += frmGradoviBrojIndeksa_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGrad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblNaziv;
        private Label label2;
        private TextBox txtNaziv;
        private Button btnDodaj;
        private DataGridView dgvGrad;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private Label label4;
        private Button btnGenerisi;
        private CheckBox cbStatus;
        private TextBox txtBroj;
        private Label label3;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Promjeni;
        private ErrorProvider errorProvider1;
    }
}