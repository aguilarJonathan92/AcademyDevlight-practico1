using AppGestionProductos.Repositories;
using AppGestionProductos.Models;

IProductoRepository productos = new ProductoRepository();

Console.WriteLine("Bienvenido al sistema de gestión de productos \n");
Console.WriteLine("****** LISTA COMPLETA DE PRODUCTOS ******");

foreach (var producto in productos.ObtenerTodos())
{
    Console.WriteLine(producto);
}

Console.WriteLine("\n\n****** BUSQUEDA DE UN PRODUCTO POR ID (para la prueba, ID=2)");

var productoBuscado = productos.ObtenerPorId(2);

if(productoBuscado != null)
{
    Console.WriteLine($"Producto encontrado! \n {productoBuscado}");
}
else
{
    Console.WriteLine("Producto no encontrado");
}

Console.WriteLine("\n\n****** FILTRADO DE PRODUCTOS POR CATEGORÍA (para la prueba, Categoría=limpieza)");

var productosFiltrados = productos.BuscarPorCategoria("Limpieza");

if (productosFiltrados.Count > 0)
{
    Console.WriteLine("Productos encontrados: ");
    foreach (var producto in productosFiltrados)
    {
        Console.WriteLine(producto);
    }
}
else
{
    Console.WriteLine("No se encontraron productos en la categoría especificada");
}

Console.WriteLine("\n\n****** Incorporación de un nuevo producto.");

var nuevoProducto = new Producto
{
    Id = 2,
    Nombre = "laptop HP victus",
    Precio = 150.99m,
    Categoria = "tecnologia",
    Activo = true
};

productos.Agregar(nuevoProducto);


