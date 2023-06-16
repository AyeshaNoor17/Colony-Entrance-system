using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bahria_Entrance.PAL
{
    public partial class UpdateVisitor : Form
    {
        public UpdateVisitor()
        {
            InitializeComponent();
        }

        private void btnUpdateSubmit_Click(object sender, EventArgs e)
        {
            int visitno = int.Parse(txtUpadateVisit.Text);
            string CNIC = txtUpdateCNIC.Text;

            BAL.Visitor v3= new BAL.Visitor(CNIC, visitno);
            try
            {
                DAL.DbQueries.UPDATERECORD(v3);
                MessageBox.Show("Record Updated SuccesFully");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to update");
            }

            VisitorForm v8 = new VisitorForm();
            v8.Show();
            this.Hide();
        }
    }
}
