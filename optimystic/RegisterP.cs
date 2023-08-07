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
    public partial class RegisterP : Form
    {
        public RegisterP()
        {
            InitializeComponent();
            FillCombo();
        }
        void FillCombo()
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.doctors";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                
                while (myReader.Read()) {
                    string sname = myReader.GetString("docName");
    
                        comboBox1.Items.Add(sname);
                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

                string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query="insert into optimystic.patients(PatientId,pName,address,phoneNo,docName,leftCYL,rightCYL,addition,leftSPH,rightSPH)values ('"+this.PID_txt.Text+"','"+this.Pname_txt.Text+"','"+this.pad_txt.Text+"','"+this.phone_txt.Text+"','"+dcnic_txt.Text+"','"+this.left1_txt.Text+"','" + this.right1_txt.Text+"','" + this.add_txt.Text+"','" + this.left2_txt.Text+"','" + this.right2_txt.Text + "');";
                MySqlConnection conDataBase = new MySqlConnection(conString);
                MySqlCommand cmdDatabase = new MySqlCommand(Query,conDataBase);
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.doctors where docName='" + comboBox1.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                
              while (myReader.Read())
              {
                    string sname = myReader.GetString("docName");
                    dcnic_txt.Text = sname;
                    
              }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            recOp rp = new recOp();
            rp.ShowDialog();
        }
    }
}
