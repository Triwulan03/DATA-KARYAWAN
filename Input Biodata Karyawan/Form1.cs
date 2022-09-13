using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Input_Biodata_Karyawan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "BIODATA KARYAWAN";
            this.BackColor = Color.AliceBlue;
            cmbJabatan.Items.Add("Direktur Personalia");
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtNama.Text);
            listBox1.Items.Add(txtTempat);
            listBox1.Items.Add(txtAgama);
            listBox1.Items.Add(txtNIK);
            listBox1.Items.Add(txtID);

            if (rb_pr.Checked == true)
                listBox1.Items.Add(rb_pr.Text);
            else if (rb_lk.Checked == true)
                listBox1.Items.Add(rb_lk.Text);
            listBox1.Items.Add(cmbJabatan.Text);
        }

        private void btnBersih_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtTempat.Text = "";
            txtAgama.Text = "";
            txtNIK.Text = "";
            txtID.Text = "";
            rb_pr.Checked = false;
            rb_lk.Checked = false;
            listBox1.Items.Clear();
            txtNama.Focus();
            txtTempat.Focus();
            txtAgama.Focus();
            txtNIK.Focus();
            txtID.Focus();
        
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
