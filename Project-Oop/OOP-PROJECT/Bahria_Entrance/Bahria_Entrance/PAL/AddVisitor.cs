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

namespace Bahria_Entrance.PAL
{
    public partial class AddVisitor : Form
    {
        public AddVisitor()
        {
            InitializeComponent();
        }

        private void btnVAdd_Click(object sender, EventArgs e)
        {
            string CNIC = txtCNIC.Text;
            string Name = txtName.Text;
            string PhoneNumber = txtPhone.Text;
            int VisitNo = int.Parse(txtVisit.Text);
            int HouseNo = int.Parse(txtHouse.Text);
            
            BAL.Visitor visitor = new BAL.Visitor(CNIC, Name, PhoneNumber, VisitNo, HouseNo);
            try 
	        {
                DbQueries.ADDRECORD(visitor);
                MessageBox.Show("Added Successfully");
	        }
	        catch (Exception)
	        {
                MessageBox.Show("Problem Adding Record");
		        
	        }

            VisitorForm v2 = new VisitorForm();
            v2.Show();
            this.Hide();
        }
    }
}
