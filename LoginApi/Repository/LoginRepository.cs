using System.Data.SqlClient;
using System.Collections.Generic;
using LoginApi.Models;
using System.Threading.Tasks;
using Dapper;

namespace LoginApi.Repository
{
    public class LoginRepository : ILoginRepository
    {
        //private readonly string connectionString = "Server=LAPTOP-L60MS628;Database=CalanderApp;Trusted_Connection=True;";
        private readonly string connectionString = "Server=myfirstonlineserver07012021.database.windows.net;Database=CalanderApp;Trusted_Connection=True;";
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

        public IEnumerable<BookingDetails> GetBookingDetails(int id)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                string sql = $"EXEC get_booked_dates_info @LoginDetailsID = {id};";
                sqlConnection.Open();
                return sqlConnection.Query<BookingDetails>(sql);
            }
        }

        public IEnumerable<BookingDetails> PostNewBooking(FormDataRequest formDataRequest)
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                string sql = $"EXEC dbo.add_booking @LoginDetailsID = {formDataRequest.LoginId}, " +
                             $"@Date = '{formDataRequest.FormattedDate}', " +
                             $"@Description = '{formDataRequest.Description}' , " +
                             $"@EventName = '{formDataRequest.EventName}' , " +
                             $"@StartTime = '{formDataRequest.StartTime}' , " +
                             $"@EndTime = '{formDataRequest.EndTime}', " +
                             $"@Location = '{formDataRequest.Location}'";
                sqlConnection.Open();
                return sqlConnection.Query<BookingDetails>(sql);
            }
        }
    }
}
