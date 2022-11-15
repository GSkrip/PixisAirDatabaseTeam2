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
            String cmdText = "INSERT INTO ROUTE VALUES(@RTID, @RTARDEPART, @RTARARRIVL, @RTDISTANCE, @RTESTTM, " +
                             "@RTBASECOST, @RTACTDT, @RTIACTDT, @RTNO)";
            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu;LibraryList=FLIGHT2022;Naming=System");
                conn.Open();

                string rtactdt = rTACTDTDateTimePicker.Value.Year.ToString() + "-" + rTACTDTDateTimePicker.Value.Month.ToString() +
                                 "-" + rTACTDTDateTimePicker.Value.Day.ToString();
                string rtiactdt = rTIACTDTDateTimePicker.Value.Year.ToString() + "-" + rTIACTDTDateTimePicker.Value.Month.ToString() +
                                 "-" + rTIACTDTDateTimePicker.Value.Day.ToString();


                iDB2Command cmd = new iDB2Command(cmdText, conn);
                cmd.DeriveParameters();

                cmd.Parameters["@RTID"].Value = Int32.Parse(rTIDTextBox.Text);
                cmd.Parameters["@RTARDEPART"].Value = rTARDEPARTTextBox.Text.ToUpper();
                cmd.Parameters["@RTARARRIVL"].Value = rTARARRIVLTextBox.Text.ToUpper();
                cmd.Parameters["@RTDISTANCE"].Value = float.Parse(rTDISTANCETextBox.Text);
                cmd.Parameters["@RTESTTM"].Value = Int32.Parse(rTESTTMTextBox.Text);
                cmd.Parameters["@RTBASECOST"].Value = float.Parse(rTBASECOSTTextBox.Text);
                cmd.Parameters["@RTACTDT"].Value = rtactdt;
                cmd.Parameters["@RTIACTDT"].Value = rtiactdt;
                cmd.Parameters["@RTNO"].Value = rTNOTextBox;
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                displayListBox.Items.Add(ex.Message);
            }
        }
    }
}
