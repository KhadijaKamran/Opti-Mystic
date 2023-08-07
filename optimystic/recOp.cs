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
    public partial class recOp : Form
    {
        public recOp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterP rp = new RegisterP();
            rp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
           UpdateP up = new UpdateP();
            up.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewP vp = new ViewP();
            vp.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            this.Hide();
            buyerD b = new buyerD();
            b.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterP r = new RegisterP();
            r.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.ShowDialog();

        }

        private void recOp_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?",
                "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void recOp_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            update u = new update();
            u.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProducts vp = new ViewProducts();
            vp.ShowDialog();
        }
    }
}
