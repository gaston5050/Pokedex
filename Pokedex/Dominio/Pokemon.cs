using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio
{
    public class Pokemon
    {

        public int Id { get; set; }
        //[DisplayName ("Á´CÉ´N´TÓ´S")]
        public string Nombre { get; set; }

        public int Numero { get; set; }
        public string Descripcion { get; set; }
        
        public string UrlImagen { get; set; }

        public Elemento Tipo { get; set; }
        public Elemento Debilidad { get; set; }
    }
}
