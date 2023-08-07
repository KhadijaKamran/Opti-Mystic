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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("Select * optimystic.orders;", myConn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                MySqlCommand SelectCommand = new MySqlCommand("select * from optimystic.login where RName='" + this.Name_txt.Text + "' and Rpass='" + this.Password_txt.Text + "';", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count += 1;

                }
                if (count == 1)
                {
                    MessageBox.Show("username and password is correct");
                    this.Hide();
                    recOp RO = new recOp();
                    RO.ShowDialog();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate username and password");
                }
                else
                    MessageBox.Show("Username and password is not correct");
                myConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "seecs" && textBox4.Text == "123")
            {
                MessageBox.Show("correct entry");
                this.Hide();
                adminO r = new adminO();
                r.ShowDialog();


            }
            else
                MessageBox.Show("Enter again");
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void Name_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
