using Microsoft.AspNetCore.Mvc;
using Lab4_Productos_JuanMurillo.Models;

namespace Lab4_Productos_JuanMurillo.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            var lista = ProductoRepositorio.ObtenerTodos();
            return View(lista);
        }

        public IActionResult Detalles(int id)
        {
            var p = ProductoRepositorio.ObtenerPorId(id);
            return View(p);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Producto p)
        {
            if (!ModelState.IsValid)
                return View(p);

            ProductoRepositorio.Agregar(p);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var p = ProductoRepositorio.ObtenerPorId(id);
            return View(p);
        }

        [HttpPost]
        public IActionResult Editar(Producto p)
        {
            if (!ModelState.IsValid)
                return View(p);

            ProductoRepositorio.Actualizar(p);
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int id)
        {
            var p = ProductoRepositorio.ObtenerPorId(id);
            return View(p);
        }

        [HttpPost]
        public IActionResult EliminarConfirmado(int id)
        {
            ProductoRepositorio.Eliminar(id);
            return RedirectToAction("Index");
        }
    }
}
