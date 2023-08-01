﻿using System;
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

            acceso.SetearConsulta("select id, nombre, urlImagen from pokemons");
            acceso.EjecutarLectura();


            while (acceso.getLector.Read())
            {
                Pokemon aux = new Pokemon();

                aux.Id = (int)acceso.getLector["id"];
                aux.Nombre = (string)acceso.getLector["nombre"];
                aux.UrlImagen = (string)acceso.getLector["urlImagen"];

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