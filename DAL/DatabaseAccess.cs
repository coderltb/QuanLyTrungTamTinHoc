using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseAccess
    {
        #region Nơi điền thông tin Database để kết nối vs VS

        //private string sql = "Server = DESKTOP-4S5PH6K;Database = QL_TRUNGTAMCNTT;User id = sa;pwd = 1";
        //private string sql = "Server = DESKTOP-58F1T8S\\GIATUAN;Database = QL_TRUNGTAMCNTT;User id = sa;pwd = 17071999";
        private string sql = "Server = DESKTOP-QAROGUG\\SQLEXPRESS;Database = QL_TRUNGTAMCNTT;User id = sa;pwd = sa2012";

        #endregion Nơi điền thông tin Database để kết nối vs VS

        #region Hàm Dùng Chung

        public SqlConnection conn = null;

        protected void openConnected()
        {
            if (conn == null)
            {
                conn = new SqlConnection(sql);
            }
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        protected SqlCommand createCommandStoredProcedure(string s)
        {
            SqlCommand sql = new SqlCommand();
            sql.CommandType = CommandType.StoredProcedure;
            sql.CommandText = s;
            sql.Connection = conn;
            return sql;
        }

        protected SqlCommand createCommandText(string s)
        {
            SqlCommand sql = new SqlCommand();
            sql.CommandType = CommandType.StoredProcedure;
            sql.CommandText = s;
            sql.Connection = conn;
            return sql;
        }

        protected void closeConnected()
        {
            if (conn != null || conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        #endregion Hàm Dùng Chung
    }
}