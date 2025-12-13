namespace Tampilan_Pelapor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            buatPengaduanToolStripMenuItem = new ToolStripMenuItem();
            tentangToolStripMenuItem = new ToolStripMenuItem();
            pengaduanToolStripMenuItem = new ToolStripMenuItem();
            groupForm = new GroupBox();
            genderLabel = new Label();
            buttonReset = new Button();
            buttonKirim = new Button();
            pictureBoxFoto = new PictureBox();
            buttonFoto = new Button();
            rtbDeskripsi = new RichTextBox();
            textJudul = new TextBox();
            textLokasi = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboKategori = new ComboBox();
            textNik = new TextBox();
            textNama = new TextBox();
            labelDeskripsi = new Label();
            labelJudul = new Label();
            labelLokasi = new Label();
            labelTanggal = new Label();
            labelKategori = new Label();
            labelNik = new Label();
            labelNama = new Label();
            groupDetail = new GroupBox();
            pictureBoxDetailFoto = new PictureBox();
            detailFotoAduanLabel = new Label();
            rtbDetail = new RichTextBox();
            labelTotalAduan = new Label();
            groupDaftar = new GroupBox();
            listDaftar = new ListView();
            columnNO = new ColumnHeader();
            columnTanggal = new ColumnHeader();
            columnKategori = new ColumnHeader();
            columnJudul = new ColumnHeader();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            menuStrip1.SuspendLayout();
            groupForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            groupDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDetailFoto).BeginInit();
            groupDaftar.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, buatPengaduanToolStripMenuItem, tentangToolStripMenuItem, pengaduanToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(942, 33);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(76, 29);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // buatPengaduanToolStripMenuItem
            // 
            buatPengaduanToolStripMenuItem.Name = "buatPengaduanToolStripMenuItem";
            buatPengaduanToolStripMenuItem.Size = new Size(164, 29);
            buatPengaduanToolStripMenuItem.Text = "Buat Pengaduan";
            buatPengaduanToolStripMenuItem.Click += buatPengaduanToolStripMenuItem_Click;
            // 
            // tentangToolStripMenuItem
            // 
            tentangToolStripMenuItem.Name = "tentangToolStripMenuItem";
            tentangToolStripMenuItem.Size = new Size(93, 29);
            tentangToolStripMenuItem.Text = "Tentang";
            tentangToolStripMenuItem.Click += tentangToolStripMenuItem_Click;
            // 
            // pengaduanToolStripMenuItem
            // 
            pengaduanToolStripMenuItem.Name = "pengaduanToolStripMenuItem";
            pengaduanToolStripMenuItem.Size = new Size(96, 29);
            pengaduanToolStripMenuItem.Text = "Bantuan";
            pengaduanToolStripMenuItem.Click += pengaduanToolStripMenuItem_Click;
            // 
            // groupForm
            // 
            groupForm.Controls.Add(femaleRadioButton);
            groupForm.Controls.Add(maleRadioButton);
            groupForm.Controls.Add(genderLabel);
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
            groupForm.Size = new Size(406, 571);
            groupForm.TabIndex = 0;
            groupForm.TabStop = false;
            groupForm.Text = "Buat Pengaduan";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(19, 67);
            genderLabel.Margin = new Padding(2, 0, 2, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(66, 23);
            genderLabel.TabIndex = 18;
            genderLabel.Text = "Gender";
            genderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.LightGray;
            buttonReset.Location = new Point(130, 462);
            buttonReset.Margin = new Padding(2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(90, 27);
            buttonReset.TabIndex = 17;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonKirim
            // 
            buttonKirim.BackColor = Color.DodgerBlue;
            buttonKirim.Location = new Point(19, 462);
            buttonKirim.Margin = new Padding(2);
            buttonKirim.Name = "buttonKirim";
            buttonKirim.Size = new Size(90, 27);
            buttonKirim.TabIndex = 16;
            buttonKirim.Text = "Kirim";
            buttonKirim.UseVisualStyleBackColor = false;
            buttonKirim.Click += buttonKirim_Click;
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.BackColor = SystemColors.ButtonHighlight;
            pictureBoxFoto.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFoto.Location = new Point(252, 394);
            pictureBoxFoto.Margin = new Padding(2);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(128, 92);
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFoto.TabIndex = 15;
            pictureBoxFoto.TabStop = false;
            pictureBoxFoto.Click += pictureBoxFoto_Click;
            // 
            // buttonFoto
            // 
            buttonFoto.BackColor = Color.LightGray;
            buttonFoto.Location = new Point(108, 395);
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
            rtbDeskripsi.Location = new Point(108, 307);
            rtbDeskripsi.Margin = new Padding(2);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(273, 68);
            rtbDeskripsi.TabIndex = 13;
            rtbDeskripsi.Text = "";
            // 
            // textJudul
            // 
            textJudul.Location = new Point(109, 266);
            textJudul.Margin = new Padding(2);
            textJudul.Name = "textJudul";
            textJudul.Size = new Size(272, 30);
            textJudul.TabIndex = 12;
            // 
            // textLokasi
            // 
            textLokasi.Location = new Point(109, 226);
            textLokasi.Margin = new Padding(2);
            textLokasi.Name = "textLokasi";
            textLokasi.Size = new Size(272, 30);
            textLokasi.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(109, 184);
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
            comboKategori.Location = new Point(109, 141);
            comboKategori.Margin = new Padding(2);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(272, 31);
            comboKategori.TabIndex = 9;
            // 
            // textNik
            // 
            textNik.Location = new Point(109, 99);
            textNik.Margin = new Padding(2);
            textNik.Name = "textNik";
            textNik.Size = new Size(272, 30);
            textNik.TabIndex = 8;
            // 
            // textNama
            // 
            textNama.Location = new Point(109, 26);
            textNama.Margin = new Padding(2);
            textNama.Name = "textNama";
            textNama.Size = new Size(272, 30);
            textNama.TabIndex = 7;
            // 
            // labelDeskripsi
            // 
            labelDeskripsi.AutoSize = true;
            labelDeskripsi.Location = new Point(19, 307);
            labelDeskripsi.Margin = new Padding(2, 0, 2, 0);
            labelDeskripsi.Name = "labelDeskripsi";
            labelDeskripsi.Size = new Size(77, 23);
            labelDeskripsi.TabIndex = 6;
            labelDeskripsi.Text = "Deskripsi";
            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.Location = new Point(19, 266);
            labelJudul.Margin = new Padding(2, 0, 2, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(50, 23);
            labelJudul.TabIndex = 5;
            labelJudul.Text = "Judul";
            // 
            // labelLokasi
            // 
            labelLokasi.AutoSize = true;
            labelLokasi.Location = new Point(19, 226);
            labelLokasi.Margin = new Padding(2, 0, 2, 0);
            labelLokasi.Name = "labelLokasi";
            labelLokasi.Size = new Size(56, 23);
            labelLokasi.TabIndex = 4;
            labelLokasi.Text = "Lokasi";
            // 
            // labelTanggal
            // 
            labelTanggal.AutoSize = true;
            labelTanggal.Location = new Point(19, 184);
            labelTanggal.Margin = new Padding(2, 0, 2, 0);
            labelTanggal.Name = "labelTanggal";
            labelTanggal.Size = new Size(69, 23);
            labelTanggal.TabIndex = 3;
            labelTanggal.Text = "Tanggal";
            // 
            // labelKategori
            // 
            labelKategori.AutoSize = true;
            labelKategori.Location = new Point(19, 141);
            labelKategori.Margin = new Padding(2, 0, 2, 0);
            labelKategori.Name = "labelKategori";
            labelKategori.Size = new Size(74, 23);
            labelKategori.TabIndex = 2;
            labelKategori.Text = "Kategori";
            // 
            // labelNik
            // 
            labelNik.AutoSize = true;
            labelNik.Location = new Point(19, 99);
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
            groupDetail.Controls.Add(pictureBoxDetailFoto);
            groupDetail.Controls.Add(detailFotoAduanLabel);
            groupDetail.Controls.Add(rtbDetail);
            groupDetail.Location = new Point(433, 314);
            groupDetail.Margin = new Padding(2);
            groupDetail.Name = "groupDetail";
            groupDetail.Padding = new Padding(2);
            groupDetail.Size = new Size(500, 321);
            groupDetail.TabIndex = 13;
            groupDetail.TabStop = false;
            groupDetail.Text = "Detail Pengaduan";
            // 
            // pictureBoxDetailFoto
            // 
            pictureBoxDetailFoto.BackColor = SystemColors.ButtonHighlight;
            pictureBoxDetailFoto.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxDetailFoto.Location = new Point(98, 217);
            pictureBoxDetailFoto.Margin = new Padding(2);
            pictureBoxDetailFoto.Name = "pictureBoxDetailFoto";
            pictureBoxDetailFoto.Size = new Size(128, 92);
            pictureBoxDetailFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDetailFoto.TabIndex = 18;
            pictureBoxDetailFoto.TabStop = false;
            // 
            // detailFotoAduanLabel
            // 
            detailFotoAduanLabel.AutoSize = true;
            detailFotoAduanLabel.Location = new Point(10, 217);
            detailFotoAduanLabel.Margin = new Padding(2, 0, 2, 0);
            detailFotoAduanLabel.Name = "detailFotoAduanLabel";
            detailFotoAduanLabel.Size = new Size(86, 20);
            detailFotoAduanLabel.TabIndex = 18;
            detailFotoAduanLabel.Text = "Foto Aduan";
            // 
            // rtbDetail
            // 
            rtbDetail.Location = new Point(10, 25);
            rtbDetail.Name = "rtbDetail";
            rtbDetail.Size = new Size(478, 188);
            rtbDetail.TabIndex = 0;
            rtbDetail.Text = "";
            // 
            // labelTotalAduan
            // 
            labelTotalAduan.AutoSize = true;
            labelTotalAduan.Location = new Point(10, 216);
            labelTotalAduan.Name = "labelTotalAduan";
            labelTotalAduan.Size = new Size(104, 20);
            labelTotalAduan.TabIndex = 15;
            labelTotalAduan.Text = "Total Aduan: 0";
            // 
            // groupDaftar
            // 
            groupDaftar.Controls.Add(listDaftar);
            groupDaftar.Controls.Add(labelTotalAduan);
            groupDaftar.Location = new Point(433, 64);
            groupDaftar.Margin = new Padding(2);
            groupDaftar.Name = "groupDaftar";
            groupDaftar.Padding = new Padding(2);
            groupDaftar.Size = new Size(500, 247);
            groupDaftar.TabIndex = 14;
            groupDaftar.TabStop = false;
            groupDaftar.Text = "Daftar Pengaduan";
            // 
            // listDaftar
            // 
            listDaftar.Columns.AddRange(new ColumnHeader[] { columnNO, columnTanggal, columnKategori, columnJudul });
            listDaftar.Location = new Point(10, 26);
            listDaftar.Margin = new Padding(2);
            listDaftar.Name = "listDaftar";
            listDaftar.Size = new Size(478, 175);
            listDaftar.TabIndex = 0;
            listDaftar.UseCompatibleStateImageBehavior = false;
            listDaftar.View = View.Details;
            listDaftar.SelectedIndexChanged += listDaftar_SelectedIndexChanged;
            // 
            // columnNO
            // 
            columnNO.Text = "NO";
            columnNO.Width = 50;
            // 
            // columnTanggal
            // 
            columnTanggal.Text = "Tanggal";
            columnTanggal.TextAlign = HorizontalAlignment.Center;
            columnTanggal.Width = 180;
            // 
            // columnKategori
            // 
            columnKategori.Text = "Kategori";
            columnKategori.TextAlign = HorizontalAlignment.Center;
            columnKategori.Width = 180;
            // 
            // columnJudul
            // 
            columnJudul.Text = "Judul";
            columnJudul.TextAlign = HorizontalAlignment.Center;
            columnJudul.Width = 180;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(108, 67);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(92, 27);
            maleRadioButton.TabIndex = 21;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Laki-laki";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(252, 67);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(118, 27);
            femaleRadioButton.TabIndex = 22;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Perempuan";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(942, 646);
            Controls.Add(groupDaftar);
            Controls.Add(groupDetail);
            Controls.Add(groupForm);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikasi Pengaduan Masyarakat";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupForm.ResumeLayout(false);
            groupForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            groupDetail.ResumeLayout(false);
            groupDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDetailFoto).EndInit();
            groupDaftar.ResumeLayout(false);
            groupDaftar.PerformLayout();
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
        private Label labelNama;
        private Label labelNik;
        private Label labelDeskripsi;
        private Label labelJudul;
        private Label labelLokasi;
        private Label labelTanggal;
        private Label labelKategori;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboKategori;
        private TextBox textNik;
        private TextBox textNama;
        private RichTextBox rtbDeskripsi;
        private TextBox textJudul;
        private TextBox textLokasi;
        private PictureBox pictureBoxFoto;
        private Button buttonFoto;
        private Button buttonReset;
        private Button buttonKirim;
        private GroupBox groupDetail;
        private GroupBox groupDaftar;
        private ListView listDaftar;
        private ColumnHeader columnNO;
        private ColumnHeader columnTanggal;
        private ColumnHeader columnKategori;
        private ColumnHeader columnJudul;
        private RichTextBox rtbDetail;
        private Label detailFotoAduanLabel;
        private PictureBox pictureBoxDetailFoto;
        private Label labelTotalAduan;
        private Label genderLabel;
        private RadioButton femaleRadioButton;
        private RadioButton maleRadioButton;
    }
}
