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
    public partial class ResidentDelete : Form
    {
        public ResidentDelete()
        {
            InitializeComponent();
        }

        private void btnSubmitDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DbQueries.DeleteRecord(txtDeleteCNIC.Text);
                MessageBox.Show("Record Deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Error Deleting");
                
            }

            ResisdentForm r1 = new ResisdentForm();
            r1.Show();
            this.Hide();
        }
    }
}
