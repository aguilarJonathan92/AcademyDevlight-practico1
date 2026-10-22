using AppGestionProductos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppGestionProductos.Repositories
{
    public interface IProductoRepository
    {
        public void Agregar(Producto producto);
        List<Producto> ObtenerTodos();
        Producto? ObtenerPorId(int id);
        List<Producto> BuscarPorCategoria(string categoria);
    }
}
