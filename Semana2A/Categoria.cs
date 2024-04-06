using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2A
{
    public class Categoria
    {
        public int idcategoria {  get; set; }
        public string nombrecategoria {  get; set; }
        public string descripcion {  get; set; }
        public string codCategoria {  get; set; }

        public Categoria(int idcategoria, string nombrecategoria, string descripcion, string codCategoria)
        {
            this.idcategoria = idcategoria;
            this.nombrecategoria = nombrecategoria;
            this.descripcion = descripcion;
            this.codCategoria = codCategoria;
        }
    }
}
