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
    public partial class adminO : Form
    {
        public adminO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addR a = new addR();
            a.ShowDialog();
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            recOp a = new recOp();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewD vd = new ViewD();
            vd.ShowDialog();
        }

        private void adminO_FormClosing(object sender, FormClosingEventArgs e)
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

        private void adminO_Load(object sender, EventArgs e)
        {

        }
    }
}
