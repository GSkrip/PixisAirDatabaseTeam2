using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PixisAirDBGroup2
{
    public partial class SQLBoyer : Form
    {
        SqlConnection connection;
        string connectionString;
        string SQL;
        SqlDataAdapter adapter;
        DataSet data;
        public SQLBoyer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectionString = "Data Source=V2StudentPOC;Initial Catalog=PixisAir;" +
                "Persist Security Info=True;User ID=student;Password=ichooseGateway";
            SQL = "SELECT * FROM dbo.Airplane";
            try
            {
                connection = new SqlConnection(connectionString);
                adapter = new SqlDataAdapter(SQL, connection);
                data = new DataSet();
                adapter.Fill(data);
                foreach (DataRow dataRow in data.Tables[0].Rows)
                    listBox1.Items.Add(dataRow[0] + ", " + dataRow[1] + ", " + dataRow[2] + ", " + dataRow[3] + ", " + dataRow[4] + ", " + dataRow[5] + ", " + dataRow[6] + ", " 
                        + dataRow[7] + ", " + dataRow[8] + ", " + dataRow[9] + ", " + dataRow[10] + ", " + dataRow[11] + ", " + dataRow[12]);
                connection.Close();

            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void airplaneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airplaneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pixisAirDataSet);

        }

        private void airplaneBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.airplaneBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pixisAirDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pixisAirDataSet.Airplane' table. You can move, or remove it, as needed.
            this.airplaneTableAdapter.Fill(this.pixisAirDataSet.Airplane);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
