using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformQuanLyKho
{
    public class Connect
    {
        static string connectionSTR = "Data Source=LAPTOP-AENPMFML\\SQLEXPRESS;Initial Catalog=QL_KHOHANG;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionSTR);

        public void Moketnoi()
        {
            connection.Open();
        }
        public void Dongketnoi()
        {
            connection.Close();
        }


        public DataTable bangDulieu(string query)
        {
            DataTable datatable = new DataTable();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(datatable);

            return datatable;
        }
        public SqlCommand xulythemxoasua(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            return command;
        }

    }
    
}
