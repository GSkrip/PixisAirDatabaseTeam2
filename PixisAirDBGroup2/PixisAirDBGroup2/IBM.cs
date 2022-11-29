//IBM connection 
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

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            string sql;

            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu;LibraryList=FLIGHT2022;Naming=System");
                sql = "SELECT * FROM AIRPORT";
                adapter = new iDB2DataAdapter(sql, conn);

                dataset = new DataSet();
                adapter.Fill(dataset);

                listBox1.Items.Clear();
                foreach (DataRow pRow in dataset.Tables[0].Rows)
                    listBox1.Items.Add(pRow[0] + "  " + pRow[1] + "  " + pRow[2] + "  " + pRow[3] + "  " + pRow[4] + "  " + pRow[5] + "  " + pRow[6] + "  " + pRow[7] +
                                     "  " + pRow[8] + "  " + pRow[9] + "  " + pRow[10] );
                conn.Close();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            //*******************************************************
            //This function inserts a new record into BOAT_TYPE2
            //It uses a command object and parameters
            //*******************************************************
            String cmdText = "INSERT INTO AIRPORT VALUES(@ARCD, @ARMN, @ARCITYNM, @ARCNCD, @ARFAACD, @ARICAOCD, +" +
                            "@ARLATITUDE, @ARLNGITUDE, @ARALTITUDE, @ARTIMEZNM, @ARTIMEZOF)";

            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu;LibraryList=FLIGHT2022;Naming=System");
                conn.Open();

                iDB2Command cmd = new iDB2Command(cmdText, conn);
                cmd.DeriveParameters();

                cmd.Parameters["@ARCD"].Value = textBox1.Text;
                cmd.Parameters["@ARMN"].Value = textBox2.Text;
                cmd.Parameters["@ARCITYNM"].Value = textBox3.Text;
                cmd.Parameters["@ARCNCD"].Value = textBox4.Text;
                cmd.Parameters["@ARFAACD"].Value = textBox5.Text;
                cmd.Parameters["@ARICAOCD"].Value = textBox6.Text;
                cmd.Parameters["@ARLATITUDE"].Value = textBox7.Text;
                cmd.Parameters["@ARLNGITUDE"].Value = textBox8.Text;
                cmd.Parameters["@ARALTITUDE"].Value = textBox9.Text;
                cmd.Parameters["@ARTIMEZNM"].Value = textBox10.Text;
                cmd.Parameters["@ARTIMEZOF"].Value = textBox11.Text;

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
               
                listBox1.Items.Add(ex.Message);
            }
        }
    }
}
