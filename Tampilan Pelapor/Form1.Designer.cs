namespace Tampilan_Pelapor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            buatPengaduanToolStripMenuItem = new ToolStripMenuItem();
            tentangToolStripMenuItem = new ToolStripMenuItem();
            pengaduanToolStripMenuItem = new ToolStripMenuItem();

            groupForm = new GroupBox();
            buttonKirim = new Button();
            buttonReset = new Button();
            buttonFoto = new Button();
            pictureBoxFoto = new PictureBox();
            rtbDeskripsi = new RichTextBox();
            textJudul = new TextBox();
            textLokasi = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboKategori = new ComboBox();
            textNik = new TextBox();
            textNama = new TextBox();

            labelNama = new Label();
            groupDetail = new GroupBox();
            textDetail = new TextBox();
            groupDaftar = new GroupBox();
            listDaftar = new ListView();
            columnNO = new ColumnHeader();
            columnTanggal = new ColumnHeader();
            columnKategori = new ColumnHeader();
            columnJudul = new ColumnHeader();
            columnNik = new ColumnHeader();
            columnNama = new ColumnHeader();
            columnLokasi = new ColumnHeader();
            columnDeskripsi = new ColumnHeader();

            groupDetail = new GroupBox();
            rtbDetail = new RichTextBox();
            pictureBoxDetailFoto = new PictureBox();
            detailFotoAduanLabel = new Label();

            menuStrip1.SuspendLayout();
            groupForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            groupDetail.SuspendLayout();
            groupDaftar.SuspendLayout();
            groupDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDetailFoto).BeginInit();
            SuspendLayout();

            // MENU
            menuStrip1.Items.AddRange(new ToolStripItem[] {
                homeToolStripMenuItem,
                buatPengaduanToolStripMenuItem,
                tentangToolStripMenuItem,
                pengaduanToolStripMenuItem
            });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Size = new Size(950, 30);

            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;

            buatPengaduanToolStripMenuItem.Text = "Buat Pengaduan";
            buatPengaduanToolStripMenuItem.Click += buatPengaduanToolStripMenuItem_Click;

            tentangToolStripMenuItem.Text = "Tentang";
            tentangToolStripMenuItem.Click += tentangToolStripMenuItem_Click;

            pengaduanToolStripMenuItem.Text = "Bantuan";
            pengaduanToolStripMenuItem.Click += pengaduanToolStripMenuItem_Click;
            // 
            // groupForm
            // 
            groupForm.Controls.Add(buttonReset);
            groupForm.Controls.Add(buttonKirim);
            groupForm.Controls.Add(pictureBoxFoto);
            groupForm.Controls.Add(buttonFoto);
            groupForm.Controls.Add(rtbDeskripsi);
            groupForm.Controls.Add(textJudul);
            groupForm.Controls.Add(textLokasi);
            groupForm.Controls.Add(dateTimePicker1);
            groupForm.Controls.Add(comboKategori);
            groupForm.Controls.Add(textNik);
            groupForm.Controls.Add(textNama);
            groupForm.Controls.Add(labelDeskripsi);
            groupForm.Controls.Add(labelJudul);
            groupForm.Controls.Add(labelLokasi);
            groupForm.Controls.Add(labelTanggal);
            groupForm.Controls.Add(labelKategori);
            groupForm.Controls.Add(labelNik);
            groupForm.Controls.Add(labelNama);
            groupForm.Font = new Font("Segoe UI", 10F);
            groupForm.Location = new Point(16, 64);
            groupForm.Margin = new Padding(2);
            groupForm.Name = "groupForm";
            groupForm.Padding = new Padding(2);
            groupForm.Size = new Size(406, 469);
            groupForm.TabIndex = 0;
            groupForm.TabStop = false;
            groupForm.Text = "Buat Pengaduan";
            groupForm.Location = new Point(12, 40);
            groupForm.Size = new Size(410, 580);
            groupForm.Enter += groupForm_Enter;

            labelNama.Text = "Nama";
            labelNama.Location = new Point(20, 30);
            textNama.Location = new Point(110, 30);
            textNama.Size = new Size(260, 27);
            textNama.TextChanged += textNama_TextChanged;

            labelNik.Text = "NIK";
            labelNik.Location = new Point(20, 70);
            textNik.Location = new Point(110, 70);
            textNik.Size = new Size(260, 27);
            textNik.TextChanged += textNik_TextChanged;

            labelKategori.Text = "Kategori";
            labelKategori.Location = new Point(20, 110);
            comboKategori.Location = new Point(110, 110);
            comboKategori.Size = new Size(260, 27);
            comboKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;

            labelTanggal.Text = "Tanggal";
            labelTanggal.Location = new Point(20, 150);
            dateTimePicker1.Location = new Point(110, 150);
            dateTimePicker1.Size = new Size(260, 27);

            labelLokasi.Text = "Lokasi";
            labelLokasi.Location = new Point(20, 190);
            textLokasi.Location = new Point(110, 190);
            textLokasi.Size = new Size(260, 27);

            labelJudul.Text = "Judul";
            labelJudul.Location = new Point(20, 230);
            textJudul.Location = new Point(110, 230);
            textJudul.Size = new Size(260, 27);

            labelDeskripsi.Text = "Deskripsi";
            labelDeskripsi.Location = new Point(20, 270);
            rtbDeskripsi.Location = new Point(110, 270);
            rtbDeskripsi.Size = new Size(260, 80);

            buttonFoto.Text = "Lampirkan Foto";
            buttonFoto.Location = new Point(110, 360);
            buttonFoto.Click += buttonFoto_Click;

            pictureBoxFoto.Location = new Point(250, 360);
            pictureBoxFoto.Size = new Size(120, 90);
            pictureBoxFoto.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFoto.Click += pictureBoxFoto_Click;
            // 
            // buttonFoto
            // 
            buttonFoto.BackColor = Color.LightGray;
            buttonFoto.Location = new Point(108, 362);
            buttonFoto.Margin = new Padding(2);
            buttonFoto.Name = "buttonFoto";
            buttonFoto.Size = new Size(133, 27);
            buttonFoto.TabIndex = 14;
            buttonFoto.Text = "Lampirkan Foto";
            buttonFoto.UseVisualStyleBackColor = false;
            buttonFoto.Click += buttonFoto_Click;
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.Location = new Point(108, 274);
            rtbDeskripsi.Margin = new Padding(2);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(273, 68);
            rtbDeskripsi.TabIndex = 13;
            rtbDeskripsi.Text = "";
            // 
            // textJudul
            // 
            textJudul.Location = new Point(109, 233);
            textJudul.Margin = new Padding(2);
            textJudul.Name = "textJudul";
            textJudul.Size = new Size(272, 30);
            textJudul.TabIndex = 12;
            // 
            // textLokasi
            // 
            textLokasi.Location = new Point(109, 193);
            textLokasi.Margin = new Padding(2);
            textLokasi.Name = "textLokasi";
            textLokasi.Size = new Size(272, 30);
            textLokasi.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(109, 151);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(272, 30);
            dateTimePicker1.TabIndex = 10;
            // 
            // comboKategori
            // 
            comboKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            comboKategori.FormattingEnabled = true;
            comboKategori.Items.AddRange(new object[] { "Kebersihan", "Ketertiban dan Keamanan", "Infrastruktur dan Fasilitas Umum", "Layanan Publik", "Lainnya" });
            comboKategori.Location = new Point(109, 108);
            comboKategori.Margin = new Padding(2);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(272, 31);
            comboKategori.TabIndex = 9;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
            // 
            // textNik
            // 
            textNik.Location = new Point(109, 66);
            textNik.Margin = new Padding(2);
            textNik.Name = "textNik";
            textNik.Size = new Size(272, 30);
            textNik.TabIndex = 8;
            textNik.TextChanged += textNik_TextChanged;
            // 
            // textNama
            // 
            textNama.Location = new Point(109, 26);
            textNama.Margin = new Padding(2);
            textNama.Name = "textNama";
            textNama.Size = new Size(272, 30);
            textNama.TabIndex = 7;
            textNama.TextChanged += textNama_TextChanged;
            // 
            // labelDeskripsi
            // 
            labelDeskripsi.AutoSize = true;
            labelDeskripsi.Location = new Point(19, 274);
            labelDeskripsi.Margin = new Padding(2, 0, 2, 0);
            labelDeskripsi.Name = "labelDeskripsi";
            labelDeskripsi.Size = new Size(77, 23);
            labelDeskripsi.TabIndex = 6;
            labelDeskripsi.Text = "Deskripsi";
            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.Location = new Point(19, 233);
            labelJudul.Margin = new Padding(2, 0, 2, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(50, 23);
            labelJudul.TabIndex = 5;
            labelJudul.Text = "Judul";
            // 
            // labelLokasi
            // 
            labelLokasi.AutoSize = true;
            labelLokasi.Location = new Point(19, 193);
            labelLokasi.Margin = new Padding(2, 0, 2, 0);
            labelLokasi.Name = "labelLokasi";
            labelLokasi.Size = new Size(56, 23);
            labelLokasi.TabIndex = 4;
            labelLokasi.Text = "Lokasi";
            labelLokasi.Click += labelLokasi_Click;
            // 
            // labelTanggal
            // 
            labelTanggal.AutoSize = true;
            labelTanggal.Location = new Point(19, 151);
            labelTanggal.Margin = new Padding(2, 0, 2, 0);
            labelTanggal.Name = "labelTanggal";
            labelTanggal.Size = new Size(69, 23);
            labelTanggal.TabIndex = 3;
            labelTanggal.Text = "Tanggal";
            // 
            // labelKategori
            // 
            labelKategori.AutoSize = true;
            labelKategori.Location = new Point(19, 108);
            labelKategori.Margin = new Padding(2, 0, 2, 0);
            labelKategori.Name = "labelKategori";
            labelKategori.Size = new Size(74, 23);
            labelKategori.TabIndex = 2;
            labelKategori.Text = "Kategori";
            // 
            // labelNik
            // 
            labelNik.AutoSize = true;
            labelNik.Location = new Point(19, 66);
            labelNik.Margin = new Padding(2, 0, 2, 0);
            labelNik.Name = "labelNik";
            labelNik.Size = new Size(38, 23);
            labelNik.TabIndex = 1;
            labelNik.Text = "NIK";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(19, 31);
            labelNama.Margin = new Padding(2, 0, 2, 0);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(56, 23);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama";
            labelNama.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupDetail
            // 
            groupDetail.Controls.Add(textDetail);
            groupDetail.Location = new Point(433, 304);
            groupDetail.Margin = new Padding(2);
            groupDetail.Name = "groupDetail";
            groupDetail.Padding = new Padding(2);
            groupDetail.Size = new Size(500, 229);
            groupDetail.TabIndex = 13;
            groupDetail.TabStop = false;
            groupDetail.Text = "Detail Pengaduan";
            // 
            // textDetail
            // 
            textDetail.Location = new Point(10, 26);
            textDetail.Margin = new Padding(2);
            textDetail.Multiline = true;
            textDetail.Name = "textDetail";
            textDetail.Size = new Size(478, 199);
            textDetail.TabIndex = 0;
            // 
            // groupDaftar
            // 
            groupDaftar.Controls.Add(listDaftar);
            groupDaftar.Location = new Point(433, 64);
            groupDaftar.Margin = new Padding(2);
            groupDaftar.Name = "groupDaftar";
            groupDaftar.Padding = new Padding(2);
            groupDaftar.Size = new Size(500, 229);
            groupDaftar.TabIndex = 14;
            groupDaftar.TabStop = false;
            groupDaftar.Text = "Daftar Pengaduan";
            groupDaftar.Location = new Point(430, 40);
            groupDaftar.Size = new Size(500, 250);

            listDaftar.Location = new Point(10, 25);
            listDaftar.Size = new Size(480, 210);
            listDaftar.View = View.Details;
            listDaftar.FullRowSelect = true;
            listDaftar.HideSelection = false;
            listDaftar.MultiSelect = false;
            listDaftar.SelectedIndexChanged += listDaftar_SelectedIndexChanged;

            columnNO.Text = "No";
            columnNO.Width = 40;
            columnTanggal.Text = "Tanggal";
            columnTanggal.Width = 110;
            columnKategori.Text = "Kategori";
            columnKategori.Width = 140;
            columnJudul.Text = "Judul";
            columnJudul.TextAlign = HorizontalAlignment.Center;
            columnJudul.Width = 180;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(942, 555);
            Controls.Add(groupDaftar);
            Controls.Add(groupDetail);
            MainMenuStrip = menuStrip1;
            Text = "Aplikasi Pengaduan Masyarakat";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupForm.ResumeLayout(false);
            groupForm.PerformLayout();
            groupDaftar.ResumeLayout(false);
            groupDetail.ResumeLayout(false);
            groupDetail.PerformLayout();
            groupDaftar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem buatPengaduanToolStripMenuItem;
        private ToolStripMenuItem tentangToolStripMenuItem;
        private ToolStripMenuItem pengaduanToolStripMenuItem;

        private GroupBox groupForm;
        private TextBox textNama;
        private TextBox textNik;
        private ComboBox comboKategori;
        private DateTimePicker dateTimePicker1;
        private TextBox textLokasi;
        private TextBox textJudul;
        private RichTextBox rtbDeskripsi;
        private Button buttonFoto;
        private PictureBox pictureBoxFoto;
        private Button buttonKirim;
        private Button buttonReset;
        private Button buttonKirim;
        private GroupBox groupDetail;
        private TextBox textDetail;
        private GroupBox groupDaftar;
        private ListView listDaftar;
        private ColumnHeader columnNO;
        private ColumnHeader columnTanggal;
        private ColumnHeader columnKategori;
        private ColumnHeader columnJudul;
    }
}
