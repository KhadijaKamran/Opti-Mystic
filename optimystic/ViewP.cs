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
    public partial class ViewP : Form
    {
        public ViewP()
        {
            InitializeComponent();
            loadtable();
        }

        void loadtable()
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            
            MySqlConnection conDataBase = new MySqlConnection(conString);
            string Query = ("select * from optimystic.patients;");
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);


            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdatset = new DataTable();
                sda.Fill(dbdatset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdatset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdatset);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            recOp rp = new recOp();
            rp.ShowDialog();
        }
    }
}
