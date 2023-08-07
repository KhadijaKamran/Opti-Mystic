using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace optimystic
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            uf u = new uf();
            u.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ug u = new Ug();
            u.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ul u = new ul();
            u.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            um u = new um();
            u.ShowDialog();
                

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            recOp r = new recOp();
            r.ShowDialog();

        }
    }
}
