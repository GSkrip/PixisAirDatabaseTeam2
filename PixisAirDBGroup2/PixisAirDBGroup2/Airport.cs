// SQL connection
//Tom Matelski
//11/21/2022

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PixisAirDBGroup2
{
    public partial class Airport : Form
    {
        SqlConnection connection;
        string connectionString;
        string SQL;
        SqlDataAdapter adapter;
        DataSet data;
        public Airport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pixisAirDataSet.AIRPORT' table. You can move, or remove it, as needed.
            this.aIRPORTTableAdapter.Fill(this.pixisAirDataSet.AIRPORT);

        }

        private void aIRPORTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aIRPORTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pixisAirDataSet);

        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            connectionString = "Data Source=v2studentpoc;Initial Catalog=PixisAir;Persist Security Info=True;User ID=Student;Password=ichooseGateway";
            SQL = "SELECT * FROM AIRPORT";
            try
            {
                connection = new SqlConnection(connectionString);
                adapter = new SqlDataAdapter(SQL, connection);
                data = new DataSet();
                adapter.Fill(data);
                foreach (DataRow dataRow in data.Tables[0].Rows)
                    listBox1.Items.Add(dataRow[0] + ", " + dataRow[1] + ", " + dataRow[2] + ", " + dataRow[3]);
                connection.Close();

            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IbmBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
