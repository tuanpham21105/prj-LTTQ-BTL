using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Data.Repository
{
    internal class BaseRepository
    {
        public string strConnect = "Server=DESKTOP-4L48BIF\\SQLEXPRESS;" +
                "DataBase=LTTQ_BTL_DB;Integrated Security=true;Trusted_Connection=True;TrustServerCertificate=True;";
        public SqlConnection sqlConnect = null;
        public void OpenConnect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }

        public void CloseConnect()
        {
            if (sqlConnect.State != ConnectionState.Closed)
                sqlConnect.Close();
            sqlConnect.Dispose();
        }

        public DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnect);
            adapter.Fill(dt);
            CloseConnect();
            return dt;
        }


        public void UpdateData(string cmd)
        {
            OpenConnect();
            SqlCommand command = new SqlCommand(cmd, sqlConnect);
            command.ExecuteNonQuery();
            command.Dispose();
            CloseConnect();
        }
        protected DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            OpenConnect();

            using (SqlCommand command = new SqlCommand(query, sqlConnect))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            CloseConnect();
            return dataTable;
        }

        protected int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            OpenConnect();

            using (SqlCommand command = new SqlCommand(query, sqlConnect))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                int rowsAffected = command.ExecuteNonQuery();
                CloseConnect();
                return rowsAffected;
            }
        }
    }
}
