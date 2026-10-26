using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor_de_Productos_en_Consola
{
    public class RepositorioProductos : IProductoRepository
    {
        private List<Producto> productos;

        public RepositorioProductos()//este es el metodo constructor que inicializa con algunos productos de prueba 
        {
            productos = new List<Producto>()
            {
                new Producto { Id = 1, Nombre = "harina", Precio = 1500, Categoria = "Comida", Activo = true },
                new Producto { Id = 2, Nombre = "azucar", Precio = 2000, Categoria = "Comida", Activo = true },
                new Producto { Id = 3, Nombre = "Rueda", Precio = 1750, Categoria = "Transporte", Activo = true },
            };
        }

        public void AgregarProducto(Producto p) 
        {
            productos.Add(p);
        }

        public List<Producto> ObtenerTodos() => productos;

        public Producto ObtenerPorId(int id) 
        {
            Producto prod = productos.FirstOrDefault(p => p.Id == id);
            return prod;
        }

        public List<Producto> BuscarPorCategoria(string Categoria) 
        {
            List<Producto> conjuntoProductos = productos.Where(p => p.Categoria == Categoria).ToList();
            return conjuntoProductos;
        }


    }
}
