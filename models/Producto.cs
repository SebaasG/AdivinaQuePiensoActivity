using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica28_04.models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int ProveedorId { get; set; }



    }
}