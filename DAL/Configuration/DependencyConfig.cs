using System.Data.Entity;
using DAL.DAPPER;
using SimpleInjector;

namespace DAL.Configuration
{
    /// <summary>
    /// 
    /// </summary>
    public static class DependencyConfig
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="container"></param>
        public static void Setup(Container container)
        {
            container.Register<DbContext, Context>(Lifestyle.Scoped);

            container.Register<IDapperLogQueries, DapperLogQueries>(Lifestyle.Scoped);
        }
    }
}

