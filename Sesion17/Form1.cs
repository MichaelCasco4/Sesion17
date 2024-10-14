using Sesion17.Servicio;
using System;
using Sesion17.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion17
{
    public partial class Form1 : Form
    {
        ProductoServicio productos;
        public Form1()
        {
            InitializeComponent();
            productos = new ProductoServicio();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.ID = int.Parse(TbID.Text);
            prod.Name = TbNombre.Text;
            prod.Description = TbDescription.Text;
            prod.Price = double.Parse(TbPrice.Text);


        }

        private void MostrarRegistro()
        {
            DgvRegistros.DataSource = null;
            DgvRegistros.DataSource = productos.Productos(); 
        }
    }
}
