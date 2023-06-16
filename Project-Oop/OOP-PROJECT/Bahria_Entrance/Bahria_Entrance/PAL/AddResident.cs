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
    public partial class AddResident : Form
    {
        public AddResident()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRAdd_Click(object sender, EventArgs e)
        {
            string CNIC = txtRCNIC.Text;
            int CardNumber = int.Parse(txtCardNumber.Text);
            string Name = txtRName.Text;
            string RAddress = txtRAddress.Text;
            string PhoneNumber = txtRPhone.Text;
            int HouseNum = int.Parse(txtRHouseNo.Text);

            BAL.Resident resident = new BAL.Resident(CNIC, Name, RAddress, CardNumber, PhoneNumber, HouseNum);

            try
            {
                DbQueries.AddRecord(resident);
                MessageBox.Show("added");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Cannot");
            }

            ResisdentForm r3 = new ResisdentForm();
            r3.Show();
            this.Hide();

        }
    }
}
