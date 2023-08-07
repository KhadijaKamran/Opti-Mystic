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
    public partial class Buyer : Form
    {
        public static string val1="";
        public static string val2="";
        public static string val3="";
        public static string val4="";
        public static string val5="";
        public Buyer()
        {
            InitializeComponent();
            
            FillCombo();
            FillCombo2();
            FillCombo3();
            FillCombo4();
            
            FillCombo6();
            FillCombo7();
            FillCombo8();
            FillCombo9();
            FillCombo10();
            FillCombo11();
            
        }

        void FillCombo11()
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.orders";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string ono = myReader.GetString("orderNo").ToString(); ;

                    comboBox6.Items.Add(ono);
                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            void FillCombo()
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select distinct(size) from optimystic.frames";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string Fsize = myReader.GetString("size");

                    comboBox2.Items.Add(Fsize);
                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillCombo2()
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select distinct(fType) from optimystic.frames";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string ftype = myReader.GetString("fType");

                    comboBox3.Items.Add(ftype);
                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillCombo3()
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select distinct(color) from optimystic.frames";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string fc = myReader.GetString("color");

                    comboBox4.Items.Add(fc);
                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillCombo4()
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select distinct (mName) from optimystic.medicine";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string mname = myReader.GetString("mName");

                    comboBox7.Items.Add(mname);
                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       


            

        void FillCombo6()
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select distinct (clType) from optimystic.contactlenses";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string ct = myReader.GetString("clType");

                    comboBox1.Items.Add(ct);
                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillCombo7()
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select distinct(color) from optimystic.contactlenses";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string cc= myReader.GetString("color");

                    comboBox5.Items.Add(cc);
                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void FillCombo8()
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select distinct(Quality) from optimystic.glasses";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string gq = myReader.GetString("Quality");

                    comboBox10.Items.Add(gq);
                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void FillCombo9()
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select distinct(color) from optimystic.glasses";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string gc = myReader.GetString("color");

                    comboBox9.Items.Add(gc);
                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void FillCombo10()
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select distinct(Category) from optimystic.glasses";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string gcat = myReader.GetString("Category");

                    comboBox8.Items.Add(gcat);
                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "insert into optimystic.productorders(orderNo,productSrNo) values ('" + this.ID_txt.Text + "','" + this.F_Sr.Text + "');";
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        public void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.glasses where Category='" + comboBox8.Text + "'and color='"+comboBox9.Text+"'and Quality='"+comboBox10.Text+"';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            // GenerateR gr = new GenerateR(gSr_txt.Text);
            //gr.ShowDialog();
            val1 = gSr_txt.Text;
           

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string gsr = myReader.GetString("gSrNo").ToString();
                    gSr_txt.Text = gsr;
                    string Gcat = myReader.GetString("Category");
                    Gcat_txt.Text = Gcat;
                }


                conDataBase.Close();
            }
            

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.frames where color='" + comboBox4.Text + "'and fType='" + comboBox3.Text + "'and size='" + comboBox2.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            val2 = F_Sr.Text;
            
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string fSr = myReader.GetString("fSrNo").ToString() ;
                    F_Sr.Text = fSr;
                    string Fc = myReader.GetString("color");
                    fc_txt.Text = Fc;

                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.contactlenses where color='" + comboBox5.Text + "'and clType='" + comboBox1.Text +  "';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            val4 = L_Sr.Text;
            
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string Lsr = myReader.GetString("clSrNo").ToString();
                    L_Sr.Text = Lsr;
                    string Lc = myReader.GetString("color");
                    Lc_txt.Text = Lc;
                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.contactlenses where clType='" + comboBox1.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {

                    string clt = myReader.GetString("clType");
                    lt_txt.Text = clt;

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.medicine where mName='" + comboBox7.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            val3 = M_Sr.Text;
            
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string mSr = myReader.GetString("mSrNo").ToString();
                    M_Sr.Text = mSr;
                    string Mn = myReader.GetString("mName");
                    Mn_txt.Text = Mn;
                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.glasses where Quality='" + comboBox10.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {

                    string Gq = myReader.GetString("Quality");
                   Gq_txt.Text = Gq;
                   





                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.frames where size='" + comboBox2.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {

                    string Fs = myReader.GetString("size");
                    Fs_txt.Text = Fs;






                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.frames where fType='" + comboBox3.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {

                    string Ft = myReader.GetString("fType");
                    ft_txt.Text = Ft;

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.glasses where color='" + comboBox9.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {

                    string Gc = myReader.GetString("color");
                    Gc_txt.Text = Gc;

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void M_Sr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "insert into optimystic.productorders(orderNo,productSrNo)values ('" + this.ID_txt.Text + "','" + this.gSr_txt.Text + "');";
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
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "insert into optimystic.productorders(orderNo,productSrNo) values ('" + this.ID_txt.Text + "','" + this.M_Sr.Text + "');";
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
            string Query = "insert into optimystic.productorders(orderNo,productSrNo) values ('" + this.ID_txt.Text + "','" + this.L_Sr.Text + "');";
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

        private void D_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buyer_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select sum(price) from optimystic.productorders join optimystic.products on productSrNo=SrNo where orderNo='" + ID_txt.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {

                    string Ft = myReader.GetString("sum(price)");
                    sum_txt.Text = Ft;
                    //MessageBox.Show("your total bill is ",sum(price));

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select * from optimystic.orders where orderNo='" + comboBox6.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            val5 = ID_txt.Text;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {

                    string ono = myReader.GetString("orderNo").ToString(); ;
                    ID_txt.Text = ono;

                }
            }
           

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "insert into optimystic.orderPayment(orderNo,TotalPrice)values ('" + this.ID_txt.Text + "','" + this.sum_txt.Text +  "');";
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            recOp ro = new recOp();
            ro.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            buyerD bd = new buyerD();
            bd.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenerateR gr = new GenerateR();
            gr.ShowDialog();
        }

        private void M_Sr_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

