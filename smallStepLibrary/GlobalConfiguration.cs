using System.Configuration;

namespace smallStepLibrary
{
    public static class GlobalConfiguration
    {

        public static void InitializeConnection()
        {
            SqlConnector sql = new SqlConnector();
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
