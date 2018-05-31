using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAPPER
{
    public interface IDapperLogQueries
    {
        void AddLogEntry(int userId, string message);
    }
}
