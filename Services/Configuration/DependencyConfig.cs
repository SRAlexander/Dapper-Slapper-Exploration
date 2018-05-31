using SimpleInjector;

namespace Services.Configuration
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
            //container.Register<IDbContext, Context>(Lifestyle.Scoped);

            DAL.Configuration.DependencyConfig.Setup(container);
        }
    }
}
    
