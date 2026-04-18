using System.Collections.Generic;
using System.Linq;

namespace Lab4_Productos_JuanMurillo.Models
{
    public static class ProductoRepositorio
    {
        private static List<Producto> lista = new List<Producto>();
        private static int ultimoId = 0;

        public static List<Producto> ObtenerTodos()
        {
            return lista;
        }

        public static Producto ObtenerPorId(int id)
        {
            return lista.FirstOrDefault(p => p.Id == id);
        }

        public static void Agregar(Producto p)
        {
            ultimoId++;
            p.Id = ultimoId;
            lista.Add(p);
        }

        public static void Actualizar(Producto p)
        {
            var existente = ObtenerPorId(p.Id);
            if (existente != null)
            {
                existente.Nombre = p.Nombre;
                existente.Precio = p.Precio;
                existente.Categoria = p.Categoria;
            }
        }

        public static void Eliminar(int id)
        {
            var p = ObtenerPorId(id);
            if (p != null)
            {
                lista.Remove(p);
            }
        }
    }
}
