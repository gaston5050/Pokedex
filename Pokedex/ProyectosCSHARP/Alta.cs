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
            ElementoNegocio tipo = new ElementoNegocio();
            ElementoNegocio debilidad = new ElementoNegocio();
            cbTipo.DataSource = tipo.listarElementos();
            cbDebilidad.DataSource = debilidad.listarElementos();

            
        }

       
    }
}