using Hangfire;
using System;

namespace HangfireSample.Services
{
    public class SendDailyReportsEmailJob : ISendDailyReportsEmailJob
    {
        //private readonly IDatabaseContext _databaseContext;

        public SendDailyReportsEmailJob(
            //IDatabaseContext _databaseContext
            )
        {
            //_databaseContext = databaseContext;
        }

        public void SendDailyJobs()
        {
            Console.WriteLine("Here is the Job for sending customer emails");
        }
    }
}
