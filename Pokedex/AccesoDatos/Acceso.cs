using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class Acceso
    {

        private SqlConnection Conexion;
        private SqlCommand Comando;
        private SqlDataReader Lector;


        public SqlDataReader getLector {
            get { return Lector; }
        }

        public Acceso() {

            Conexion = new SqlConnection("server = .\\SQLEXPRESS; database = POKEDEX_DB; integrated security = true");
            Comando = new SqlCommand();
            }


        public void SetearConsulta(string consulta)
        {
            Comando.CommandType = System.Data.CommandType.Text;

            Comando.CommandText = consulta;

        }

        public void EjecutarLectura()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Lector = Comando.ExecuteReader();


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }


        }

        public void EjecutarAccion()
        {
            Comando.Connection = Conexion;

            try
            {
                Conexion.Open();
                Comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }


        }

        public void SetearParametro (string nombre, object valor)
        {
          //  Comando.Parameters.AddWithValue = (nombre, valor);


        }


        public void CerrarConexion()
        {
            if(Lector != null) {
                Lector.Close();
                Conexion.Close();

            }
        }




    }
}
