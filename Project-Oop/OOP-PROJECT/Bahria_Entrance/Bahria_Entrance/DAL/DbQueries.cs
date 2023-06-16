using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bahria_Entrance.DAL;
using Bahria_Entrance.PAL;
using Bahria_Entrance.BAL;

namespace Bahria_Entrance.DAL
{
    class DbQueries
    {
        public static SqlConnection GetConnection()
        {
            string strConnection = "Data Source = DESKTOP-3UJE4DD\\SQLEXPRESS; Initial Catalog = Bahria_Town_Entrance_System1 ; Integrated Security = true;";
            SqlConnection connection = new SqlConnection(strConnection);
            try
            {
                connection.Open();
                MessageBox.Show("Connection is successful");

            }
            catch (Exception)
            {
                MessageBox.Show("Connection is not successful");

            }
            return connection;
        }

      //Connected Layer
        public static SqlDataReader GetDataThroughReader()
        {
           string query = "SELECT * FROM dbo.tbl_Resident";
           SqlConnection connection = GetConnection();
           SqlCommand command = new SqlCommand(query, connection);
           command.CommandType = CommandType.Text;
           return command.ExecuteReader();
        }
        //Disconnected Layer
        public static DataSet GetDataThroughAdapter()
        {
            string query = "SELECT * FROM dbo.tbl_Resident";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Resident");
            return ds;
        }

        public static DataSet GetDataThroughAdapterVisitor()
        {
            string query = "SELECT * FROM dbo.tbl_Visitor";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Visitor");
            return ds;
        }
        //Visitor Add Record
        public static void ADDRECORD(Bahria_Entrance.BAL.Visitor visitor)
        {
            string query = "INSERT INTO dbo.tbl_Visitor VALUES (@CNIC, @Name, @PhoneNumber, @VisitNo,@HouseNo)";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@CNIC", visitor.CNIC);
            command.Parameters.AddWithValue("@Name", visitor.Name);
            command.Parameters.AddWithValue("@PhoneNumber", visitor.PhoneNumber);
            command.Parameters.AddWithValue("@VisitNo", visitor.VisitNo);
            command.Parameters.AddWithValue("@HouseNo", visitor.HouseNo);
            command.ExecuteNonQuery();
        }

        //Resident Add Record

        public static void AddRecord(Bahria_Entrance.BAL.Resident resident)
        {
            string qry = "INSERT INTO dbo.tbl_Resident VALUES (@CNIC,@Name,@R_Address,@CardNo,@PhoneNo,@HouseNo)";
            SqlConnection connection = GetConnection();
            SqlCommand command=new SqlCommand(qry,connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@CNIC",resident.CNIC);
            command.Parameters.AddWithValue("@Name",resident.Name);
            command.Parameters.AddWithValue("@R_Address",resident.R_Address);
            command.Parameters.AddWithValue("@CardNo",resident.CardNo);
            command.Parameters.AddWithValue("@PhoneNo",resident.PhoneNo);
            command.Parameters.AddWithValue("@HouseNo",resident.HouseNo);
            command.ExecuteNonQuery();
            
        }

        //Update Record of Visitor
        public static void UPDATERECORD(Bahria_Entrance.BAL.Visitor visitor)
        {
            string query = "UPDATE dbo.tbl_Visitor SET VisitNo = @VisitNo WHERE CNIC = @CNIC ;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@CNIC", visitor.CNIC);
            command.Parameters.AddWithValue("@VisitNo", visitor.VisitNo);
            
            command.ExecuteNonQuery();
        }
        //Delete Record
        public static void DeleteRecord(string cnic)
        {
            string qry = "DELETE FROM dbo.tbl_Resident WHERE CNIC = @CNIC;";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@CNIC", cnic);
            command.ExecuteNonQuery();
        }

        //Search Resident
        public static DataSet SearchData(string Card)
        {
            string qry = "SELECT * FROM dbo.tbl_Resident WHERE CardNo = '" + Card + "';";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tbl_Resident");
            return ds;

        }

    }
}
