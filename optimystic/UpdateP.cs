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
    public partial class UpdateP : Form
    {
        public UpdateP()
        {
            InitializeComponent();
            FillCombo();
        }

        void FillCombo()
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.patients";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string sID= myReader.GetString("patientID").ToString();

                    comboBox2.Items.Add(sID);
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
            string Query = "update optimystic.patients set patientID='" + this.PID_txt.Text + "',pName='" + this.Pname_txt.Text + "',address='" + this.pad_txt.Text + "',phoneNo='" + this.phone_txt.Text + "',docName='" + dcnic_txt.Text + "',leftCYL='" + this.left1_txt.Text + "',rightCYL='" + this.right1_txt.Text + "',addition='" + this.add_txt.Text + "',leftSPH='" + this.left2_txt.Text + "',rightSPH='" + this.right2_txt.Text + "'where PatientId='" + this.PID_txt.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Updated");
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
            this.Hide();
            recOp rp = new recOp();
            rp.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.patients where PatientID='" + comboBox2.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {

                    string sID = myReader.GetString("patientID").ToString();
                    string sname = myReader.GetString("pname");
                    string sadd = myReader.GetString("address");
                    string pno = myReader.GetString("phoneNo");
                    string dname = myReader.GetString("docName");
                    string lcyl = myReader.GetDouble("LeftCYL").ToString();
                    string rcyl = myReader.GetDouble("rightCYL").ToString();
                    string add = myReader.GetDouble("addition").ToString();
                    string lsph = myReader.GetDouble("leftSPH").ToString();
                    string rsph = myReader.GetDouble("rightSPH").ToString();
                    PID_txt.Text = sID;
                    Pname_txt.Text = sname;
                    pad_txt.Text = sadd;
                    phone_txt.Text = pno;
                    dcnic_txt.Text = dname;
                    left1_txt.Text = lcyl;
                    right1_txt.Text = rcyl;
                    add_txt.Text = add;
                    left2_txt.Text = lsph;
                    right2_txt.Text = rsph;





                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateP_Load(object sender, EventArgs e)
        {

        }
    }
    }

