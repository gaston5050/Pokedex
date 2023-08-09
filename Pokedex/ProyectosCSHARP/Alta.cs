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
            cbTipo.DisplayMember = "descripcion";
            cbTipo.ValueMember = "id";
               Elemento x = (Elemento)cbTipo.SelectedItem;
            lbTipoInvisible.Text = x.Id.ToString();
          

            cbDebilidad.DataSource = elementoNegocio.listarElementos();

            cbDebilidad.DisplayMember = "descripcion";
            cbDebilidad.ValueMember = "id";
             x = (Elemento)cbDebilidad.SelectedItem;
            if (cbDebilidad.ValueMember(
                ) != x.Id)
            {


            }



        }
              
       
    }
}
