using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace ProyectosCSHARP
{
    public partial class Alta : Form
    {
        Pokemon pokemon = null;
       public Alta()
        {

            InitializeComponent();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Alta_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            
            
            cbTipo.DataSource = elementoNegocio.listarElementos();
            cbTipo.ValueMember = "id";
            cbTipo.DisplayMember = "descripcion";
            cbDebilidad.DataSource = elementoNegocio.listarElementos();
            // cbTipo.DataSource = elementoNegocio.listarElementos();
            cbDebilidad.DisplayMember = "descripcion";
            cbDebilidad.ValueMember = "id";
             
          if(pokemon != null) {

                tbId.Text = pokemon.Id.ToString();
            //    tbNumero.Text = pokemon.
                tbNumero.Text = pokemon.Numero.ToString();
                tb
            
            
            }


        




    }
}
