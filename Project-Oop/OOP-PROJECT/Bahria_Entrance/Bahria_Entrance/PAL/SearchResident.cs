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
    public partial class SearchResident : Form
    {
        public SearchResident()
        {
            InitializeComponent();
        }

        private void btnSearchResident_Click(object sender, EventArgs e)
        {
            DataSet ds = DAL.DbQueries.SearchData(txtSearchCard.Text);
            grdShowSearch.DataSource=ds.Tables["tbl_Resident"];
        }

        private void grdShowSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
