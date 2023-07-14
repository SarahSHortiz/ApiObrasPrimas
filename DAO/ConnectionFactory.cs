using MySqlConnector;
using MySql.Data.MySqlClient;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace ApiObrasPrimas.DAO
{
    public class ConnectionFactory
    {
        public static MySqlConnection Build()
        {
            return new MySqlConnection("Server=localhost;Database=Obras_primas;Uid=root;Pwd=root;");
        }
    }
}

