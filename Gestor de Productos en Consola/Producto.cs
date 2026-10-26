using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor_de_Productos_en_Consola
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public string Categoria { get; set; }
        public bool Activo { get; set; }
    }
}
