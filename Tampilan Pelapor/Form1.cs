using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Tampilan_Pelapor
{
    // ENUM KATEGORI
    public enum KategoriPengaduan
    {
        Kebersihan,
        Ketertiban,
        LayananPublik
    }

    public partial class Form1 : Form
    {
        private const int PANJANG_NIK = 16;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboKategori.DataSource = Enum.GetValues(typeof(KategoriPengaduan));
            listDaftar.BeginUpdate();

            listDaftar.View = View.Details;
            listDaftar.FullRowSelect = true;
            listDaftar.HideSelection = false;
            listDaftar.MultiSelect = false;

            listDaftar.Columns.Clear();
            listDaftar.Columns.Add("No", 40);
            listDaftar.Columns.Add("Tanggal", 110);
            listDaftar.Columns.Add("Kategori", 160);
            listDaftar.Columns.Add("Judul", 160);
            listDaftar.Columns.Add("NIK", 130);
            listDaftar.Columns.Add("Nama", 150);
            listDaftar.Columns.Add("Lokasi", 150);
            listDaftar.Columns.Add("Deskripsi", 260);

            listDaftar.EndUpdate();

            // DETAIL READ ONLY
            rtbDetail.ReadOnly = true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textNama.Clear();
            textNik.Clear();
            comboKategori.SelectedIndex = -1;
            textLokasi.Clear();
            textJudul.Clear();
            rtbDeskripsi.Clear();
            pictureBoxFoto.Image = null;
            MessageBox.Show("Reset semua data");

        }

        private void listDaftar_SelectedIndexChanged(object sender, EventArgs e)
        {
            listDaftar.Columns.Add("No", 50);
            listDaftar.Columns.Add("Tanggal", 100);
            listDaftar.Columns.Add("Kategori", 120);
            listDaftar.Columns.Add("Judul", 200);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNama.Text) ||
                string.IsNullOrWhiteSpace(textNik.Text) ||
                string.IsNullOrWhiteSpace(textJudul.Text))
            {
                MessageBox.Show("NIK, Nama, dan Judul wajib diisi.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textNik.Text, "^[0-9]+$"))
            {
                MessageBox.Show("NIK hanya boleh berisi angka.");
                return;
            }

 
            if (textNik.Text.Length != 16)
            {
                MessageBox.Show("NIK harus 16 digit.");
                return;
            }

            KategoriPengaduan kategori =
                (KategoriPengaduan)comboKategori.SelectedItem;

            int idx = listDaftar.Items.Count + 1;

            var item = new ListViewItem(new[]
            {
                idx.ToString(),
                dateTimePicker1.Value.ToShortDateString(),
                comboKategori.Text,
                textJudul.Text
            });

            listDaftar.Items.Add(item);

            MessageBox.Show("Pengaduan berhasil ditambahkan.");
            buttonReset.PerformClick();
        }

        private void listDaftar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDaftar.SelectedItems.Count == 0)
            {
                rtbDetail.Clear();
                pictureBoxDetailFoto.Image = null;
                return;
            }

            ListViewItem item = listDaftar.SelectedItems[0];

            rtbDetail.Text =
                $"--- DETAIL PENGADUAN ---\n" +
                $"No Pengaduan : {item.SubItems[0].Text}\n" +
                $"Tanggal      : {item.SubItems[1].Text}\n" +
                $"Kategori     : {item.SubItems[2].Text}\n" +
                $"Judul        : {item.SubItems[3].Text}\n" +
                $"NIK          : {item.SubItems[4].Text}\n" +
                $"Nama         : {item.SubItems[5].Text}\n" +
                $"Lokasi       : {item.SubItems[6].Text}\n\n" +
                $"Deskripsi:\n{item.SubItems[7].Text}\n" +
                $"------------------------";
            string imagePath = item.Tag as string;

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    pictureBoxDetailFoto.Image = Image.FromStream(fs);
                }
            }
            else
            {
                pictureBoxDetailFoto.Image = null;
            }
        }

        private void buttonFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.png"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(dlg.FileName);
                pictureBoxFoto.Tag = dlg.FileName;
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Home");
        }

        private void buatPengaduanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Buat Pengaduan");
        }

        private void tentangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Aplikasi Pengaduan Masyarakat\n\n" +
                "BINTANG TRIADMAJA\n" +
                "NEVADA PRIDHO\n" +
                "RENI YUNIARTI PUTRI\n" +
                "RAFLI ABDUL BAY HAQQY\n" +
                "PRIMUANDY LEOKOY");
        }

        private void pengaduanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Helpdesk: +62 81234567890");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBoxDetailFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
