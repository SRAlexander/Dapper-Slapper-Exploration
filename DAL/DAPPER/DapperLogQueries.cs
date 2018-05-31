using Dapper;

namespace DAL.DAPPER
{
    public class DapperLogQueries : DapperBase, IDapperLogQueries
    {
        public void AddLogEntry(int userId, string message)
        {
            connection.Execute(@"insert into LogEntries(userId, Message) values(@user, @message)",
                new[]
                {
                    new {user = 1, message = "This a a string message of an action"},
                    new {user = 2, message = "This a a string message of an action 2"},
                    new {user = 3, message = "This a a string message of an action 3"}
                });
        }
    }
}
