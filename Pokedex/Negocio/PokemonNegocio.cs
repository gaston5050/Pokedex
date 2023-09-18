using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

using AccesoDatos;


namespace Negocio
{
    public class PokemonNegocio
    {
        //  private List<Pokemon> Listado;

        public List<Pokemon> Listar()
        {

            List<Pokemon> lista = new List<Pokemon>();
            try
            {
                Acceso acceso = new Acceso();

            acceso.SetearConsulta("Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1");
            acceso.EjecutarLectura();


                while (acceso.getLector.Read())
                {
                    Pokemon aux = new Pokemon();

                    aux.Id = (int)acceso.getLector["id"];
                    aux.Nombre = (string)acceso.getLector["nombre"];
                    aux.UrlImagen = (string)acceso.getLector["urlImagen"];
                    aux.Descripcion = (string)acceso.getLector["descripcion"];
                    aux.Tipo = new Elemento();
                    aux.Numero = (int)acceso.getLector["numero"];

                    aux.Tipo.Descripcion = (string)acceso.getLector["Tipo"];

                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion= (string)acceso.getLector["Debilidad"];


                    lista.Add(aux);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }















       
          

            return lista;


        }

        public void agregar(Pokemon pokemon)
        {
            Acceso conexion = new Acceso();

            try
            {
              conexion.SetearConsulta
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }



    }
}
