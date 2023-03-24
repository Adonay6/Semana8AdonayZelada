using Sem8Adonay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem8Adonay.CRU
{
    internal class ProdCrud
    {
        public void AgregueProduct(Producto ParametroProducto)
        {
            using (AlmacenContext BaseDeDatos = new AlmacenContext())
            {
                Producto product = new Producto();
                product.Nombre = ParametroProducto.Nombre;
                product.Descripcion = ParametroProducto.Descripcion;
                product.Precio = ParametroProducto.Precio;
                product.Stock = ParametroProducto.Stock;
                BaseDeDatos.Add(product);
                BaseDeDatos.SaveChanges();

            }
        }

    }
}