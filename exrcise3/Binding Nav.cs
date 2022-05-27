using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exrcise3
{
    public partial class Binding_Nav : Form
    {
        public Binding_Nav()
        {
            InitializeComponent();
        }

        private void Binding_Nav_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu to = new Menu();
            to.Show();
        }
    }
}
