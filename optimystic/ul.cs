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
    public partial class ul : Form
    {
        public ul()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            recOp r = new recOp();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "insert into optimystic.prodcuts(SrNo,Price)values ('" + this.Sr_txt.Text + "','" + this.p_txt.Text + "');";
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

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "insert into optimystic.contactlenses(clSrNo,clType,color)values ('" + this.Sr_txt.Text + "','" + this.c_txt.Text + this.cat_txt.Text + "');";
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

        private void p_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sr_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cat_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
