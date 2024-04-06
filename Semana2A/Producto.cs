using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2A
{
    public class Producto
    {
        public int idproducto { get; set; }
        public string nombreProducto { get; set; }
        public string cantidadPorUnidad { get; set; }
        public decimal precioUnidad { get; set; }
        public string categoriaProducto { get; set; }

        public Producto(int idproducto, string nombreProducto, string cantidadPorUnidad, decimal precioUnidad, string categoriaProducto)
        {
            this.idproducto = idproducto;
            this.nombreProducto = nombreProducto;
            this.cantidadPorUnidad = cantidadPorUnidad;
            this.precioUnidad = precioUnidad;
            this.categoriaProducto = categoriaProducto;
        }
    }
}
