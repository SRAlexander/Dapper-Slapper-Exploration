using DAL.DAPPER;

namespace Services.Services
{
    public class LoggingService : ILoggingService
    {
        private readonly IDapperLogQueries _dapperLogQueries;

        public LoggingService(IDapperLogQueries dapperLogQueries)
        {
            _dapperLogQueries = dapperLogQueries;
        }

        public void Log()
        {
            _dapperLogQueries.AddLogEntry(1, "Hello World");
        }
    }
}
