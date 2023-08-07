using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace optimystic
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
            myDataAdapter.SelectCommand = new MySqlCommand("Select * optimystic.orders;", myConn);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);

            myConn.Open();
            DataSet ds = new DataSet();
            this.Hide();
            welcome w = new welcome();
            w.ShowDialog();
                
        }
    }
}
