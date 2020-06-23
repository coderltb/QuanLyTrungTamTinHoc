using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserAccess : DatabaseAccess
    {
        public List<User> layToanBoUser()
        {
            #region Dùng Store Procedure

            List<User> dsuser = new List<User>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("LayToanBoUser");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User user = new User();
                user._MaUser = reader.GetInt32(0);
                user._UserName = reader.GetString(1);
                user._Password = reader.GetString(2);
                user._SDT = reader.GetString(3);
                user._Email = reader.GetString(4);
                user._IsAdmin = reader.GetBoolean(5);
                dsuser.Add(user);
            }
            reader.Close();
            closeConnected();
            return dsuser;

            #endregion Dùng Store Procedure
        }

        public bool Register_Admin(User user)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("Register_Admin");
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = user._UserName;
            command.Parameters.Add("@Pwd", SqlDbType.VarChar).Value = user._Password;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = user._SDT;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = user._Email;
            command.Parameters.Add("@IsAdmin", SqlDbType.Bit).Value = user._IsAdmin;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool Register_User(User user)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("Register_User");
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = user._UserName;
            command.Parameters.Add("@Pwd", SqlDbType.VarChar).Value = user._Password;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = user._SDT;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = user._Email;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool Delete_Amin(int mauser)
        {
            #region Dùng Store Procedure

            openConnected();
            SqlCommand command = createCommandStoredProcedure("Delete_Amin");
            command.Parameters.Add("@MaUser", SqlDbType.Int).Value = mauser;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v

            #endregion Dùng Store Procedure
        }

        public bool Edit_Amin(User user)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("Edit_Amin");
            command.Parameters.Add("@MaUser", SqlDbType.Int).Value = user._MaUser;
            command.Parameters.Add("@Username", SqlDbType.VarChar).Value = user._UserName;
            command.Parameters.Add("@Pwd", SqlDbType.VarChar).Value = user._Password;
            command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = user._SDT;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = user._Email;
            command.Parameters.Add("@IsAdmin", SqlDbType.Bit).Value = user._IsAdmin;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }
    }
}