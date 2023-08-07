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
    public partial class buyerD : Form
    {
        public buyerD()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buyer b = new Buyer();
            b.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "insert into optimystic.orders(oType,orderDate,buyerName,address,phoneNo)values ('"  + this.T_txt.Text + "','" + this.A_txt.Text + "','" + this.N_txt.Text + "','" + ad_txt.Text + "','" + this.Phone_txt.Text +  "');";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myReader.Read()) { }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            recOp ro = new recOp();
            ro.ShowDialog();
        }
    }
}
