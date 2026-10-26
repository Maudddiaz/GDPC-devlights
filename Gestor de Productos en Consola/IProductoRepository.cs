using System;
using System.Collections.Generic;
using System.Text;

namespace Gestor_de_Productos_en_Consola
{
    public interface IProductoRepository
    {
        void AgregarProducto(Producto P);
        List<Producto> ObtenerTodos();
        Producto ObtenerPorId(int Id);
        List<Producto> BuscarPorCategoria(string Categoria);
    }
}
