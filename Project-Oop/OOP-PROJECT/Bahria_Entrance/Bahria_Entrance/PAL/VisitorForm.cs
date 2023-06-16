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
using Bahria_Entrance.DAL;
using Bahria_Entrance.PAL;
using Bahria_Entrance.BAL;

namespace Bahria_Entrance.PAL
{
    public partial class VisitorForm : Form
    {
        public VisitorForm()
        {
            InitializeComponent();
            
        }

        private void VisitorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            AddVisitor v3 = new AddVisitor();
            v3.Show();
            this.Hide();
        }

        private void btnDisplayVisitor_Click(object sender, EventArgs e)
        {
            DataSet ds = DbQueries.GetDataThroughAdapterVisitor();
            grdVisitor.DataSource = ds.Tables["tbl_Visitor"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateVisitor v6 = new UpdateVisitor();
            v6.Show();
            this.Hide();
        }
    }
}
