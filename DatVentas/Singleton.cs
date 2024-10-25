using System.Data.SqlClient;

namespace DatVentas
{
    public  class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();
        private SqlConnection connection;

        // Constructor privado para evitar instanciación externa
        private Singleton()
        {
           // var con = new SqlConnection(MasterConnection.connection);
            //string connectionString = "your_connection_string_here";
            connection = new SqlConnection(MasterConnection.connection);
        }


        // Método estático para obtener la instancia única
        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        // Método para obtener la conexión
        public SqlConnection GetConnection()
        {
            return connection;
        }

    }
}
