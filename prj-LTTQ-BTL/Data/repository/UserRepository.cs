using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Data.Repository
{
    internal class UserRepository: BaseRepository
    {
        public DataRow GetUserByUsernameAndPassword(string username, string password)
        {
            string query = @"
                SELECT u.username, r.name AS role
                FROM [User] u
                INNER JOIN Role r ON u.role_id = r.id
                WHERE u.username = @username AND u.password = @password";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", SqlDbType.NVarChar) { Value = username },
                new SqlParameter("@password", SqlDbType.VarChar) { Value = password }
            };

            DataTable result = ExecuteQuery(query, parameters);
            //DataTable result = GetDataTable(query);
            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }
    }
}
