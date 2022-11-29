using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixisAirDBGroup2
{
    public partial class MainForm : Form
    {
        private IBMJordan ibmJordan;
        private SQLBoyer sqlBoyer;
        private Airport tomAirport;
        private IBM tomIbm;
        private route gregRoute;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnJordanSql_Click(object sender, EventArgs e)
        {
            sqlBoyer = new SQLBoyer();
            sqlBoyer.Show();
        }

        private void btnJordanIBM_Click(object sender, EventArgs e)
        {
            ibmJordan = new IBMJordan();
            ibmJordan.Show();
        }

        private void btnTomIBM_Click(object sender, EventArgs e)
        {
            tomIbm = new IBM();
            tomIbm.Show();
        }

        private void btnTomSql_Click(object sender, EventArgs e)
        {
            tomAirport = new Airport();
            tomAirport.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gregRoute = new route();
            gregRoute.Show();
        }

        private void routeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gregRoute = new route();
            gregRoute.Show();
        }

        private void airplaneSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlBoyer = new SQLBoyer();
            sqlBoyer.Show();
        }

        private void airplaneDB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ibmJordan = new IBMJordan();
            ibmJordan.Show();
        }

        private void airportSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tomAirport = new Airport();
            tomAirport.Show();
        }

        private void airportDB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tomIbm = new IBM();
            tomIbm.Show();
        }
    }
}
