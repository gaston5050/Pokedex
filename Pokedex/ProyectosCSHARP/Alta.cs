﻿using System;
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
      
             
          

            cbDebilidad.DataSource = elementoNegocio.listarElementos();
            cbTipo.DataSource = elementoNegocio.listarElementos();

         


            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pokemon  pokemon = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                pokemon.Nombre = tbNombre.Text;
                pokemon.Descripcion = tbDescripcion.Text;   
                pokemon.UrlImagen = tbUrlImagen.Text;
                pokemon.Id= int.Parse(tbId.Text);
                // pokemon.Debilidad.Descripcion = tb

                negocio.agregar(pokemon);
                MessageBox.Show("Agregado exitosamente!!! ");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
