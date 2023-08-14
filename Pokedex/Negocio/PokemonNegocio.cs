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

            acceso.SetearConsulta("select id, nombre, urlImagen, idtipo, iddebilidad from pokemons");
            acceso.EjecutarLectura();


            while (acceso.getLector.Read())
            {
                Pokemon aux = new Pokemon();

                aux.Id = (int)acceso.getLector["id"];
                aux.Nombre = (string)acceso.getLector["nombre"];
                aux.UrlImagen = (string)acceso.getLector["urlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)acceso.getLector["idtipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)acceso.getLector["iddebilidad"];

                lista.Add(aux);
            }

            }
            catch (Exception ex)
            {

                throw ex;
            }

















            return lista;


        }





    }
}
