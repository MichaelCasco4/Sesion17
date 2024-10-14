﻿using System;
using Sesion17.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Runtime.Remoting.Messaging;

namespace Sesion17.Servicio
{
    internal class ProductoServicio
    {
        List<Producto> productos = new List<Producto>();
        public List<Producto> Productos()
        {
            return productos;
        }


        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }
        public Producto BuscarProducto(Producto producto)
        {
            return productos.Find(prod => prod.ID == producto.ID);
        }
        public void EliminarProducto(Producto producto)
        {
          productos.Remove(producto);
         
        }
    public void ActualizarProducto(Producto producto, int id)
        {
            int index = productos.FindIndex(prod => prod.ID == id);

            if (index != -1)
            {
                productos[index] = producto;
            }
        }

    }
}