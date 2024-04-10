using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadRealizar.Clases
{
    /// <summary>
    /// hemos establecido nuestra cadena de conexion para pg admin
    /// </summary>
    internal class CConexion
    {
        NpgsqlConnection conectar = new NpgsqlConnection();

        static string servidor = "localhost";

        static string bd = "Empresa";

        static string usuario = "postgres";

        static string password = "rasec4";

        static string puerto = "5432";

        //Cadena de conexion de NPG
        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public NpgsqlConnection EstableceConexion()
        {
            try
            {
                conectar.ConnectionString = cadenaConexion;
                conectar.Open();
                MessageBox.Show("la conexion ha sido exitosa");
            }

            catch (NpgsqlException e)
            {
             MessageBox.Show("La conexion ha sido exitosa" + e.ToString());
            }
            //Retorna las condiciones de conectar
            return conectar;
        }
    }
}
