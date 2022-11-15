using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

namespace PixisAirDBGroup2
{
    public partial class IBM : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataset;
        public IBM()
        {
            InitializeComponent();
        }

        private void IBM_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql;
            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu");
                sql = "SELECT * FROM AIRPLANE";
                adapter = new iDB2DataAdapter(sql, conn);

                dataset = new DataSet();
                adapter.Fill(dataset);

                listBox1.Items.Clear();
                foreach (DataRow pRow in dataset.Tables[0].Rows)
                    listBox1.Items.Add(pRow[0] + " " + pRow[1] + " " + pRow[2] + " " + pRow[3] + " " + pRow[4] + " " + pRow[5] + " " + pRow[6]
                         + " " + pRow[7] + " " + pRow[8] + " " + pRow[9] + " " + pRow[10] + " " + pRow[11] + " " + pRow[12]);
                conn.Close();

            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //*******************************************************
            //This function inserts a new record into BOAT_TYPE2
            //It uses a command object and parameters
            //*******************************************************
            String cmdText = "INSERT INTO AIRPLANE VALUES(@PLANENO, @MAXDIST, @FCLASS,@CCLASS,@PAVAIL,@MAINTMILES,@PLANEMODEL,@PMAKE,@APARCD,@APACTDT,@APIACTDT,@STATUS,@DATEMAINT)";
            try
            {
                

                conn.Open();
                iDB2Command cmd = new iDB2Command(cmdText, conn);
                cmd.DeriveParameters();


                cmd.Parameters["@PLANENO"].Value = textBox1.Text;
                cmd.Parameters["@MAXDIST"].Value = Convert.ToInt32(textBox2.Text);
                cmd.Parameters["@FCLASS"].Value = Convert.ToInt32(textBox3.Text);
                cmd.Parameters["@CCLASS"].Value = Convert.ToInt32(textBox4.Text);
                cmd.Parameters["@PAVAIL"].Value = textBox5.Text;
                cmd.Parameters["@MAINTMILES"].Value = textBox6.Text;
                cmd.Parameters["@PLANEMODEL"].Value = textBox7.Text;
                cmd.Parameters["@PMAKE"].Value = textBox8.Text;
                cmd.Parameters["@APARCD"].Value = textBox9.Text;
                cmd.Parameters["@APACTDT"].Value = textBox10.Text;
                cmd.Parameters["@APIACTDT"].Value = textBox11.Text;
                cmd.Parameters["@STATUS"].Value = textBox12.Text;
                cmd.Parameters["@DATEMAINT"].Value = textBox13.Text;

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
