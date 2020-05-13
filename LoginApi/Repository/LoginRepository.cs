using System.Data.SqlClient;
using System.Collections.Generic;
using LoginApi.Models;
using System.Threading.Tasks;
using Dapper;

namespace LoginApi.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly string connectionString = "Server=LAPTOP-L60MS628;Database=CalanderApp;Trusted_Connection=True;";
        private SqlConnection sqlConnection;

        public IEnumerable<LoginDetails> GetLogin(LoginRequest loginRequest)
        {
            using(sqlConnection = new SqlConnection(connectionString))
            {
                string sql = $"SELECT * FROM Login_Details WHERE UserName = '{loginRequest.UserName}' AND Password = '{loginRequest.Password}' ";
                sqlConnection.Open();
                return sqlConnection.Query<LoginDetails>(sql);
            }
        }
    }
}
