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
using Bahria_Entrance.PAL;
using Bahria_Entrance.BAL;
using Bahria_Entrance.DAL;

namespace Bahria_Entrance
{
    public partial class BahriaEntrance : Form
    {
        public BahriaEntrance()
        {
            InitializeComponent();
        }

        private void btnConnectDb_Click(object sender, EventArgs e)
        {
            DataSet ds = DbQueries.GetDataThroughAdapter();
            DataSet ds1 = DbQueries.GetDataThroughAdapterVisitor();
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            VisitorForm v1 = new VisitorForm();
            v1.Show();
            this.Hide();
        }

        private void btnResident_Click(object sender, EventArgs e)
        {
            ResisdentForm r1 = new ResisdentForm();
            r1.Show();
            this.Hide();
        }
    }
}
