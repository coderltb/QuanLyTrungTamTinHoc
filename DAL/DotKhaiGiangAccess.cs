using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DotKhaiGiangAccess : DatabaseAccess
    {
        public List<DotKhaiGiang> LayToanBoDotKhaiGiang()
        {
            List<DotKhaiGiang> dskg = new List<DotKhaiGiang>();
            openConnected();
            SqlCommand command = createCommandStoredProcedure("LayDotKhaiGiang");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DotKhaiGiang dkg = new DotKhaiGiang();
                dkg._MaDotKhaiGiang = reader.GetInt32(0);
                dkg._TenDotKhaiGiang = reader.GetString(1);
                dskg.Add(dkg);
            }
            reader.Close();
            closeConnected();
            return dskg;
        }

        public bool themDotKhaiGiang(DotKhaiGiang kg)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("AddDotKhaiGiang");
            command.Parameters.Add("@TenDotKhaiGiang", SqlDbType.NVarChar).Value = kg._TenDotKhaiGiang;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool xoaDotKhaiGiang(string tenkg)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("DeleteDotKhaiGiang");
            command.Parameters.Add("@TenDotKhaiGiang", SqlDbType.Int).Value = tenkg;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }

        public bool capnhatDotKhaiGiang(DotKhaiGiang kg)
        {
            openConnected();
            SqlCommand command = createCommandStoredProcedure("EditDotKhaiGiang");
            command.Parameters.Add("@MaDotKhaiGiang", SqlDbType.Int).Value = kg._MaDotKhaiGiang;
            command.Parameters.Add("@TenDotKhaiGiang", SqlDbType.NVarChar).Value = kg._TenDotKhaiGiang;
            int kq = command.ExecuteNonQuery();
            closeConnected();
            return kq > 0;//Nếu trả về 1(true) thì nhập thành công, ngược lại thì bik r đấy :v
        }
    }
}