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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gridview to = new Gridview();
            to.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Binding_Nav to = new Binding_Nav();
            to.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 to = new Form1();
            to.Show();
        }
    }
}
