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
            labelNik = new Label();
            labelKategori = new Label();
            labelTanggal = new Label();
            labelLokasi = new Label();
            labelJudul = new Label();
            labelDeskripsi = new Label();

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

            // GROUP FORM
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

            buttonKirim.Text = "Kirim";
            buttonKirim.Location = new Point(20, 470);
            buttonKirim.Click += buttonKirim_Click;

            buttonReset.Text = "Reset";
            buttonReset.Location = new Point(120, 470);
            buttonReset.Click += buttonReset_Click;

            groupForm.Controls.AddRange(new Control[] {
                labelNama, textNama,
                labelNik, textNik,
                labelKategori, comboKategori,
                labelTanggal, dateTimePicker1,
                labelLokasi, textLokasi,
                labelJudul, textJudul,
                labelDeskripsi, rtbDeskripsi,
                buttonFoto, pictureBoxFoto,
                buttonKirim, buttonReset
            });

            // GROUP DAFTAR
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
            columnJudul.Width = 140;
            columnNik.Text = "NIK";
            columnNik.Width = 120;
            columnNama.Text = "Nama";
            columnNama.Width = 140;
            columnLokasi.Text = "Lokasi";
            columnLokasi.Width = 140;
            columnDeskripsi.Text = "Deskripsi";
            columnDeskripsi.Width = 200;

            listDaftar.Columns.AddRange(new ColumnHeader[] {
                columnNO,
                columnTanggal,
                columnKategori,
                columnJudul,
                columnNik,
                columnNama,
                columnLokasi,
                columnDeskripsi
            });

            groupDaftar.Controls.Add(listDaftar);

            // GROUP DETAIL
            groupDetail.Text = "Detail Pengaduan";
            groupDetail.Location = new Point(430, 300);
            groupDetail.Size = new Size(500, 320);

            rtbDetail.Location = new Point(10, 25);
            rtbDetail.Size = new Size(480, 200);

            detailFotoAduanLabel.Text = "Foto Aduan";
            detailFotoAduanLabel.Location = new Point(10, 235);

            pictureBoxDetailFoto.Location = new Point(100, 235);
            pictureBoxDetailFoto.Size = new Size(120, 90);
            pictureBoxDetailFoto.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxDetailFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDetailFoto.Click += pictureBoxDetailFoto_Click;

            groupDetail.Controls.Add(rtbDetail);
            groupDetail.Controls.Add(detailFotoAduanLabel);
            groupDetail.Controls.Add(pictureBoxDetailFoto);

            // FORM
            ClientSize = new Size(950, 640);
            Controls.Add(menuStrip1);
            Controls.Add(groupForm);
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDetailFoto).EndInit();
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

        private Label labelNama;
        private Label labelNik;
        private Label labelKategori;
        private Label labelTanggal;
        private Label labelLokasi;
        private Label labelJudul;
        private Label labelDeskripsi;

        private GroupBox groupDaftar;
        private ListView listDaftar;
        private ColumnHeader columnNO;
        private ColumnHeader columnTanggal;
        private ColumnHeader columnKategori;
        private ColumnHeader columnJudul;
        private ColumnHeader columnNik;
        private ColumnHeader columnNama;
        private ColumnHeader columnLokasi;
        private ColumnHeader columnDeskripsi;

        private GroupBox groupDetail;
        private RichTextBox rtbDetail;
        private PictureBox pictureBoxDetailFoto;
        private Label detailFotoAduanLabel;
    }
}
