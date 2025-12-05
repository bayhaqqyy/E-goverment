using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tampilan_Pelapor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLokasi_Click(object sender, EventArgs e)
        {

        }

        private void groupForm_Enter(object sender, EventArgs e)
        {

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
                string.IsNullOrWhiteSpace(textJudul.Text))
            {
                MessageBox.Show("Nama dan Judul wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Tambah ke daftar (mock)
            int idx = listDaftar.Items.Count + 1;
            var item = new ListViewItem(new[] {
                idx.ToString(),
                dateTimePicker1.Value.ToShortDateString(),
                comboKategori.Text,
                textJudul.Text
            });
            listDaftar.Items.Add(item);
            MessageBox.Show("Pengaduan ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonReset.PerformClick();
        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }

        private void buttonFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image|*.jpg;*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(dlg.FileName);
            }

        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda membuka menu Home");
        }

        private void buatPengaduanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda membuka menu Buat Pengaduan");
        }

        private void tentangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda membuka menu Tentang");
        }

        private void pengaduanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda membuka menu Bantuan");
        }
    }
}
