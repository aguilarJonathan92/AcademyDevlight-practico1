# Gestión de Productos en Consola

## Objetivo
Aplicar los fundamentos de Programación Orientada a Objetos (POO), diseño con Interfaces, manipulación de listas en memoria (List<T>) y consultas con LINQ en una aplicación C# de consola.

---

## Descripción del Problema
Una tienda local necesita un prototipo simple para gestionar sus productos en memoria antes de migrar su sistema a una Web API. Deberás construir una solución de consola que modele los datos y permita realizar operaciones básicas sobre el catálogo.

---
## Requerimientos Técnicos

1. Modelo de Dominio (Producto)
Crear la clase `Producto` con las siguientes propiedades automáticas:

- `Id` (int)
- `Nombre` (string)
- `Precio` (decimal)
- `Categoria` (string)
- `Activo` (bool)

2. Interfaz de Contrato (`IProductoRepository`)
Definir una interfaz que establezca las operaciones sobre los productos:

- `void Agregar(Producto producto)`
- `List<Producto> ObtenerTodos()`
- `Producto ObtenerPorId(int id)`
- `List<Producto> BuscarPorCategoria(string categoria)`

3. Implementación en Memoria (`ProductoRepository`)

- Crear la clase que implemente `IProductoRepository`.
- Utilizar una `List<Producto>` privada para almacenar los registros de forma temporal.
- Inicializar la lista en el constructor con 3 o 4 productos de prueba por defecto (seed data).
- Implementar las búsquedas y filtrados utilizando métodos de extensión de LINQ (`Where`, `FirstOrDefault`, `ToList`).

4. Ejecución
- Instanciar la clase del repositorio (`IProductoRepository repo = new ProductoRepository();`) en el `Program.cs`.
- Probar en la consola:
	- La impresión de la lista completa.
	- La búsqueda de un producto por ID.
	- El filtrado de productos por categoría.
	- La incorporación de un nuevo producto usando `Agregar(...).`