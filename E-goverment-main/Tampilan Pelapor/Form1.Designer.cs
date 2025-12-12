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
            aplikasiIniDisusunOlehToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem12 = new ToolStripMenuItem();
            pengaduanToolStripMenuItem = new ToolStripMenuItem();
            helpdeskToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            groupForm = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
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
            textDetail = new TextBox();
            groupDaftar = new GroupBox();
            listDaftar = new ListView();
            columnNO = new ColumnHeader();
            columnTanggal = new ColumnHeader();
            columnKategori = new ColumnHeader();
            columnJudul = new ColumnHeader();
            menuStrip1.SuspendLayout();
            groupForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            groupDetail.SuspendLayout();
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
            menuStrip1.Size = new Size(1238, 33);
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
            tentangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aplikasiIniDisusunOlehToolStripMenuItem });
            tentangToolStripMenuItem.Name = "tentangToolStripMenuItem";
            tentangToolStripMenuItem.Size = new Size(93, 29);
            tentangToolStripMenuItem.Text = "Tentang";
            // 
            // aplikasiIniDisusunOlehToolStripMenuItem
            // 
            aplikasiIniDisusunOlehToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7 });
            aplikasiIniDisusunOlehToolStripMenuItem.Name = "aplikasiIniDisusunOlehToolStripMenuItem";
            aplikasiIniDisusunOlehToolStripMenuItem.Size = new Size(301, 30);
            aplikasiIniDisusunOlehToolStripMenuItem.Text = "Aplikasi ini disusun oleh";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem8 });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(314, 30);
            toolStripMenuItem3.Text = "RAFLI ABDUL BAY HAQQY";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(218, 30);
            toolStripMenuItem8.Text = "250401010113";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem9 });
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(314, 30);
            toolStripMenuItem4.Text = "BINTANG TRIADMAJA";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(218, 30);
            toolStripMenuItem9.Text = "250401010075";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem10 });
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(314, 30);
            toolStripMenuItem5.Text = "NEVADA PRIDHO";
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(218, 30);
            toolStripMenuItem10.Text = "250401010223";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem11 });
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(314, 30);
            toolStripMenuItem6.Text = "RENI YUNIARTI PUTRI";
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(218, 30);
            toolStripMenuItem11.Text = "250401070202";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem12 });
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(314, 30);
            toolStripMenuItem7.Text = "PRIMUANDY LEOKOY";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // toolStripMenuItem12
            // 
            toolStripMenuItem12.Name = "toolStripMenuItem12";
            toolStripMenuItem12.Size = new Size(218, 30);
            toolStripMenuItem12.Text = "250401010209";
            // 
            // pengaduanToolStripMenuItem
            // 
            pengaduanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpdeskToolStripMenuItem });
            pengaduanToolStripMenuItem.Name = "pengaduanToolStripMenuItem";
            pengaduanToolStripMenuItem.Size = new Size(96, 29);
            pengaduanToolStripMenuItem.Text = "Bantuan";
            // 
            // helpdeskToolStripMenuItem
            // 
            helpdeskToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            helpdeskToolStripMenuItem.Name = "helpdeskToolStripMenuItem";
            helpdeskToolStripMenuItem.Size = new Size(175, 30);
            helpdeskToolStripMenuItem.Text = "Helpdesk";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(246, 30);
            toolStripMenuItem2.Text = "+62 81029384716";
            // 
            // groupForm
            // 
            groupForm.Controls.Add(checkBox2);
            groupForm.Controls.Add(checkBox1);
            groupForm.Controls.Add(label1);
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
            groupForm.Size = new Size(406, 646);
            groupForm.TabIndex = 0;
            groupForm.TabStop = false;
            groupForm.Text = "Buat Pengaduan";
            groupForm.Enter += groupForm_Enter;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(263, 117);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(119, 27);
            checkBox2.TabIndex = 20;
            checkBox2.Text = "Perempuan";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(109, 117);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 27);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Laki - Laki";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 100);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 46);
            label1.TabIndex = 18;
            label1.Text = "Jenis\r\nKelamin\r\n";
            label1.Click += label1_Click_1;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.LightGray;
            buttonReset.Location = new Point(113, 556);
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
            buttonKirim.Location = new Point(19, 556);
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
            pictureBoxFoto.Location = new Point(157, 401);
            pictureBoxFoto.Margin = new Padding(2);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(221, 132);
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFoto.TabIndex = 15;
            pictureBoxFoto.TabStop = false;
            pictureBoxFoto.Click += pictureBoxFoto_Click;
            // 
            // buttonFoto
            // 
            buttonFoto.BackColor = Color.LightGray;
            buttonFoto.Location = new Point(19, 506);
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
            rtbDeskripsi.Location = new Point(109, 320);
            rtbDeskripsi.Margin = new Padding(2);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(273, 68);
            rtbDeskripsi.TabIndex = 13;
            rtbDeskripsi.Text = "";
            // 
            // textJudul
            // 
            textJudul.Location = new Point(109, 279);
            textJudul.Margin = new Padding(2);
            textJudul.Name = "textJudul";
            textJudul.Size = new Size(272, 30);
            textJudul.TabIndex = 12;
            // 
            // textLokasi
            // 
            textLokasi.Location = new Point(109, 240);
            textLokasi.Margin = new Padding(2);
            textLokasi.Name = "textLokasi";
            textLokasi.Size = new Size(272, 30);
            textLokasi.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(109, 197);
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
            comboKategori.Location = new Point(109, 154);
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
            labelDeskripsi.Location = new Point(16, 320);
            labelDeskripsi.Margin = new Padding(2, 0, 2, 0);
            labelDeskripsi.Name = "labelDeskripsi";
            labelDeskripsi.Size = new Size(77, 23);
            labelDeskripsi.TabIndex = 6;
            labelDeskripsi.Text = "Deskripsi";
            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.Location = new Point(25, 282);
            labelJudul.Margin = new Padding(2, 0, 2, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(50, 23);
            labelJudul.TabIndex = 5;
            labelJudul.Text = "Judul";
            // 
            // labelLokasi
            // 
            labelLokasi.AutoSize = true;
            labelLokasi.Location = new Point(19, 243);
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
            labelTanggal.Location = new Point(19, 201);
            labelTanggal.Margin = new Padding(2, 0, 2, 0);
            labelTanggal.Name = "labelTanggal";
            labelTanggal.Size = new Size(69, 23);
            labelTanggal.TabIndex = 3;
            labelTanggal.Text = "Tanggal";
            // 
            // labelKategori
            // 
            labelKategori.AutoSize = true;
            labelKategori.Location = new Point(19, 157);
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
            groupDetail.Size = new Size(780, 406);
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
            textDetail.Size = new Size(737, 356);
            textDetail.TabIndex = 0;
            // 
            // groupDaftar
            // 
            groupDaftar.Controls.Add(listDaftar);
            groupDaftar.Location = new Point(433, 64);
            groupDaftar.Margin = new Padding(2);
            groupDaftar.Name = "groupDaftar";
            groupDaftar.Padding = new Padding(2);
            groupDaftar.Size = new Size(780, 223);
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
            listDaftar.Size = new Size(737, 194);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1238, 741);
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
        private TextBox textDetail;
        private GroupBox groupDaftar;
        private ListView listDaftar;
        private ColumnHeader columnNO;
        private ColumnHeader columnTanggal;
        private ColumnHeader columnKategori;
        private ColumnHeader columnJudul;
        private ToolStripMenuItem aplikasiIniDisusunOlehToolStripMenuItem;
        private ToolStripMenuItem helpdeskToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private Label label1;
        private CheckBox checkBox1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private CheckBox checkBox2;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
    }
}
