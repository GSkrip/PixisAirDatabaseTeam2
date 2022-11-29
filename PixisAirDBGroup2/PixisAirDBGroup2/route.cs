using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

namespace PixisAirDBGroup2
{
    public partial class route : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        SqlConnection connection;
        string connectionString;
        string SQL;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        public route()
        {
            InitializeComponent();
        }

        private void routeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.routeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pixisAirDataSet);

        }

        private void route_Load(object sender, EventArgs e)
        {
            this.routeTableAdapter.Fill(this.pixisAirDataSet.Route);
            connectionString = "Data Source=v2studentpoc;Initial Catalog=PixisAir;" +
                "Persist Security Info=True;User ID=Student;Password=ichooseGateway";
            SQL = "Select * FROM dbo.Route";
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter(SQL, connection);
            dataSet = new DataSet();
        }

        private void sqlSearchButton_Click(object sender, EventArgs e)
        {
            string city = cityTextBox.Text;
            SQL = "SELECT RTID, RTARDEPART, RTARARRIVL, RTDISTANCE, RTESTTM, RTBASECOST, RTACTDT, RTIACTDT, RTNO FROM" +
                   " dbo.Route WHERE RTARARRIVL = '" + city + "'";
            displayListBox.Items.Clear();
            try
            {
                connection.Open();
                dataAdapter.SelectCommand.CommandText = SQL;
                dataAdapter.Fill(dataSet);
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    displayListBox.Items.Add(dataRow[0] + ", " + dataRow[1] + ", " + dataRow[2] + ", " + dataRow[3] + 
                        ", " + dataRow[4] + ", " + dataRow[5] + ", " + dataRow[6] + ", " + dataRow[7] + ", " + dataRow[8]);
                connection.Close();
            }
            catch (Exception ex)
            {
                displayListBox.Items.Add(ex.Message);
            }
        }

        private void db2SearchButton_Click(object sender, EventArgs e)
        {
            string city = cityTextBox.Text;
            
            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu;LibraryList=FLIGHT2022;Naming=System");
                SQL = "SELECT RTID, RTARDEPART, RTARARRIVL, RTDISTANCE, RTESTTM, RTBASECOST, RTACTDT, RTIACTDT, RTNO FROM" +
                    " ROUTE WHERE RTARARRIVL = '" + city.ToUpper() + "'";
                adapter = new iDB2DataAdapter(SQL, conn);

                dataSet = new DataSet();
                adapter.Fill(dataSet);

                displayListBox.Items.Clear();
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    displayListBox.Items.Add(dataRow[0] + ", " + dataRow[1] + ", " + dataRow[2] + ", " + dataRow[3] +
                        ", " + dataRow[4] + ", " + dataRow[5] + ", " + dataRow[6] + ", " + dataRow[7] + ", " + dataRow[8]);
                conn.Close();
            }
            catch (Exception ex)
            {
                displayListBox.Items.Add(ex.Message);
            }
        }

        private void db2UpdateButton_Click(object sender, EventArgs e)
        {
            //String cmdText = "INSERT INTO ROUTE VALUES(@RTID, @RTARDEPART, @RTARARRIVL, @RTDISTANCE, @RTESTTM, " +
            // "@RTBASECOST, @RTACTDT, @RTIACTDT, @RTNO)";

            string rtactdtTemp = rTACTDTDateTimePicker.Value.ToString("s");
            string rtactdt = rtactdtTemp.Substring(0, rtactdtTemp.IndexOf("T"));
            string rtiactdtTemp = rTIACTDTDateTimePicker.Value.ToString("s");
            string rtiactdt = rtiactdtTemp.Substring(0, rtiactdtTemp.IndexOf("T"));

            string cmdText = "INSERT INTO FLIGHT2022.ROUTE  VALUES(default , '" + rTARDEPARTTextBox.Text.ToUpper() + "', '" + 
                                rTARARRIVLTextBox.Text.ToUpper() +
                                "', " + rTDISTANCETextBox.Text + ", " + rTESTTMTextBox.Text + ", " + rTBASECOSTTextBox.Text + ", '" + 
                                rtactdt + "', '" +
                                rtiactdt + "', " + rTNOTextBox.Text + ")";
            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu;LibraryList=FLIGHT2022;Naming=System");
                conn.Open();

                iDB2Command cmd = new iDB2Command();
                cmd.Connection = conn;
                cmd.CommandText = cmdText;
                cmd.ExecuteNonQuery();
                displayListBox.Items.Add("Entry added successfully.");

                /*iDB2Command cmd = new iDB2Command(cmdText, conn);
                cmd.DeriveParameters();

                cmd.Parameters["@RTID"].Value = " ";
                cmd.Parameters["@RTARDEPART"].Value = rTARDEPARTTextBox.Text.ToUpper();
                cmd.Parameters["@RTARARRIVL"].Value = rTARARRIVLTextBox.Text.ToUpper();
                cmd.Parameters["@RTDISTANCE"].Value = rTDISTANCETextBox.Text;
                cmd.Parameters["@RTESTTM"].Value = rTESTTMTextBox.Text;
                cmd.Parameters["@RTBASECOST"].Value = rTBASECOSTTextBox.Text;
                cmd.Parameters["@RTACTDT"].Value = rTACTDTDateTimePicker.Value;
                cmd.Parameters["@RTIACTDT"].Value = rTIACTDTDateTimePicker.Value;
                cmd.Parameters["@RTNO"].Value = rTNOTextBox.Text;
                cmd.ExecuteNonQuery();*/

                conn.Close();
            }
            catch (Exception ex)
            {
                displayListBox.Items.Add(ex.Message);
            }
        }
    }
}
