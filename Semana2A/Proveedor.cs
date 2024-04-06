using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2A
{
    public class Proveedor
    {
        public int idProveedor {  get; set; }
        public string nombreCompañia { get; set; }
        public string nombreContacto { get; set; }
        public string cargocontacto { get; set; }
        public string direccion { get; set; }

        public Proveedor (int idProveedor, string nombreCompañia, string nombreContacto, string cargocontacto, string direccion)
        {
            this.idProveedor = idProveedor;
            this.nombreCompañia = nombreCompañia;
            this.nombreContacto = nombreContacto;
            this.cargocontacto = cargocontacto;
            this.direccion = direccion;
        }
    }
}
