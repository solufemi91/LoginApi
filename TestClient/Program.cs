using LoginApiClientV3;
using LoginApiClientV3.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestClient
{
    public class Program
    {

        public static int Test { get; set; }
        static void Main(string[] args)
        {

            Test = 1;

            var listOfWeeks = new List<Week>();

            while (Test < 30)
            {
                listOfWeeks.Add(GenerateWeek());
            }
            

        }

        public async Task<IEnumerable<BookingDetailsDTO>> CallClientAsync()
        {
            var client = new LoginClient();

            var result = await client.GetBookingDetailsAsync(5);

            return result;
        }


        public static Week GenerateWeek()
        {
            int[] days = new int[7];
            int indexPositionOfDate = 0;
            for (int dayDateNumber = Test; indexPositionOfDate < 6; dayDateNumber++)
            {
                DateTime now = DateTime.Now;

                DateTime date = new DateTime(now.Year, now.Month, dayDateNumber);

                indexPositionOfDate = ((int)date.DayOfWeek == 0) ? 6 : (int)date.DayOfWeek - 1;

                days[indexPositionOfDate] = dayDateNumber;
                Test++;
            }

            var week = new Week
            {
                Days = days
            };

            return week;
        }


    }

    public class Calendar
    {
        public List<string> DaysOfTheWeek { get; set; }

        public List<Year> Years { get; set; }
    }

    public class Year
    {
        public List<Month> Months { get; set; }
    }

    public class Month
    {
        public List<Week> Weeks { get; set; }
    }

    public class Week
    {
        public int[] Days { get; set; }
    }

}
