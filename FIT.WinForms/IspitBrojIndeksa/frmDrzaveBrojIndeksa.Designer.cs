namespace FIT.WinForms.IspitBrojIndeksa
{
    partial class frmDrzaveBrojIndeksa
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
            btnDrzava = new Button();
            dgvDrzava = new DataGridView();
            Slika = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            BrojGradova = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            Gradovi = new DataGridViewButtonColumn();
            btnPrint = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            lblTimer = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgvDrzava).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDrzava
            // 
            btnDrzava.Location = new Point(546, 19);
            btnDrzava.Name = "btnDrzava";
            btnDrzava.Size = new Size(116, 23);
            btnDrzava.TabIndex = 0;
            btnDrzava.Text = "Nova Drzava";
            btnDrzava.UseVisualStyleBackColor = true;
            btnDrzava.Click += btnDrzava_Click;
            // 
            // dgvDrzava
            // 
            dgvDrzava.AllowUserToAddRows = false;
            dgvDrzava.AllowUserToDeleteRows = false;
            dgvDrzava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrzava.Columns.AddRange(new DataGridViewColumn[] { Slika, Naziv, BrojGradova, Status, Gradovi });
            dgvDrzava.Location = new Point(12, 48);
            dgvDrzava.Name = "dgvDrzava";
            dgvDrzava.ReadOnly = true;
            dgvDrzava.RowTemplate.Height = 25;
            dgvDrzava.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrzava.Size = new Size(650, 210);
            dgvDrzava.TabIndex = 1;
            dgvDrzava.CellContentClick += dgvDrzava_CellContentClick;
            dgvDrzava.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Slika
            // 
            Slika.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Zastava";
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            Slika.Width = 121;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Drzava";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // BrojGradova
            // 
            BrojGradova.DataPropertyName = "BrojGradova";
            BrojGradova.HeaderText = "Broj gradova";
            BrojGradova.Name = "BrojGradova";
            BrojGradova.ReadOnly = true;
            BrojGradova.Width = 121;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Aktivan";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Gradovi
            // 
            Gradovi.DataPropertyName = "Gradovi";
            Gradovi.HeaderText = "";
            Gradovi.Name = "Gradovi";
            Gradovi.ReadOnly = true;
            Gradovi.Text = "Gradovi";
            Gradovi.UseColumnTextForButtonValue = true;
            Gradovi.Width = 121;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(546, 264);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(116, 23);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Printaj";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTimer });
            statusStrip1.Location = new Point(0, 296);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(673, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTimer
            // 
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(118, 17);
            lblTimer.Text = "toolStripStatusLabel1";
            // 
            // frmDrzaveBrojIndeksa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 318);
            Controls.Add(statusStrip1);
            Controls.Add(btnPrint);
            Controls.Add(dgvDrzava);
            Controls.Add(btnDrzava);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDrzaveBrojIndeksa";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Drzave";
            Load += frmDrzaveBrojIndeksa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrzava).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDrzava;
        private DataGridView dgvDrzava;
        private Button btnPrint;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTimer;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn BrojGradova;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn Gradovi;
    }
}