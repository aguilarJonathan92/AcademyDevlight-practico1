using AppGestionProductos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppGestionProductos.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly List<Producto> _productos;

        public ProductoRepository()
        {
            _productos = new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Fideo", Precio = 10.99m, Categoria = "Alimentos", Activo = true },
                new Producto { Id = 2, Nombre = "Arroz", Precio = 15.49m, Categoria = "Alimentos", Activo = true },
                new Producto { Id = 3, Nombre = "Polenta", Precio = 7.99m, Categoria = "Alimentos", Activo = false },
                new Producto { Id = 4, Nombre = "Lavandina", Precio = 12.99m, Categoria = "Limpieza", Activo = true }
            };
        }
        public void Agregar(Producto producto)
        {
            if(_productos.Exists(p => p.Id == producto.Id))
            {
                throw new ArgumentException($"Ya existe un producto con el Id {producto.Id}. No se agregó.");
            }
            _productos.Add(producto);
        }

        public List<Producto> BuscarPorCategoria(string categoria)
        {
            return _productos
                .Where(p => p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public Producto ObtenerPorId(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }

        public List<Producto> ObtenerTodos()
        {
            return _productos.ToList();
        }
    }
}
