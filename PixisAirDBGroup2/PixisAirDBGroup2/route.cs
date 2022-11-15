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

        }
    }
}
