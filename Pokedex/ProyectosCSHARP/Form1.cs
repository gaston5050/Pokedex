using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Dominio;
using Negocio;
namespace ProyectosCSHARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();

            dgvPokemons.DataSource = negocio.Listar();
            dgvPokemons.Columns["UrlImagen"].Visible = false;

            pbImagen.Load();

           
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPokemons.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);


            }


        }

        private void cargarImagen(string imagen)
        {

            try
            {
                pbImagen.Load(imagen);

            }
            catch (Exception ex)
            {
            
                pbImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }




        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Alta  ventana = new Alta();
            ventana.ShowDialog();

        }
    }
}
