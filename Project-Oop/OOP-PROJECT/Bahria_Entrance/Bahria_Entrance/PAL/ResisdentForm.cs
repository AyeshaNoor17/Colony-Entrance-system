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
using Bahria_Entrance.BAL;
using Bahria_Entrance.PAL;


namespace Bahria_Entrance.PAL
{
    public partial class ResisdentForm : Form
    {
        public ResisdentForm()
        {
            InitializeComponent();
        }

        private void ResisdentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddResident r2 = new AddResident();
            r2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = DbQueries.GetDataThroughAdapter();
            grdResident.DataSource = ds.Tables["tbl_Resident"];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchResident s1 = new SearchResident();
            s1.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ResidentDelete dr = new ResidentDelete();
            dr.Show();
            this.Hide();
        }
    }
}
