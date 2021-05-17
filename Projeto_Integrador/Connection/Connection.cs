using System.Configuration;

namespace Projeto_Integrador.Connection
{
    class Connection
    {
        private string connectionString;
        public string getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Projeto_Integrador.Properties.Settings.dbConnectionString"].ConnectionString;
            return connectionString;
        }
    }
}
