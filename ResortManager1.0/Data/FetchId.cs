using Microsoft.Data.SqlClient;
using Resort_Management.Models;

namespace ResortManager1._0.Data
{
    internal class FetchId
    {
        private string connectionString = @"Server=DESKTOP-ONRI7SV\\SQLEXPRESS;Database=Db;Trusted_Connection=True;MultipleActiveResultSets=true";
        public List<UserModel> FetchAll()
        {
            List<UserModel> list = new List<UserModel>();
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                string sqlQuery = "select * from dbo.Users";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        UserModel user = new UserModel();
                        user.userId = reader.GetInt32(0);
                        user.fullName = reader.GetString(1);
                        list.Add(user);
                    }
                }
            }
                return list;
        }
    }
}
