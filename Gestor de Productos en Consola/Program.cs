using Gestor_de_Productos_en_Consola;
using System;

IProductoRepository repo = new RepositorioProductos();

repo.AgregarProducto(new Producto { Id = 4, Nombre = "aceite", Precio = 2500, Categoria = "Comida", Activo = true });

Console.WriteLine("Bienvenido");

//de todos los productos
List<Producto> productos = repo.ObtenerTodos();

foreach(var p in productos)
{
    Console.WriteLine($"Id: {p.Id}, Nombre: {p.Nombre}, Precio: {p.Precio}, Categoria: {p.Categoria}, Activo: {p.Activo}");
}

Console.WriteLine("Busqueda del producto 4 ");
//Busqueda del producto cuatro solamente, lo hice asi basicamente por que sino para mostrar de otro caso habria que usar json y otras cosas.
Producto prod = repo.ObtenerPorId(4);

Console.WriteLine($"Id: {prod.Id}, Nombre: {prod.Nombre}, Precio: {prod.Precio}, Categoria: {prod.Categoria}, Activo: {prod.Activo}");

Console.WriteLine("Busqueda de productos por categoria");
//Busqueda de productos por categoria
List<Producto> productosCategoria = repo.BuscarPorCategoria("Comida");
foreach (var p in productosCategoria)
{
    Console.WriteLine($"Id: {p.Id}, Nombre: {p.Nombre}, Precio: {p.Precio}, Categoria: {p.Categoria}, Activo: {p.Activo}");
};