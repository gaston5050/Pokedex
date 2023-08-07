using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class ElementoNegocio
    {
        
      public List<Elemento> listarElementos()
        {
            List <Elemento> lista = new List<Elemento>();
            Acceso datos = new Acceso();


            datos.SetearConsulta("select id, descripcion from elementos");
            datos.EjecutarLectura();

            while (datos.getLector.Read()) {

                Elemento aux = new Elemento();
                aux.Id = (int)datos.getLector["id"];
                aux.Descripcion = (string)datos.getLector["descripcion"];
                lista.Add(aux);            
            }





            return lista;
        }
            

    }
}
