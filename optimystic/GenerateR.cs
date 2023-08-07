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
    public partial class GenerateR : Form
    {
        public GenerateR()
        {
            InitializeComponent();

        } 
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            ga_txt.Text = Buyer.val1;
            FA_txt.Text = Buyer.val2;
            MA_txt.Text = Buyer.val3;
            LA_txt.Text = Buyer.val4;
            
        }

        private void GenerateR_Load(object sender, EventArgs e)
        {
            ga_txt.Text = Buyer.val1;
            FA_txt.Text = Buyer.val2;
            MA_txt.Text = Buyer.val3;
            LA_txt.Text = Buyer.val4;
            id_txt.Text = Buyer.val5;
        }

        private void ga_txt_TextChanged(object sender, EventArgs e)
        {
            string conString = "datasource=127.0.0.1;port=3306;username=root;password=khadija";
            string Query = "Select price from optimystic.products where SrNo='" + Buyer.val1 + "';";
            MySqlConnection conDataBase = new MySqlConnection(conString);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            


            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string gsr = myReader.GetString("price").ToString();
                    label8.Text = gsr;
                    
                }


                conDataBase.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
